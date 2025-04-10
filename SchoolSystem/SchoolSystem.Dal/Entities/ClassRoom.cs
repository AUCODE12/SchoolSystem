namespace SchoolSystem.Dal.Entities;

public class ClassRoom
{
    public long ClassRoomId { get; set; }
    public string ClassRoomName { get; set; }
    public string Grade { get; set; }

    public List<ClassRoomStudent> ClassRoomStudents { get; set; } 
    public List<ClassRoomTeacher> ClassRoomTeachers { get; set; } 
}