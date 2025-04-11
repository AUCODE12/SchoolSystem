
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class ClassRoomTeacherService : IClassRoomTeacherService
{
    private readonly IClassRoomTeacherRepository classRoomTeacherRepository;

    public ClassRoomTeacherService(IClassRoomTeacherRepository classRoomTeacherRepository)
    {
        this.classRoomTeacherRepository = classRoomTeacherRepository;
    }

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
