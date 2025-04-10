
namespace SchoolSystem.Repository.Services;

public class ClassRoomStudentRepository : IClassRoomStudentRepository
{
    public Task DeleteClassRoomStudentAsync(int classRoomId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task InsertClassRoomStudentAsync(int classRoomId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectClassRoomsByStudentIdAsync(int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectStudentsByClassRoomIdAsync(int classRoomId)
    {
        throw new NotImplementedException();
    }
}
