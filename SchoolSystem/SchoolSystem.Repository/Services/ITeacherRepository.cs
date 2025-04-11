using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface ITeacherRepository
{
    Task<Teacher> SelectTeacherByIdAsync(long id);
    Task<List<Teacher>> SelectAllTeachersAsync(bool includeStudent, bool includeClass, int skip, int take);
    Task InsertTeacherAsync(Teacher teacher);
    Task UpdateTeacherAsync(Teacher teacher);
    Task DeleteTeacherAsync(long id);
}

/***
Task<Teacher> SelectTeacherByIdAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha o'qituvchi ma'lumotlarini asinxron ravishda qaytaradi. Maqsad, ma'lum bir o'qituvchi haqida ma'lumot olish.

Task<List<Teacher>> SelectAllTeachersAsync(bool includeStudent, bool includeClass, int skip, int take);

Vazifa: Bu funksiya barcha o'qituvchilar ro'yxatini qaytaradi. includeStudent va includeClass parametrlariga ko'ra, o'qituvchilar bilan bog'liq talaba va sinf ma'lumotlarini ham qo'shib yuboradi. skip va take parametrlariga qarab, sahifalash (pagination) amalga oshiriladi.

Task InsertTeacherAsync(Teacher teacher);

Vazifa: Bu funksiya yangi o'qituvchi ma'lumotlarini ma'lumotlar bazasiga qo'shadi. teacher obyekti sifatida o'qituvchi ma'lumotlari qabul qilinadi.

Task UpdateTeacherAsync(Teacher teacher);

Vazifa: Bu funksiya mavjud bo'lgan o'qituvchi ma'lumotlarini yangilaydi. teacher obyekti yangi yoki yangilangan o'qituvchi ma'lumotlarini o'z ichiga oladi.

Task DeleteTeacherAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha o'qituvchi ma'lumotlarini o'chiradi. O'qituvchini o'chirish uchun id parametridan foydalaniladi.