namespace ModelLayer.DTO;

public class LoginDTO
{
    public string username { get; set; }
    public string password { get; set; }
    override 
    public string ToString()
    {
        return username + " " + password;
    }
    
}