using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoLibrary
{
    public class UserDaoException : Exception
    {

        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
