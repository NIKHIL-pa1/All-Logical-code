namespace Reesp_Api_Crud.Model
{
    public class PaginationParams
    {
        private const int MaxPagesize = 100;

        public int pagenum { get; set; } = 1;
        public int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPagesize) ? MaxPagesize : value;
        }
        //public int PageNumber { get; internal set; }
    }
}
