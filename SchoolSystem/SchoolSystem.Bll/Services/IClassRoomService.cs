using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface IClassRoomService
{
    Task<ClassRoomDto> GetClassRoomByIdAsync(int id);
    Task<List<ClassRoomDto>> GetAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take);
    Task AddClassRoomAsync(ClassRoomDto classRoom);
    Task UpdateClassRoomAsync(ClassRoomDto classRoom);
    Task DeleteClassRoomAsync(int id);
}