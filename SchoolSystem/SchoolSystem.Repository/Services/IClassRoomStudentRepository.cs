namespace SchoolSystem.Repository.Services;

public interface IClassRoomStudentRepository
{
    Task InsertClassRoomStudentAsync(int classRoomId, int studentId);
    Task DeleteClassRoomStudentAsync(int classRoomId, int studentId);
    Task<List<int>> SelectStudentsByClassRoomIdAsync(int classRoomId);
    Task<List<int>> SelectClassRoomsByStudentIdAsync(int studentId);
}