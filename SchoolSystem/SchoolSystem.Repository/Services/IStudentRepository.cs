using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IStudentRepository
{
    Task<Student> SelectStudentByIdAsync(long id);
    Task<List<Student>> SelectAllStudentsAsync(bool includeTeacher, bool includeClass, int skip, int take);
    Task InsertStudentAsync(Student student);
    Task UpdateStudentAsync(Student student);
    Task DeleteStudentAsync(long id);
}

/***
Task<Student> SelectStudentByIdAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha talaba ma'lumotlarini asinxron ravishda qaytaradi. Maqsad, ma'lum bir talaba haqida ma'lumot olish.

Task<List<Student>> SelectAllStudentsAsync(bool includeTeacher, bool includeClass, int skip, int take);

Vazifa: Bu funksiya barcha talabalar ro'yxatini qaytaradi. includeTeacher va includeClass parametrlariga qarab, talabalar bilan bog'liq o'qituvchi va sinf ma'lumotlarini ham qo'shib yuboradi. skip va take parametrlariga qarab, sahifalash (pagination) amalga oshiriladi.

Task InsertStudentAsync(Student student);

Vazifa: Bu funksiya yangi talaba ma'lumotlarini ma'lumotlar bazasiga qo'shadi. student obyekti sifatida talaba ma'lumotlari qabul qilinadi.

Task UpdateStudentAsync(Student student);

Vazifa: Bu funksiya mavjud bo'lgan talaba ma'lumotlarini yangilaydi. student obyekti yangi yoki yangilangan talaba ma'lumotlarini o'z ichiga oladi.

Task DeleteStudentAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha talaba ma'lumotlarini o'chiradi. Talabani o'chirish uchun id parametridan foydalaniladi.