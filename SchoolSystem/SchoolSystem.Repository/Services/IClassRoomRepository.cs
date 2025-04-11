using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public interface IClassRoomRepository
{
    Task<ClassRoom> SelectClassRoomByIdAsync(long id);
    Task<List<ClassRoom>> SelectAllClassRoomsAsync(bool includeStudent = false, bool includeTeacher = false, int skip = 0, int take = 10);
    Task<long> InsertClassRoomAsync(ClassRoom classRoom);
    Task UpdateClassRoomAsync(ClassRoom classRoom);
    Task DeleteClassRoomAsync(long id);
}

/*
Task<ClassRoom> SelectClassRoomByIdAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha sinf (ClassRoom) ma'lumotlarini asinxron ravishda qaytaradi. Maqsad, ma'lum bir sinfni topish.

Task<List<ClassRoom>> SelectAllClassRoomsAsync(bool includeStudent, bool includeTeacher, int skip, int take);

Vazifa: Bu funksiya barcha sinflarni qaytaradi, lekin includeStudent va includeTeacher parametrlariga ko'ra, talaba va o'qituvchilar ma'lumotlarini ham qo'shib yuborishi mumkin. skip va take parametrlariga qarab sahifalash (pagination) amalga oshiriladi.

Task InsertClassRoomAsync(ClassRoom classRoom);

Vazifa: Bu funksiya yangi sinf ma'lumotlarini ma'lumotlar bazasiga qo'shadi. U classRoom obyekti sifatida sinf ma'lumotlarini qabul qiladi.

Task UpdateClassRoomAsync(ClassRoom classRoom);

Vazifa: Bu funksiya mavjud bo'lgan sinf ma'lumotlarini yangilaydi. classRoom obyekti yangi yoki yangilangan ma'lumotlarni o'z ichiga oladi.

Task DeleteClassRoomAsync(int id);

Vazifa: Bu funksiya berilgan id bo'yicha sinfni o'chiradi. Sinfni o'chirish uchun id parametridan foydalaniladi.

*/