
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class ClassRoomStudentRepository : IClassRoomStudentRepository
{
    private readonly MainContext mainContext;

    public ClassRoomStudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public async Task DeleteClassRoomStudentAsync(long classRoomId, long studentId)
    {
        var entity = await mainContext.ClassRoomStudents.FirstOrDefaultAsync(b => b.ClassRoomId == classRoomId && b.StudentId == studentId);
        if (entity is null)
        {
            throw new Exception("relation not found");
        }

        mainContext.ClassRoomStudents.Remove(entity);
        await mainContext.SaveChangesAsync();
    }

    public async Task<ClassRoomStudent> GetClassRoomStudentAsync(long classRoomId, long studentId)
    {
        var entity = await mainContext.ClassRoomStudents.FirstOrDefaultAsync(b => b.ClassRoomId == classRoomId && b.StudentId == studentId);
        if (entity is null)
        {
            throw new Exception("relation not found");
        }

        return entity;
    }

    public async Task<long> InsertClassRoomStudentAsync(ClassRoomStudent classRoomStudent)
    {
        await mainContext.ClassRoomStudents.AddAsync(classRoomStudent);
        await mainContext.SaveChangesAsync();
        return classRoomStudent.ClassRoomId;
    }

    public async Task<List<ClassRoom>> SelectClassRoomsByStudentIdAsync(long studentId)
    {
        return await mainContext.ClassRoomStudents
            .Where(b => b.StudentId == studentId)
            .Include(b => b.ClassRoom)
            .Select(b => b.ClassRoom)
            .ToListAsync();
    }

    public async Task<List<Student>> SelectStudentsByClassRoomIdAsync(long classRoomId)
    {
        return await mainContext.ClassRoomStudents
            .Where(b => b.ClassRoomId == classRoomId)
            .Include(b => b.Student)
            .Select(b => b.Student)
            .ToListAsync();
    }
}
