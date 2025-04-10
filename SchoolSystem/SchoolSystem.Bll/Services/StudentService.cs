using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public class StudentService : IStudentService
{
    public Task AddStudentAsync(StudentDto student)
    {
        throw new NotImplementedException();
    }

    public Task DeleteStudentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<StudentDto>> GetAllStudentsAsync(bool includeClassRoom, bool includeTeacher, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<StudentDto> GetStudentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStudentAsync(StudentDto student)
    {
        throw new NotImplementedException();
    }
}
