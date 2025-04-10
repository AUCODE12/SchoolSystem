namespace SchoolSystem.Dal.Entities;

public class Teacher
{
    public long TeacherId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public List<ClassRoomTeacher> ClassRoomTeachers { get; set; } 
    public List<TeacherStudent> TeacherStudents { get; set; }
}