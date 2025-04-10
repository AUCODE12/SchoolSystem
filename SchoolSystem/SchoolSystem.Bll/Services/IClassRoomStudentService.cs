namespace SchoolSystem.Bll.Services;

public interface IClassRoomStudentService
{
    Task AddClassRoomStudentAsync(int classRoomId, int studentId);
    Task DeleteClassRoomStudentAsync(int classRoomId, int studentId);
    Task<List<int>> GetStudentsByClassRoomIdAsync(int classRoomId);
    Task<List<int>> GetClassRoomsByStudentIdAsync(int studentId);
}