namespace RepositoryLayer;
using ModelLayer.DTO;

public class UserRegistrationRL
{
    public string dbuserName = "root";
    public string dbpassword = "root";

    public (string UserName, string Password) GetUserRegistration()
    {
        this.dbuserName = "root";
        this.dbpassword = "root";
        return (dbuserName, dbpassword);
    }

    public (String userName, String password) RegistrationRl()
    {
        return GetUserRegistration();
    }

    public LoginDTO GetUserNamePassword(LoginDTO loginDTO)
    {
        loginDTO.username = dbuserName;
        loginDTO.password = dbpassword;
        return loginDTO;
    }
    
}