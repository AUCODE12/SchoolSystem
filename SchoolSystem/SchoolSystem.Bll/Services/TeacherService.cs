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

    public Task DeleteTeacherAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertTeacherAsync(TeacherDto teacher)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherDto>> SelectAllTeachersAsync(bool includeClassRoom, bool includeStudent, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherDto> SelectTeacherByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeacherAsync(TeacherDto teacher)
    {
        throw new NotImplementedException();
    }
}
