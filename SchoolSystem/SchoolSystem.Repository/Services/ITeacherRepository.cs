using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;
public interface ITeacherRepository
{
    Task<Teacher> GetByIdAsync(int id);
    Task<List<Teacher>> GetAllAsync();
    Task AddAsync(Teacher teacher);
    Task UpdateAsync(Teacher teacher);
    Task DeleteAsync(Teacher teacher);
}
