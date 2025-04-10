
namespace SchoolSystem.Bll.Services;

public class ClassRoomTeacherService : IClassRoomTeacherService
{
    public Task AddClassRoomTeacherAsync(int classRoomId, int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetClassRoomsByTeacherIdAsync(int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetTeachersByClassRoomIdAsync(int classRoomId)
    {
        throw new NotImplementedException();
    }
}
