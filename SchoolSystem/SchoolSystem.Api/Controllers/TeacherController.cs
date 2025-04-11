using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/teacher")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService teacherService;

    public TeacherController(ITeacherService teacherService)
    {
        this.teacherService = teacherService;
    }
}
