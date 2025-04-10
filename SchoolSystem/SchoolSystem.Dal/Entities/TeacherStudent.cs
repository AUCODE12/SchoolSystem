namespace SchoolSystem.Dal.Entities;

public class TeacherStudent
{
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public long StudentId { get; set; }
    public Student Student { get; set; }

    public DateTime InteractionDate { get; set; } = DateTime.Now;
}