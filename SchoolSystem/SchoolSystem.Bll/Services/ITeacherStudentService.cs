using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface ITeacherStudentService
{
    Task<long> AddTeacherStudentAsync(TeacherStudentDto teacherStudentDto);
    Task DeleteTeacherStudentAsync(long teacherId, long studentId);
    Task<TeacherStudentDto> GetTeacherStudentAsync(long teacherId, long studentId);
    Task<List<StudentDto>> GetStudentsByTeacherIdAsync(long teacherId);
    Task<List<TeacherDto>> GetTeachersByStudentIdAsync(long studentId);
}