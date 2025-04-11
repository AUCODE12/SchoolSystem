
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Bll.Services;

public class ClassRoomStudentService : IClassRoomStudentService
{
    private readonly IClassRoomStudentRepository classRoomStudentRepository;
    
    public ClassRoomStudentService(IClassRoomStudentRepository classRoomStudentRepository)
    {
        this.classRoomStudentRepository = classRoomStudentRepository;
    }

    public Task<long> AddClassRoomStudentAsync(ClassRoomStudentDto classRoomStudentDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteClassRoomStudentAsync(long classRoomId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoomDto>> GetClassRoomsByStudentIdAsync(long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoomStudentDto> GetClassRoomStudentAsync(long classRoomId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<StudentDto>> GetStudentsByClassRoomIdAsync(long classRoomId)
    {
        throw new NotImplementedException();
    }
}
