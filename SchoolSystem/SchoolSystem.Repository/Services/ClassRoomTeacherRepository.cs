
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

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

    public Task<ClassRoomTeacher> GetClassRoomTeacherAsync(long classRoomId, long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertClassRoomTeacherAsync(ClassRoomTeacher classRoomTeacher)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ClassRoom>> SelectClassRoomsByTeacherIdAsync(long teacherId)
    {
        var classRoomTeachers = mainContext.ClassRoomTeachers.Where(c => c.TeacherId == teacherId).ToList();
        return classRoomTeachers.Select(cR => cR.ClassRoom).ToList();
    }

    public async Task<List<Teacher>> SelectTeachersByClassRoomIdAsync(long classRoomId)
    {
        var classRoomTeachers = mainContext.ClassRoomTeachers.Where(c => c.ClassRoomId == classRoomId).ToList();
        return classRoomTeachers.Select(t => t.Teacher).ToList();
    }

    Task<List<Teacher>> IClassRoomTeacherRepository.SelectClassRoomsByTeacherIdAsync(long teacherId)
    {
        throw new NotImplementedException();
    }

    Task<List<ClassRoom>> IClassRoomTeacherRepository.SelectTeachersByClassRoomIdAsync(long classRoomId)
    {
        throw new NotImplementedException();
    }
}
