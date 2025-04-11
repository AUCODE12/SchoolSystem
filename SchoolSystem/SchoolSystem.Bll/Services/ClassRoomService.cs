using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class ClassRoomService : IClassRoomService
{
    private readonly IClassRoomRepository classRoomRepository;

    public ClassRoomService(IClassRoomRepository classRoomRepository)
    {
        this.classRoomRepository = classRoomRepository;
    }

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
