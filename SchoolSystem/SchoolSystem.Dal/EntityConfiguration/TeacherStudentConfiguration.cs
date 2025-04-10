using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;
public class TeacherStudentConfiguration : IEntityTypeConfiguration<TeacherStudent>
{
    public void Configure(EntityTypeBuilder<TeacherStudent> builder)
    {
        builder.HasKey(ts => new { ts.TeacherId, ts.StudentId });

        builder.HasOne(ts => ts.Teacher)
            .WithMany(t => t.TeacherStudents)
            .HasForeignKey(ts => ts.TeacherId);

        builder.HasOne(ts => ts.Student)
            .WithMany(s => s.TeacherStudents)
            .HasForeignKey(ts => ts.StudentId);
    }
}
