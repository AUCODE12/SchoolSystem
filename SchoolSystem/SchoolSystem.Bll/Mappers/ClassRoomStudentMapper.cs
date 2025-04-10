using AutoMapper;
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;

public class ClassRoomStudentMapper : Profile
{
    public ClassRoomStudentMapper()
    {
        CreateMap<ClassRoomStudent, ClassRoomStudentDto>();
        CreateMap<ClassRoomStudentDto, ClassRoomStudent>();
    }
}