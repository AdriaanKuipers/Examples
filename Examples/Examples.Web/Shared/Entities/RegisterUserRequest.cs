using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Web.Shared.Entities
{
    public class RegisterUserRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
