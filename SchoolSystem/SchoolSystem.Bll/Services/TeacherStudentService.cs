
namespace SchoolSystem.Bll.Services;

public class TeacherStudentService : ITeacherStudentService
{
    public Task AddTeacherStudentAsync(int teacherId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTeacherStudentAsync(int teacherId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetStudentsByTeacherIdAsync(int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetTeachersByStudentIdAsync(int studentId)
    {
        throw new NotImplementedException();
    }
}
