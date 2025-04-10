
namespace SchoolSystem.Repository.Services;

public class ClassRoomTeacherRepository : IClassRoomTeacherRepository
{
    public Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task InsertClassRoomTeacherAsync(int classRoomId, int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectClassRoomsByTeacherIdAsync(int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectTeachersByClassRoomIdAsync(int classRoomId)
    {
        throw new NotImplementedException();
    }
}
