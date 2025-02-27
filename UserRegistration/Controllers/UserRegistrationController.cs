using Microsoft.AspNetCore.Mvc;
using BussinessLayer;

namespace UserRegistration.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    UserRegistrationBL _userRegistrationBL;
    public UserRegistrationController(UserRegistrationBL userRegistrationBL)
    {
        _userRegistrationBL = userRegistrationBL;
    }
    [HttpGet]
    public string Registration()
    {
        return _userRegistrationBL.RegistrationBL("rot", "root");
    }
    
    
}