namespace ModelLayer.DTO;

public class RegistrationDTO
{
    public string userName{ get; set; }
    public string firstName{ get; set; }
    public string lastName{ get; set; }
    public string email{ get; set; }
    public string password{ get; set; }
    override 
    public string ToString()
    {
        return userName + " " + firstName + " " + lastName + " " + email + " " + password;
    }
}