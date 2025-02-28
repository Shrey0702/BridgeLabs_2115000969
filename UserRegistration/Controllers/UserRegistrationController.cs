using Microsoft.AspNetCore.Mvc;
using BussinessLayer;
using ModelLayer.DTO;

namespace UserRegistration.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    ResponseModel<String> response;
    UserRegistrationBL _userRegistrationBL;
    public UserRegistrationController(UserRegistrationBL userRegistrationBL)
    {
        _userRegistrationBL = userRegistrationBL;
    }
    [HttpGet]
    public string Registration()
    {
        return _userRegistrationBL.RegistrationBL("root", "root");
    }

    [HttpGet]
    [Route("displayUser")]
    public string DisplayUser()
    {
        return _userRegistrationBL.GetUserData();
    }

    [HttpPost]
    [Route("Login")]
    public IActionResult LoginUser(LoginDTO loginDTO)
    {
        response = new ResponseModel<String>();
        bool result = _userRegistrationBL.LoginUser(loginDTO);

        try
        {
            if (result)
            {
                response.Success = true;
                response.Message = "Login Successful";
                response.Data = loginDTO.username;
                return Ok(response);
            }

            response.Success = false;
            response.Message = "Login Failed";
            response.Data = "";
            return NotFound(response);
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
            response.Data = "";
            return BadRequest(response);
        }
    }

    [HttpPost]
    [Route("Register")]
    public IActionResult RegisterUser(RegistrationDTO registerDTO)
    {
        response = new ResponseModel<string>();
        RegistrationDTO result = _userRegistrationBL.RegisterUser(registerDTO);
        try
        {
            if (result != null)
            {
                response.Success = true;
                response.Message = "Registration Successful";
                response.Data = result.ToString();
                return Ok(response);
            }

            response.Success = false;
            response.Message = "Registration Failed";
            response.Data = "";
            return NotFound(response);
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
            response.Data = "";
            return BadRequest(response);
        }
        
    }
    
    
}