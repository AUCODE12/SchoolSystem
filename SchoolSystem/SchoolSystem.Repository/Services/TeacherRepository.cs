using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class TeacherRepository : ITeacherRepository
{
    private readonly MainContext _context;

    public TeacherRepository(MainContext context)
    {
        _context = context;
    }

    public async Task<Teacher> GetByIdAsync(int id) => await _context.Teachers.FindAsync(id);

    public async Task<List<Teacher>> GetAllAsync() => await _context.Teachers.ToListAsync();

    public async Task AddAsync(Teacher teacher)
    {
        await _context.Teachers.AddAsync(teacher);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Teacher teacher)
    {
        _context.Teachers.Update(teacher);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Teacher teacher)
    {
        _context.Teachers.Remove(teacher);
        await _context.SaveChangesAsync();
    }
}
