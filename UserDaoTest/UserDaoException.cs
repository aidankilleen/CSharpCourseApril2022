using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoTest
{
    class UserDaoException : Exception
    {

        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
