using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface IStudentService
{
    Task<StudentDto> GetStudentByIdAsync(int id);
    Task<List<StudentDto>> GetAllStudentsAsync(bool includeClassRoom, bool includeTeacher, int skip, int take);
    Task AddStudentAsync(StudentDto student);
    Task UpdateStudentAsync(StudentDto student);
    Task DeleteStudentAsync(int id);
}