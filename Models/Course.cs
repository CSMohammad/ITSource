using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ITSource.Models
{
    public class Course{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //generate the id automaticlly by the DB
    public int CourseID { get; set; }
    [Required]
    public int DepartmentID { get; set; }
    [ForeignKey("DepartmentID")]
    public Department Department { get; set; }
    [Required]
    public String CourseName { get; set; }
    public required ICollection<Chapter> Chapters {get; set;} //File : the name of class, (every course can has meny files)
    

}
}