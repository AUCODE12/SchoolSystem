using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IStudentRepository
{
    Task<Student> SelectStudentByIdAsync(int id);
    Task<List<Student>> SelectAllStudentsAsync(bool includeTeacher, bool includeClass, int skip, int take);
    Task InsertStudentAsync(Student student);
    Task UpdateStudentAsync(Student student);
    Task DeleteStudentAsync(int id);
}