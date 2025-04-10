using AutoMapper;
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;

public class TeacherMapper : Profile
{
    public TeacherMapper()
    {
        CreateMap<Teacher, TeacherDto>();
        CreateMap<TeacherDto, Teacher>();
    }
}