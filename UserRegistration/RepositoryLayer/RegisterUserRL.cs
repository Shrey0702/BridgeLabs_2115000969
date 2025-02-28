using ModelLayer.DTO;

namespace RepositoryLayer;

public class RegisterUserRL
{
    LinkedList<RegistrationDTO> userRegistrations = new LinkedList<RegistrationDTO>();

    public RegistrationDTO RegisterUser(RegistrationDTO registrationDTO)
    {
        userRegistrations.AddLast(registrationDTO);
        return registrationDTO;
    }

    public string GetHead()
    {
        return userRegistrations.First.ToString();
    }
    
}