namespace SchoolSystem.Repository.Services;

public interface IClassRoomTeacherRepository
{
    Task InsertClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task DeleteClassRoomTeacherAsync(int classRoomId, int teacherId);
    Task<List<int>> SelectTeachersByClassRoomIdAsync(int classRoomId);
    Task<List<int>> SelectClassRoomsByTeacherIdAsync(int teacherId);
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