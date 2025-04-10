using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services;

public class ClassRoomRepository : IClassRoomRepository
{
    private readonly MainContext _context;

    public ClassRoomRepository(MainContext context)
    {
        _context = context;
    }

    public async Task<ClassRoom> GetByIdAsync(int id) => await _context.ClassRooms.FindAsync(id);

    public async Task<List<ClassRoom>> GetAllAsync() => await _context.ClassRooms.ToListAsync();

    public async Task AddAsync(ClassRoom classRoom)
    {
        await _context.ClassRooms.AddAsync(classRoom);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ClassRoom classRoom)
    {
        _context.ClassRooms.Update(classRoom);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ClassRoom classRoom)
    {
        _context.ClassRooms.Remove(classRoom);
        await _context.SaveChangesAsync();
    }
}

