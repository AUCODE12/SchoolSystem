namespace SchoolSystem.Dal.Entities;

public class TeacherStudent
{
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
