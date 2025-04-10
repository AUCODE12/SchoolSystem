using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class ClassRoomStudentConfiguration : IEntityTypeConfiguration<ClassRoomStudent>
{
    public void Configure(EntityTypeBuilder<ClassRoomStudent> builder)
    {
        builder.HasKey(cs => new { cs.ClassRoomId, cs.StudentId });

        builder.HasOne(cs => cs.ClassRoom)
            .WithMany(c => c.ClassRoomStudents)
            .HasForeignKey(cs => cs.ClassRoomId);

        builder.HasOne(cs => cs.Student)
            .WithMany(s => s.ClassRoomStudents)
            .HasForeignKey(cs => cs.StudentId);
    }
}
