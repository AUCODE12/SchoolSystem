using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class ClassRoomTeacherConfiguration : IEntityTypeConfiguration<ClassRoomTeacher>
{
    public void Configure(EntityTypeBuilder<ClassRoomTeacher> builder)
    {
        builder.HasKey(ct => new { ct.ClassRoomId, ct.TeacherId });

        builder.HasOne(ct => ct.ClassRoom)
            .WithMany(c => c.ClassRoomTeachers)
            .HasForeignKey(ct => ct.ClassRoomId);

        builder.HasOne(ct => ct.Teacher)
            .WithMany(t => t.ClassRoomTeachers)
            .HasForeignKey(ct => ct.TeacherId);
    }
}
