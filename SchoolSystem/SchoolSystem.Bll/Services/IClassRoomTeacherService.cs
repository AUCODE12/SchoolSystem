namespace SchoolSystem.Bll.Services;

public interface IClassRoomTeacherService
{
    Task AddClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task<List<int>> GetTeachersByClassRoomIdAsync(int classRoomId);
    Task<List<int>> GetClassRoomsByTeacherIdAsync(int teacherId);
}