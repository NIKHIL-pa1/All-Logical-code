using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text.Json;
using Reesp_Api_Crud.Data;
using Reesp_Api_Crud.Model;

namespace Reesp_Api_Crud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IDistributedCache _cache;

        public ProductsController(ApplicationDbContext context, IDistributedCache cache)
        {
            _context = context;
            _cache = cache;
        }

        [HttpGet("paged")]
        public async Task<IActionResult> GetProducts([FromQuery] PaginationParams pagination)
        {

           // var res = _context.custInfo.Include(x => x.cID).ToList(); //Eager loading query to undertand n+1
           // var res1 = _context.custInfo.Select(x => new
           // {
           //     cid = x.cID,
           //     keyNo = x.keyNo                                   //Projection query to undertand n+1
           // });


            var query = _context.custInfo.AsQueryable();
            var totalcount = await query.CountAsync();
            var items = await query
            .Skip((pagination.pagenum - 1) * pagination.PageSize)
            .Take(pagination.PageSize)
            .ToListAsync();

            var result = new PagedResult<CusInfo>
            {
                CurrentPage = pagination.pagenum,
                PageSize = pagination.PageSize,
                TotalCount = totalcount,
                TotalPages = (int)Math.Ceiling(totalcount / (double)pagination.PageSize),
                Data = items
            };

            return Ok(result);

        }

        [HttpGet("all1")]
        public async Task<IActionResult> GetRecods1([FromQuery] PaginationParams pagination)
        {
            var cachkey = $"custInfo_page_{pagination.pagenum}_{pagination.PageSize}";
            var cacheData = await _cache.GetStringAsync(cachkey);

            if (cacheData != null)
            {
                return Ok(JsonConvert.DeserializeObject(cachkey));

            }
            var custInfo = await _context.custInfo.AsNoTracking()
                .Skip((pagination.pagenum - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            await _cache.SetStringAsync(cachkey,
                JsonConvert.SerializeObject(custInfo));

            return Ok(custInfo);
        }




        [HttpGet("all")]
        public async Task<IActionResult> GetRecods([FromQuery] PaginationParams pagination)
        {
            var cacheKey = $"custInfo_page_{pagination.pagenum}_{pagination.PageSize}";

            var cacheData = await _cache.GetStringAsync(cacheKey);

            if (!string.IsNullOrEmpty(cacheData))
            {
                var data = System.Text.Json.JsonSerializer.Deserialize<List<CusInfo>>(cacheData);

                return Ok(new
                {
                    Source = "Redis Cache",
                    Data = data
                });
            }

            var totalRecords = await _context.custInfo.CountAsync();

            var custInfo = await _context.custInfo
                .AsNoTracking()
                .Skip((pagination.pagenum - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            var serialized = System.Text.Json.JsonSerializer.Serialize(custInfo);

            await _cache.SetStringAsync(
                cacheKey,
                serialized,
                new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
                });

            return Ok(new
            {
                Source = "Database",
                Data = custInfo
            });
        }

        [HttpGet("redis-test")]
        public async Task<IActionResult> TestRedis()
        {
            await _cache.SetStringAsync("test", "hello");

            var value = await _cache.GetStringAsync("test");

            return Ok(value);
        }
    }
}
