using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models
{
    [Table("mvcRegistration")]
    public class Emp
    {
        [Key]

        public int id { get; set; }

        public string name { get; set; } = string.Empty;
        public int age { get; set; } 
        public string gender { get; set; } = string.Empty;
        public string address { get; set; }= string.Empty;
        public string course { get; set; } = string.Empty;
        public string language { get; set; } = string.Empty;

    }
}