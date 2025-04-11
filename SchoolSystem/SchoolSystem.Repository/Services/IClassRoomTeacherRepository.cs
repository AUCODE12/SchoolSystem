namespace SchoolSystem.Repository.Services;

public interface IClassRoomTeacherRepository
{
    Task InsertClassRoomTeacherAsync(long classRoomId, long teacherId);
    Task DeleteClassRoomTeacherAsync(long classRoomId, long teacherId);
    Task<List<long>> SelectTeachersByClassRoomIdAsync(long classRoomId);
    Task<List<long>> SelectClassRoomsByTeacherIdAsync(long teacherId);
}

/***
Task InsertClassRoomTeacherAsync(int classRoomId, int teacherId);

Vazifa: Bu funksiya berilgan classRoomId (sinf) va teacherId (o'qituvchi) parametrlariga asoslanib, o'qituvchini sinfga qo'shadi. Bu o'zaro bog'lanish (relationship) yaratish vazifasini bajaradi.

Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId);

Vazifa: Bu funksiya berilgan classRoomId va teacherId parametrlariga asoslanib, o'qituvchini ma'lum sinfdan o'chiradi.

Task<List<int>> SelectTeachersByClassRoomIdAsync(int classRoomId);

Vazifa: Bu funksiya berilgan classRoomId bo'yicha, o'sha sinfda ishlayotgan barcha o'qituvchilarni qaytaradi. Ro'yxat faqat o'qituvchilar idlaridan iborat bo'ladi.

Task<List<int>> SelectClassRoomsByTeacherIdAsync(int teacherId);

Vazifa: Bu funksiya berilgan teacherId bo'yicha, o'sha o'qituvchining dars berayotgan barcha sinflarini qaytaradi. Ro'yxat faqat sinflar idlaridan iborat bo'ladi.