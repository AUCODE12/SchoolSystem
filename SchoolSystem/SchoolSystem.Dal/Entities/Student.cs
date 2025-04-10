namespace SchoolSystem.Dal.Entities;

public class Student
{
    public long StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public List<ClassRoomStudent> ClassRoomStudents { get; set; }
    public List<TeacherStudent> TeacherStudents { get; set; }
}