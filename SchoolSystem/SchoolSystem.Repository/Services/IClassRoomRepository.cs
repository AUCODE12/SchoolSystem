using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IClassRoomRepository
{
    Task<ClassRoom> SelectClassRoomByIdAsync(int id);
    Task<List<ClassRoom>> SelectAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take);
    Task InsertClassRoomAsync(ClassRoom classRoom);
    Task UpdateClassRoomAsync(ClassRoom classRoom);
    Task DeleteClassRoomAsync(int id);
}