
using SchoolSystem.Dal;

namespace SchoolSystem.Repository.Services;

public class ClassRoomTeacherRepository : IClassRoomTeacherRepository
{
    private readonly MainContext mainContext;

    public ClassRoomTeacherRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public Task DeleteClassRoomTeacherAsync(long classRoomId, long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task InsertClassRoomTeacherAsync(long classRoomId, long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<long>> SelectClassRoomsByTeacherIdAsync(long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<long>> SelectTeachersByClassRoomIdAsync(long classRoomId)
    {
        throw new NotImplementedException();
    }
}
