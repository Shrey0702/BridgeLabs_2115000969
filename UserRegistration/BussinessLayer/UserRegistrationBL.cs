using ModelLayer.DTO;

namespace BussinessLayer;
using RepositoryLayer;
using ModelLayer.DTO;

public class UserRegistrationBL
{
    UserRegistrationRL _userRegistrationRL;
    RegisterUserRL _registerUserRL;

    public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
    {
        _userRegistrationRL = userRegistrationRL;
        _registerUserRL = new RegisterUserRL();
    }
    
    public string RegistrationBL(string userName, string password)
    {
        (String dbUserName, String dbPassword) = _userRegistrationRL.RegistrationRl();
        return (dbUserName == userName && dbPassword == password)? "Login Succesfull": "Invalid UserName and passowrd";
    }

    public string GetUserData()
    {
        return _registerUserRL.GetHead();
    }

    public bool LoginUser(LoginDTO loginDTO)
    {
        string frontEndUserName = loginDTO.username;
        string frontEndPassword = loginDTO.password;
        // database verification
        LoginDTO dbResult =  _userRegistrationRL.GetUserNamePassword(loginDTO);
        bool checker =  CheckUserNamePassword(frontEndUserName, frontEndPassword, dbResult);
        return checker;
    }

    public RegistrationDTO RegisterUser(RegistrationDTO registrationDTO)
    {
        RegistrationDTO registerUserDb = _registerUserRL.RegisterUser(registrationDTO);
        return registerUserDb;
    }

    private bool CheckUserNamePassword(String frontEndUserName, String frontEndPassword, LoginDTO result)
    {
        
        if (frontEndUserName == result.username && frontEndPassword == result.password && result != null)
        {
            return true;
        }
        return false;
    }
}