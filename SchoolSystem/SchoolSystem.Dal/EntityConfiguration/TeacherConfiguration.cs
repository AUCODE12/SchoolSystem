using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.FullName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.Subject)
            .HasMaxLength(50);

        builder.HasMany(t => t.ClassRoomTeachers)
            .WithOne(ct => ct.Teacher)
            .HasForeignKey(ct => ct.TeacherId);

        builder.HasMany(t => t.TeacherStudents)
            .WithOne(ts => ts.Teacher)
            .HasForeignKey(ts => ts.TeacherId);
    }
}
