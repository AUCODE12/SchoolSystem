using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class ClassRoomTeacherConfiguration : IEntityTypeConfiguration<ClassRoomTeacher>
{
    public void Configure(EntityTypeBuilder<ClassRoomTeacher> builder)
    {
        builder.HasKey(ct => new { ct.ClassRoomId, ct.TeacherId });

        builder
            .HasOne(ct => ct.ClassRoom)
            .WithMany(c => c.ClassRoomTeachers)
            .HasForeignKey(ct => ct.ClassRoomId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(ct => ct.Teacher)
            .WithMany(t => t.ClassRoomTeachers)
            .HasForeignKey(ct => ct.TeacherId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(ct => ct.AssignmentDate)
            .HasDefaultValueSql("GETDATE()");
    }
}