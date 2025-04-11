using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class TeacherRepository : ITeacherRepository
{
    private readonly MainContext mainContext;

    public TeacherRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public async Task DeleteTeacherAsync(long id)
    {
        var teacher = await SelectTeacherByIdAsync(id);
        mainContext.Teachers.Remove(teacher);
        await mainContext.SaveChangesAsync();
    }

    public async Task InsertTeacherAsync(Teacher teacher)
    {
        await mainContext.Teachers.AddAsync(teacher);
        await mainContext.SaveChangesAsync();
    }

    public Task<List<Teacher>> SelectAllTeachersAsync(bool includeStudent, bool includeClass, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public async Task<Teacher> SelectTeacherByIdAsync(long id)
    {
        var teachers = await mainContext.Teachers.ToListAsync();
        return teachers.FirstOrDefault(t => t.TeacherId == id);
    }

    public async Task UpdateTeacherAsync(Teacher teacher)
    {
         mainContext.Teachers.Update(teacher);
        await mainContext.SaveChangesAsync();
    }
}
