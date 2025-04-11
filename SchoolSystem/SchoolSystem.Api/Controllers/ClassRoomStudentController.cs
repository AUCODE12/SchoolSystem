using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/classRoomStudent")]
[ApiController]
public class ClassRoomStudentController : ControllerBase
{
    private readonly IClassRoomStudentService classRoomStudentService;
    
    public ClassRoomStudentController(IClassRoomStudentService classRoomStudentService)
    {
        this.classRoomStudentService = classRoomStudentService;
    }
}
