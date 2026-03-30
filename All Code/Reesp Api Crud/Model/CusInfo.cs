using System.ComponentModel.DataAnnotations;

namespace Reesp_Api_Crud.Model
{
    public class CusInfo
    {
        [Key]
        public int cID { get; set; }

        public string keyNo { get; set; }

        public string firmName { get; set; }
    }
}
