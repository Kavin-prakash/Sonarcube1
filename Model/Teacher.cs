using System.ComponentModel.DataAnnotations;

namespace CreateWebapi.Model{
public class Teacher{
    [Key]
    public int TeacherId{get;set;} 
    [Required]
    public string? TeacherName{get;set;}
    [Required]
     public string? TeacherQualification{get;set;}
     [Required]
    public string? TeacherLocation{get;set;}
}
}