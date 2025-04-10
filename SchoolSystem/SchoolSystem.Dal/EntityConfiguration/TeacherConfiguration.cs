using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.TeacherId);

        builder.Property(t => t.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(t => t.LastName).HasMaxLength(50).IsRequired();
        builder.Property(t => t.Email).HasMaxLength(100).IsRequired();
        builder.Property(t => t.PhoneNumber).HasMaxLength(15).IsRequired();

        builder.HasMany(t => t.ClassRoomTeachers)
            .WithOne(ct => ct.Teacher)
            .HasForeignKey(ct => ct.TeacherId);

        builder.HasMany(t => t.TeacherStudents)
            .WithOne(ts => ts.Teacher)
            .HasForeignKey(ts => ts.TeacherId);
    }
}