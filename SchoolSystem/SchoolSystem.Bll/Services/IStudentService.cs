using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface IStudentService
{
    Task<StudentDto> GetStudentByIdAsync(long id);
    Task<List<StudentDto>> GetAllStudentsAsync(bool includeClassRoom, bool includeTeacher, int skip, int take);
    Task<long> AddStudentAsync(StudentDto student);
    Task UpdateStudentAsync(StudentDto student);
    Task DeleteStudentAsync(long id);
}