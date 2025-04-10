namespace SchoolSystem.Dal.Entities;

public class ClassRoomTeacher
{
    public int ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; }

    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}
