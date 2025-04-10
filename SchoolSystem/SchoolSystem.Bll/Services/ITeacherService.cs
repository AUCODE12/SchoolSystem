using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface ITeacherService
{
    Task<TeacherDto> SelectTeacherByIdAsync(int id);
    Task<List<TeacherDto>> SelectAllTeachersAsync(bool includeClassRoom, bool includeStudent, int skip, int take);
    Task InsertTeacherAsync(TeacherDto teacher);
    Task UpdateTeacherAsync(TeacherDto teacher);
    Task DeleteTeacherAsync(int id);
}