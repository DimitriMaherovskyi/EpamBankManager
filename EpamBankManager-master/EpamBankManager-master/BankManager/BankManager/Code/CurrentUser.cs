using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BankManager.Code
{
    public class CurrentUser
    {
        private static User currentUser;

        public static void Initialize(User user)
        {
            if(currentUser != null)
            {
                throw new InvalidOperationException("Current user has already been specified");
            }
            currentUser = user;
        }

        public static int Id
        {
            get
            {
                return currentUser.Id;
            }
        }

        public static string FirstName
        {
            get
            {
                return currentUser.FirstName;
            }
        }

        public static string LastName
        {
            get
            {
                return currentUser.LastName;
            }
        }

        public static string Login
        {
            get
            {
                return currentUser.Login;
            }
        }
    }
}
