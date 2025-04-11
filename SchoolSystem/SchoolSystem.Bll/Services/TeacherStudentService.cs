
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class TeacherStudentService : ITeacherStudentService
{
    private readonly ITeacherStudentRepository teacherStudentRepository;

    public TeacherStudentService(ITeacherStudentRepository teacherStudentRepository)
    {
        this.teacherStudentRepository = teacherStudentRepository;
    }

    public Task<long> AddTeacherStudentAsync(TeacherStudentDto teacherStudentDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTeacherStudentAsync(long teacherId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<StudentDto>> GetStudentsByTeacherIdAsync(long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherDto>> GetTeachersByStudentIdAsync(long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherStudentDto> GetTeacherStudentAsync(long teacherId, long studentId)
    {
        throw new NotImplementedException();
    }
}
