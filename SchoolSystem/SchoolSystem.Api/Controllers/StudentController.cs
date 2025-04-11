using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Services;

namespace SchoolSystem.Api.Controllers;

[Route("api/student")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService studentService;

    public StudentController(IStudentService studentService)
    {
        this.studentService = studentService;
    }
}
