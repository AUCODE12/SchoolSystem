using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class TeacherRepository : ITeacherRepository
{
    public Task DeleteTeacherAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertTeacherAsync(Teacher teacher)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> SelectAllTeachersAsync(bool includeStudent, bool includeClass, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Teacher> SelectTeacherByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeacherAsync(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
