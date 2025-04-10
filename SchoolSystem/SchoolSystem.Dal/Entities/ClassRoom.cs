namespace SchoolSystem.Dal.Entities;

public class ClassRoom
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<ClassRoomStudent> ClassRoomStudents { get; set; }
    public List<ClassRoomTeacher> ClassRoomTeachers { get; set; }
}
