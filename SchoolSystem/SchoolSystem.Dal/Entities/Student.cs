namespace SchoolSystem.Dal.Entities;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }

    public List<ClassRoomStudent> ClassRoomStudents { get; set; }
    public List<TeacherStudent> TeacherStudents { get; set; }
}
