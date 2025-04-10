using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public class TeacherService : ITeacherService
{
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
