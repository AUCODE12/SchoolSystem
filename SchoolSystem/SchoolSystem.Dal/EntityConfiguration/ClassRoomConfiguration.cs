using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
{
    public void Configure(EntityTypeBuilder<ClassRoom> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(c => c.ClassRoomStudents)
            .WithOne(cs => cs.ClassRoom)
            .HasForeignKey(cs => cs.ClassRoomId);

        builder.HasMany(c => c.ClassRoomTeachers)
            .WithOne(ct => ct.ClassRoom)
            .HasForeignKey(ct => ct.ClassRoomId);
    }
}
