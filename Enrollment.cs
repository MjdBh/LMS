namespace Learning.Management.System.Data.Model;

public class Enrollment: BaseEntity
{
    public Student Student { get; set; }
    public Course Course { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public CancellationReason CancellationReason { get; set; }
}