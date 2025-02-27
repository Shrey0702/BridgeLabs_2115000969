namespace BussinessLayer;
using RepositoryLayer;

public class UserRegistrationBL
{
    UserRegistrationRL _userRegistrationRL;

    public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
    {
        _userRegistrationRL = userRegistrationRL;
    }
    public string RegistrationBL(string userName, string password)
    {
        (String dbUserName, String dbPassword) = _userRegistrationRL.RegistrationRl();
        return (dbUserName == userName && dbPassword == password)? "Login Succesfull": "Invalid UserName and passowrd";
    }
}