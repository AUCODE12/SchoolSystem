using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/teacherStudent")]
[ApiController]
public class TeacherStudentController : ControllerBase
{
    private readonly ITeacherStudentService teacherStudentService;

    public TeacherStudentController(ITeacherStudentService teacherStudentService)
    {
        this.teacherStudentService = teacherStudentService;
    }
}
