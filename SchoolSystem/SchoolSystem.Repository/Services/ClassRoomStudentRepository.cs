
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class ClassRoomStudentRepository : IClassRoomStudentRepository
{
    private readonly MainContext mainContext;

    public ClassRoomStudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public Task DeleteClassRoomStudentAsync(long classRoomId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoomStudent> GetClassRoomStudentAsync(long classRoomId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertClassRoomStudentAsync(ClassRoomStudent classRoomStudent)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> SelectClassRoomsByStudentIdAsync(long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> SelectStudentsByClassRoomIdAsync(long classRoomId)
    {
        throw new NotImplementedException();
    }
}
