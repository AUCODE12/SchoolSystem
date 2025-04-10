using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class StudentRepository : IStudentRepository
{
    public Task DeleteStudentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> SelectAllStudentsAsync(bool includeTeacher, bool includeClass, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Student> SelectStudentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }
}
