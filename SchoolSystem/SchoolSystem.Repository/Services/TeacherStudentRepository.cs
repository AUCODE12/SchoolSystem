
namespace SchoolSystem.Repository.Services;

public class TeacherStudentRepository : ITeacherStudentRepository
{
    public Task DeleteTeacherStudentAsync(int teacherId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task InsertTeacherStudentAsync(int teacherId, int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectStudentsByTeacherIdAsync(int teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> SelectTeachersByStudentIdAsync(int studentId)
    {
        throw new NotImplementedException();
    }
}
