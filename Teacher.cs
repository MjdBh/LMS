using System.Runtime.InteropServices.JavaScript;

namespace Learning.Management.System.Data.Model;

public class Teacher: ContactInfoBase
{
    public int Id { get; set; }
    public DateTime HireDate{ get; set; }
}