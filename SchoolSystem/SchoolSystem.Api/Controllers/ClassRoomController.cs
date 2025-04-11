using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/ClassRoom")]
[ApiController]
public class ClassRoomController : ControllerBase
{
    private readonly IClassRoomService classRoomService;

    public ClassRoomController(IClassRoomService? classRoomService)
    {
        this.classRoomService = classRoomService;
    }
}
