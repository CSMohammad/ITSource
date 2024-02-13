using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITSource.Models
{
    //file
    public class Chapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileID { get; set; }
        [Required]
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        [Required]
        public string FileName { get; set; }
        public string FileType { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //auto generate for date 
        public DateTime UploadDate { get; set; } = DateTime.Now; //auto datetime generation
        public int FileSize { get; set; }
        public string FileDownloadPath { get; set; }










    }
}