namespace SchoolSystem.Repository.Services;

public interface ITeacherStudentRepository
{
    Task InsertTeacherStudentAsync(int teacherId, int studentId);
    Task DeleteTeacherStudentAsync(int teacherId, int studentId);
    Task<List<int>> SelectStudentsByTeacherIdAsync(int teacherId);
    Task<List<int>> SelectTeachersByStudentIdAsync(int studentId);
}

/***
Task InsertTeacherStudentAsync(int teacherId, int studentId);

Vazifa: Bu funksiya berilgan teacherId (o'qituvchi) va studentId (talaba) parametrlariga asoslanib, talaba va o'qituvchi o'rtasida bog'lanishni yaratadi. O'qituvchi va talaba o'rtasida yangi aloqani qo'shadi.

Task DeleteTeacherStudentAsync(int teacherId, int studentId);

Vazifa: Bu funksiya berilgan teacherId va studentId parametrlariga asoslanib, o'qituvchi va talaba o'rtasidagi bog'lanishni o'chiradi.

Task<List<int>> SelectStudentsByTeacherIdAsync(int teacherId);

Vazifa: Bu funksiya berilgan teacherId bo'yicha, o'sha o'qituvchi bilan bog'liq barcha talabalar ro'yxatini qaytaradi. Ro'yxat faqat talabalar idlaridan iborat bo'ladi.

Task<List<int>> SelectTeachersByStudentIdAsync(int studentId);

Vazifa: Bu funksiya berilgan studentId bo'yicha, o'sha talabaning dars berayotgan barcha o'qituvchilarini qaytaradi. Ro'yxat faqat o'qituvchilar idlaridan iborat bo'ladi.