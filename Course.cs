namespace Learning.Management.System.Data.Model;

public class Course: BaseEntity
{
    public string CourseName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Category Category { get; set; }
    public string CourseAbstract { get; set; }
    public string Bibliography { get; set; }
}