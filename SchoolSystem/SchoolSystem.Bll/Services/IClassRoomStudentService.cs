using SchoolSystem.Bll.DTOs;
using System.Runtime.CompilerServices;

namespace SchoolSystem.Bll.Services;

public interface IClassRoomStudentService
{
    Task<long> AddClassRoomStudentAsync(ClassRoomStudentDto classRoomStudentDto);
    Task DeleteClassRoomStudentAsync(long classRoomId, long studentId);
    Task<ClassRoomStudentDto> GetClassRoomStudentAsync(long classRoomId, long studentId);
    Task<List<StudentDto>> GetStudentsByClassRoomIdAsync(long classRoomId);
    Task<List<ClassRoomDto>> GetClassRoomsByStudentIdAsync(long studentId);
}