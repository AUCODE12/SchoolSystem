
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class ClassRoomTeacherService : IClassRoomTeacherService
{
    private readonly IClassRoomTeacherRepository classRoomTeacherRepository;

    public ClassRoomTeacherService(IClassRoomTeacherRepository classRoomTeacherRepository)
    {
        this.classRoomTeacherRepository = classRoomTeacherRepository;
    }

    public Task<long> AddClassRoomTeacherAsync(ClassRoomTeacherDto classRoomTeacherDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClassRoomTeacherAsync(long classRoomId, long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoomDto>> GetClassRoomsByTeacherIdAsync(long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoomTeacherDto> GetClassRoomTeacherAsync(long classRoomId, long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherDto>> GetTeachersByClassRoomIdAsync(long classRoomId)
    {
        throw new NotImplementedException();
    }
}
