
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyLogic _companyLogic;


    public CompanyController(ICompanyLogic companyLogic)
    {
        _companyLogic = companyLogic;
    }

  
}