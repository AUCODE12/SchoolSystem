using Microsoft.AspNetCore.Cors.Infrastructure;
using SchoolSystem.Bll.Services;
using SchoolSystem.Repository.Services;

namespace SchoolSystem.Api.Configurations;

public static class DependensInjectionConfiguration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
        services.AddScoped<IClassRoomRepository, ClassRoomRepository>();
        services.AddScoped<IClassRoomStudentRepository, ClassRoomStudentRepository>();
        services.AddScoped<IClassRoomTeacherRepository, ClassRoomTeacherRepository>();
        services.AddScoped<ITeacherStudentRepository, TeacherStudentRepository>();

        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<IClassRoomService, ClassRoomService>();
        services.AddScoped<IClassRoomStudentService, ClassRoomStudentService>();
        services.AddScoped<IClassRoomTeacherService, ClassRoomTeacherService>();
        services.AddScoped<ITeacherStudentService, TeacherStudentService>();
    }
}
