
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class ClassRoomStudentService : IClassRoomStudentService
{
    private readonly IClassRoomStudentRepository classRoomStudentRepository;
    
    public ClassRoomStudentService(IClassRoomStudentRepository classRoomStudentRepository)
    {
        this.classRoomStudentRepository = classRoomStudentRepository;
    }

    public Task AddClassRoomStudentAsync(int classRoomId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClassRoomStudentAsync(int classRoomId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetClassRoomsByStudentIdAsync(int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetStudentsByClassRoomIdAsync(int classRoomId)
    {
        throw new NotImplementedException();
    }
}
