using SchoolSystem.Bll.DTOs;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Bll.Mappers;

public class ClassRoomMapper : AutoMapper.Profile
{
    public ClassRoomMapper()
    {
        CreateMap<ClassRoom, ClassRoomDto>();
        CreateMap<ClassRoomDto, ClassRoom>();
    }
}