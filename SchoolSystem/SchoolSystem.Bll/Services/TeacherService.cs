using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        this.teacherRepository = teacherRepository;
    }

    public Task DeleteTeacherAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertTeacherAsync(TeacherDto teacher)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherDto>> SelectAllTeachersAsync(bool includeClassRoom, bool includeStudent, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDto> SelectTeacherByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeacherAsync(TeacherDto teacher)
    {
        throw new NotImplementedException();
    }
}
