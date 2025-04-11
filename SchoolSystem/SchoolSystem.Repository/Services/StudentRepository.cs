using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class StudentRepository : IStudentRepository
{
    private readonly MainContext mainContext;

    public StudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public async Task DeleteStudentAsync(long id)
    {
        var student = await SelectStudentByIdAsync(id);
        mainContext.Students.Remove(student);
        await mainContext.SaveChangesAsync();
    }

    public async Task<long> InsertStudentAsync(Student student)
    {
        await mainContext.Students.AddAsync(student);
        await mainContext.SaveChangesAsync();
        return student.StudentId;
    }

    public Task<List<Student>> SelectAllStudentsAsync(bool includeTeacher, bool includeClass, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public async Task<Student> SelectStudentByIdAsync(long id)
    {
        var students = await mainContext.Students.ToListAsync();
        return students.FirstOrDefault(s => s.StudentId == id);
    }

    public async Task UpdateStudentAsync(Student student)
    {
        mainContext.Students.Update(student);
        await mainContext.SaveChangesAsync();
    }

}
