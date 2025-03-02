using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
//using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        Response<String> response;
        private readonly IUserRergistrationBL _userRegistrationBL;
        private readonly ILogger<UserRegistrationController> _logger;
        public UserRegistrationController(ILogger<UserRegistrationController> logger, IUserRergistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
            _logger = logger;
        }

        [HttpGet]
        public string GetUser()
        {
            _logger.LogInformation("GetUser Method is called");
            return _userRegistrationBL.GetUserBL();
        }

        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegistrationDTO registration) //Frombody helps in binding the data
        {
            try
            {
                _logger.LogInformation("RegisterUser Method is called on {registration.Email}");
                response = new Response<String>();
                bool registered = _userRegistrationBL.RegisterUserBL(registration);
                if (registered)
                {
                    _logger.LogInformation("User added successfully");
                    response.Success = true;
                    response.Message = "User added successfully";
                    response.data = registration.ToString();

                    return Ok(response);
                }
                _logger.LogWarning("User Already exist");   
                response.Success = false;
                response.Message = "User Already exist";
                response.data = "User is already  registered";
                return NotFound(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in RegisterUser Method", ex.Message);
                response.Success = false;
                response.Message = ex.Message;
                response.data = "OOps Try again";
                return BadRequest(response);
            }

        }
    }
}