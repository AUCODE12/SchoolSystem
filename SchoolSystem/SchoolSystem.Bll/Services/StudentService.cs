using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public Task<long> AddStudentAsync(StudentDto student)
    {
        throw new NotImplementedException();
    }

    public Task DeleteStudentAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<StudentDto>> GetAllStudentsAsync(bool includeClassRoom, bool includeTeacher, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<StudentDto> GetStudentByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStudentAsync(StudentDto student)
    {
        throw new NotImplementedException();
    }
}
