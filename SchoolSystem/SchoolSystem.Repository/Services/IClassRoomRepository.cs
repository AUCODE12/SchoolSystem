using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IClassRoomRepository
{
    Task<ClassRoom> GetByIdAsync(int id);
    Task<List<ClassRoom>> GetAllAsync();
    Task AddAsync(ClassRoom classRoom);
    Task UpdateAsync(ClassRoom classRoom);
    Task DeleteAsync(ClassRoom classRoom);
}
