using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle.dto
{
    class LogInDTO : ILogIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public interface ILogIn
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
