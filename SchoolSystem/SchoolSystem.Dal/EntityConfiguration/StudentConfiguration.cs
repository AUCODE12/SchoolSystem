using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.FullName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.BirthDate)
            .IsRequired();

        builder.HasMany(s => s.ClassRoomStudents)
            .WithOne(cs => cs.Student)
            .HasForeignKey(cs => cs.StudentId);

        builder.HasMany(s => s.TeacherStudents)
            .WithOne(ts => ts.Student)
            .HasForeignKey(ts => ts.StudentId);
    }
}
