using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/classRoomTeacher")]
[ApiController]
public class ClassRoomTeacherController : ControllerBase
{
    private readonly IClassRoomTeacherService classRoomTeacherService;

    public ClassRoomTeacherController(IClassRoomTeacherService classRoomTeacherService)
    {
        this.classRoomTeacherService = classRoomTeacherService;
    }
}
