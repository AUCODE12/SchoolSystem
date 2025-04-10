namespace SchoolSystem.Repository.Services;

public interface IClassRoomTeacherRepository
{
    Task InsertClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task<List<int>> SelectTeachersByClassRoomIdAsync(int classRoomId);
    Task<List<int>> SelectClassRoomsByTeacherIdAsync(int teacherId);
}