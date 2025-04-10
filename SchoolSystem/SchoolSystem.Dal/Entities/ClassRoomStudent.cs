namespace SchoolSystem.Dal.Entities;

public class ClassRoomStudent
{
    public int ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
