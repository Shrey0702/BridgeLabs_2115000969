using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRergistrationBL
    {
        string GetUserBL();

        bool RegisterUserBL(RegistrationDTO registration);
        public LoginResponse LoginUserBL(LoginDTO loginDTO);
    }
}