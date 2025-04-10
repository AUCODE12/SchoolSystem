namespace SchoolSystem.Dal.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Subject { get; set; }

    public List<ClassRoomTeacher> ClassRoomTeachers { get; set; }
    public List<TeacherStudent> TeacherStudents { get; set; }
}
