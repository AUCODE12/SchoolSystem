namespace SchoolSystem.Bll.Services;

public interface ITeacherStudentService
{
    Task AddTeacherStudentAsync(int teacherId, int studentId);
    Task DeleteTeacherStudentAsync(int teacherId, int studentId);
    Task<List<int>> GetStudentsByTeacherIdAsync(int teacherId);
    Task<List<int>> GetTeachersByStudentIdAsync(int studentId);
}