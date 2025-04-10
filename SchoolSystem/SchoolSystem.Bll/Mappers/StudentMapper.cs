using AutoMapper;
using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;

public class StudentMapper : Profile
{
    public StudentMapper()
    {
        CreateMap<Student, StudentDto>();
        CreateMap<StudentDto, Student>();
    }
}