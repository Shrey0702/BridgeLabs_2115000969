using RepositoryLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using Microsoft.Extensions.Logging;

namespace RepositoryLayer
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        //string userData = "User";
        // MIGRATION == ADD-Migration InitialMigration
        // update-database
        private readonly RegistrationAppContext _context;
        private readonly ILogger<UserRegistrationRL> _logger;

        static List<String> userData = new List<string>();//Make it statis so once the dats is sent through post it is not re insitialised and we can get the data
        public UserRegistrationRL(ILogger<UserRegistrationRL> logger,RegistrationAppContext context)
        {
            _context = context;
            _logger = logger;
        }

        public string GetHello(string name)
        {
            return name + "Hello form repository layer";

        }

        public string GetUserRL()
        {
            //return (userData.Length > 0) ? userData : "null";
            return (userData.Count != 0) ? userData.LastOrDefault() : "null";
        }

        public bool RegisterUserRL(RegistrationDTO Data)
        {
            try
            {
                _logger.LogInformation("Trying to Log user data to the DataBase in the repository layer");
                // _context.Users irepresents the table

                //Understanding FirstOrDefault in C#
                // In C#, FirstOrDefault is a LINQ method used to retrieve the
                // first element from a collection that matches a condition.
                // If no matching element is found, it returns null instead of throwing an error.



                var user = _context.Users.FirstOrDefault(u => u.Email.Equals(Data.Email));
                if (user != null)
                {
                    _logger.LogWarning("User Already exist in the database checking from repository layer");

                    return false;
                }
                UserEntity newUser = new UserEntity()
                {
                    Email = Data.Email,
                    FirstName = Data.FirstName,
                    LastName = Data.LastName,
                    Password = Data.Password,
                    Phone = Data.Phone,
                    //UserId = Data.UserId, -> this is not present in the UserEntity class
                    UserName = Data.UserName,

                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true;


                //userData.Add(Data);
                //userData = Data;
                //return true;
            }
            catch(Exception ex)
            {
                _logger.LogError("There is some prblems with the database we are unable to add user to the database:" + ex.Message);
                return false;
            }
        }
        public LoginResponse GetUserDB(LoginDTO loginDTO)
        {
            _logger.LogInformation("Fething user data is exist in database");
            LoginResponse loginResponse = new LoginResponse();

            try
            {
                var findUser = _context.Users.FirstOrDefault(u => u.Email == loginDTO.Email && u.Password == loginDTO.Password);
                if (findUser == null)
                {
                    _logger.LogWarning("Please register before trying to log in or the password is incorrect so please try again");
                    loginResponse.message = "No user exist for that partiucalar email please register first";
                    loginResponse.success = false;
                    loginResponse.email = loginDTO.Email;
                    return loginResponse;
                }
                else
                {
                    _logger.LogInformation("User succesfully logged in");
                    loginResponse.message = "Congratulations!! you are succesfully logged in";
                    loginResponse.email = loginDTO.Email;
                    loginResponse.success = true;
                    return loginResponse;
                }
            }

            catch(Exception ex)
            {
                _logger.LogError("There's some error while fetching data so login not succesfull");
                loginResponse.message = "Not able to lgin right now";
                loginResponse.success = false;
                loginResponse.email = "Not available";
                return loginResponse;
            }

        }
    }
}