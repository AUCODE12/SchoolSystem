using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class StudentRepository : IStudentRepository
{
    private readonly MainContext _context;

    public StudentRepository(MainContext context)
    {
        _context = context;
    }

    public async Task<Student> GetByIdAsync(int id) => await _context.Students.FindAsync(id);

    public async Task<List<Student>> GetAllAsync() => await _context.Students.ToListAsync();

    public async Task AddAsync(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Student student)
    {
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
    }
}
