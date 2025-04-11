using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class ClassRoomRepository : IClassRoomRepository
{
    private readonly MainContext _mainContext;

    public ClassRoomRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }

    public async Task DeleteClassRoomAsync(long id)
    {
        var classRoom = await SelectClassRoomByIdAsync(id);
        _mainContext.ClassRooms.Remove(classRoom);
        await _mainContext.SaveChangesAsync();
    }


    public async Task<long> InsertClassRoomAsync(ClassRoom classRoom)
    {
        await _mainContext.ClassRooms.AddAsync(classRoom);
        await _mainContext.SaveChangesAsync();
        return classRoom.ClassRoomId;
    }

    public async Task<List<ClassRoom>> SelectAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take)
    {
        IQueryable<ClassRoom> query = _mainContext.ClassRooms;
        if (includeStudent )
        {
            query = query.Include(b => b.ClassRoomStudents);
        }
        if (includeTeacher)
        {
            query = query.Include(b => b.ClassRoomTeachers);
        }

            return await quit
    }

    public async Task<ClassRoom> SelectClassRoomByIdAsync(long id)
    {
        var classroomId = await _mainContext.ClassRooms.FirstOrDefaultAsync(b => b.ClassRoomId == id);
        if (classroomId is null)
        {
            throw new Exception("wrong Id");
        }
        return classroomId;
    }

    public async Task UpdateClassRoomAsync(ClassRoom classRoom)
    {
        var classroomDb = await SelectClassRoomByIdAsync(classRoom.ClassRoomId);
        var index = _mainContext.IndexOf(classroomDb);
    }
}
