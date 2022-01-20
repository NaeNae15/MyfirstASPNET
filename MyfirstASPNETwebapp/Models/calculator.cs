using System;
using System.ComponentModel.DataAnnotations;
namespace MyfirstASPNETwebapp.Models
{
    public class gradeCalcModel
    {
        [Required (ErrorMessage = "For Assignments, you must input a number between 0 and 100")]
        [Range (0, 100, ErrorMessage = "You must input a number between 0 and 100")]
        public int Assignments { get; set; }
        [Required(ErrorMessage = "For Quizes, you must input a number between 0 and 100")]
        [Range(0, 100, ErrorMessage = "You must input a number between 0 and 100")]
        public int Quizes { get; set; }
        [Required(ErrorMessage = "For Intex, you must input a number between 0 and 100")]
        [Range(0, 100, ErrorMessage = "You must input a number between 0 and 100")]
        public int Intex { get; set; }
        [MaxLength(100)]
        public string Extra { get; set; }
    }
}
