using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaInvestigation
{
    partial class User
    {

        public User()
        {
        }

        public User(int id, string name, string email, bool active)
        {
            Id = id;
            Name = name;
            Email = email;
            Active = active;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} @ {Email} {(Active ? "Active" : "Inactive")}";
        }
    }
}
