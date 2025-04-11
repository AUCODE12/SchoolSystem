namespace SchoolSystem.Repository.Services;

public interface IClassRoomStudentRepository
{
    Task InsertClassRoomStudentAsync(int classRoomId, int studentId);
    Task DeleteClassRoomStudentAsync(int classRoomId, int studentId);
    Task<List<int>> SelectStudentsByClassRoomIdAsync(int classRoomId);
    Task<List<int>> SelectClassRoomsByStudentIdAsync(int studentId);
}

/***
Task InsertClassRoomStudentAsync(int classRoomId, int studentId);

Vazifa: Bu funksiya berilgan classRoomId (sinf) va studentId (talaba) parametrlariga asoslanib, talabani sinfga qo'shadi. Bu o'zaro bog'lanish (relationship) yaratish vazifasini bajaradi.

Task DeleteClassRoomStudentAsync(int classRoomId, int studentId);

Vazifa: Bu funksiya berilgan classRoomId va studentId parametrlariga asoslanib, talabani ma'lum sinfdan o'chiradi.

Task<List<int>> SelectStudentsByClassRoomIdAsync(int classRoomId);

Vazifa: Bu funksiya berilgan classRoomId bo'yicha, o'sha sinfga tegishli bo'lgan talabalar ro'yxatini qaytaradi. Ro'yxat faqat talabalar idlaridan iborat bo'ladi.

Task<List<int>> SelectClassRoomsByStudentIdAsync(int studentId);

Vazifa: Bu funksiya berilgan studentId bo'yicha, o'sha talabaning qatnashayotgan barcha sinflarini qaytaradi. Ro'yxat faqat sinflar idlaridan iborat bo'ladi.