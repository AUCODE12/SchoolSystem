namespace SchoolSystem.Repository.Services;

public interface ITeacherStudentRepository
{
    Task InsertTeacherStudentAsync(int teacherId, int studentId);
    Task DeleteTeacherStudentAsync(int teacherId, int studentId);
    Task<List<int>> SelectStudentsByTeacherIdAsync(int teacherId);
    Task<List<int>> SelectTeachersByStudentIdAsync(int studentId);
}