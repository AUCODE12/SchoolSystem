
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class TeacherStudentRepository : ITeacherStudentRepository
{
    private readonly MainContext mainContext;

    public TeacherStudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public Task DeleteTeacherStudentAsync(long teacherId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherStudent> GetTeacherStudentAsync(long teacherId, long studentId)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertTeacherStudentAsync(TeacherStudent teacherStudent)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> SelectStudentsByTeacherIdAsync(long teacherId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> SelectTeachersByStudentIdAsync(long studentId)
    {
        throw new NotImplementedException();
    }
}
