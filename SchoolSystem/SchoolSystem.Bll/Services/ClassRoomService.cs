using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public class ClassRoomService : IClassRoomService
{
    public Task AddClassRoomAsync(ClassRoomDto classRoom)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClassRoomAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoomDto>> GetAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoomDto> GetClassRoomByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClassRoomAsync(ClassRoomDto classRoom)
    {
        throw new NotImplementedException();
    }
}
