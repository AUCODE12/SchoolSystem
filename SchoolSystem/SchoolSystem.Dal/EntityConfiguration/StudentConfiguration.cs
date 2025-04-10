using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.StudentId);

        builder.Property(s => s.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(s => s.LastName).HasMaxLength(50).IsRequired();
        builder.Property(s => s.Email).HasMaxLength(100).IsRequired();
        builder.Property(s => s.PhoneNumber).HasMaxLength(15).IsRequired();
        builder.Property(s => s.Address).HasMaxLength(250);

        builder.HasMany(s => s.ClassRoomStudents)
            .WithOne(cs => cs.Student)
            .HasForeignKey(cs => cs.StudentId);

        builder.HasMany(s => s.TeacherStudents)
            .WithOne(ts => ts.Student)
            .HasForeignKey(ts => ts.StudentId);
    }
}
