using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace MCLaborAuthenticator
{
    public class MCLaborAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!(userName.Equals("snaps") && password.Equals("ax23%%$tyTT0")))
            {
                throw new SecurityTokenException("Unknown Username or Password");
            }
        }

    }
}
