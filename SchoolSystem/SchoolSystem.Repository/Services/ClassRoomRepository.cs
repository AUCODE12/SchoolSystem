using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class ClassRoomRepository : IClassRoomRepository
{
    public Task DeleteClassRoomAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertClassRoomAsync(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> SelectAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoom> SelectClassRoomByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClassRoomAsync(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }
}
