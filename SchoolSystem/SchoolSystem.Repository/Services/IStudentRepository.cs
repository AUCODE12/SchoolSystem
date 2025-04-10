using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IStudentRepository
{
    Task<Student> GetByIdAsync(int id);
    Task<List<Student>> GetAllAsync();
    Task AddAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(Student student);
}
