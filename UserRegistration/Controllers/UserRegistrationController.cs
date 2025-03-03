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
        LoginResponse loginResponse;
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
        [Route("Login")]
        public IActionResult LoginUser([FromBody] LoginDTO loginDTO)
        {
            loginResponse = new LoginResponse();
            try
            {
                _logger.LogInformation("trying to check if user is in the databse");

                loginResponse = _userRegistrationBL.LoginUserBL(loginDTO);
                return Ok(loginResponse);

            }
            catch(Exception ex)
            {
                _logger.LogInformation("some error occured while fetching data from so not able to log in at the present moment");
                loginResponse.email = "not available";
                loginResponse.success = false;
                loginResponse.message = "not able to connect to the database to authorize you id and password";
                return BadRequest(loginResponse);
            }
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
                _logger.LogError("Error in RegisterUser Method: " +  ex.Message);
                response.Success = false;
                response.Message = ex.Message;
                response.data = "OOps Try again";
                return BadRequest(response);
            }

        }
    }
}