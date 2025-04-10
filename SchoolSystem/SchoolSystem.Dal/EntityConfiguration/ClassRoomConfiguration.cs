using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Dal.EntityConfiguration;

public class ClassRoomConfiguration : IEntityTypeConfiguration<ClassRoom>
{
    public void Configure(EntityTypeBuilder<ClassRoom> builder)
    {
        builder.HasKey(c => c.ClassRoomId);

        builder.Property(c => c.ClassRoomName).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Grade).HasMaxLength(20).IsRequired();

        builder.HasMany(c => c.ClassRoomStudents)
            .WithOne(cs => cs.ClassRoom)
            .HasForeignKey(cs => cs.ClassRoomId);

        builder.HasMany(c => c.ClassRoomTeachers)
            .WithOne(ct => ct.ClassRoom)
            .HasForeignKey(ct => ct.ClassRoomId);
    }
}