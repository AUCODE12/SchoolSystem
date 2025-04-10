using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface ITeacherRepository
{
    Task<Teacher> SelectTeacherByIdAsync(int id);
    Task<List<Teacher>> SelectAllTeachersAsync(bool includeStudent, bool includeClass, int skip, int take);
    Task InsertTeacherAsync(Teacher teacher);
    Task UpdateTeacherAsync(Teacher teacher);
    Task DeleteTeacherAsync(int id);
}