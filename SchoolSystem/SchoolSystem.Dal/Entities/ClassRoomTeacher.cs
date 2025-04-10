﻿namespace SchoolSystem.Dal.Entities;

public class ClassRoomTeacher
{
    public long ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; }

    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    public DateTime AssignmentDate { get; set; } = DateTime.Now;
}