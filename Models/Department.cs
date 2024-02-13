using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITSource.Models
{
    public class Department
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto generate for id
        public int DepartmentID { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public ICollection<Course> Courses { get; set; } // every department has many courses


    }
}