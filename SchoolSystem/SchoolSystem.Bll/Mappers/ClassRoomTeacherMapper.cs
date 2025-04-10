using AutoMapper;
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;
public class ClassRoomTeacherMapper : Profile
{
    public ClassRoomTeacherMapper()
    {
        CreateMap<ClassRoomTeacher, ClassRoomTeacherDto>();
        CreateMap<ClassRoomTeacherDto, ClassRoomTeacher>();
    }
}
