using LogicLayer.Logic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : Controller
{
    private readonly IJobPostLogic _jobPostLogic;


    public PostController(IJobPostLogic jobPostLogic)
    {
        _jobPostLogic = jobPostLogic;
    }
}