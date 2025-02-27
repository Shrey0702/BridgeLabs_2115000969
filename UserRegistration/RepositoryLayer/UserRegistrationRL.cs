namespace RepositoryLayer;

public class UserRegistrationRL
{
    private string userName;
    private string password;

    private (string UserName, string Password) GetUserRegistration()
    {
        this.userName = "root";
        this.password = "root";
        return (userName, password);
    }

    public (String userName, String password) RegistrationRl()
    {
        return GetUserRegistration();
    }
}