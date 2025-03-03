using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class LoginResponse
    {
        public bool success { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
