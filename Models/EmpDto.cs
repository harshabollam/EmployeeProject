using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class EmpDto
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDomain { get; set; }

    }
}
