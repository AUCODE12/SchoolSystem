using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface IClassRoomTeacherService
{
    Task<long> AddClassRoomTeacherAsync(ClassRoomTeacherDto classRoomTeacherDto);
    Task DeleteClassRoomTeacherAsync(long classRoomId, long teacherId);
    Task<ClassRoomTeacherDto> GetClassRoomTeacherAsync(long classRoomId, long teacherId);
    Task<List<TeacherDto>> GetTeachersByClassRoomIdAsync(long classRoomId);
    Task<List<ClassRoomDto>> GetClassRoomsByTeacherIdAsync(long teacherId);
}