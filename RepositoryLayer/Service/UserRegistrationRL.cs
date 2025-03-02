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
    }
}