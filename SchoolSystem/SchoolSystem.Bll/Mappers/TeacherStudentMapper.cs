using AutoMapper;
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;

public class TeacherStudentMapper : Profile
{
    public TeacherStudentMapper()
    {
        CreateMap<TeacherStudent, TeacherStudentDto>();
        CreateMap<TeacherStudentDto, TeacherStudent>();
    }
}