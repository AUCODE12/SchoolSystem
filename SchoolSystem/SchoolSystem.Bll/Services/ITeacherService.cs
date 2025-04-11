using SchoolSystem.Bll.DTOs;

namespace SchoolSystem.Bll.Services;

public interface ITeacherService
{
    Task<TeacherDto> SelectTeacherByIdAsync(long id);
    Task<List<TeacherDto>> SelectAllTeachersAsync(bool includeClassRoom, bool includeStudent, int skip, int take);
    Task<long> InsertTeacherAsync(TeacherDto teacher);
    Task UpdateTeacherAsync(TeacherDto teacher);
    Task DeleteTeacherAsync(long id);
}