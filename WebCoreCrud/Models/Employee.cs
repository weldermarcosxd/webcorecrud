using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoreCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Full Name")]
        public string Fullname { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
