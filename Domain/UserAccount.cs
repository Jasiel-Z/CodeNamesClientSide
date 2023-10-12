using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain



{
    internal class UserAccount
    {
        private int idUserAccount;
        private string nickname;
        private string password;
        private string email;
        private bool isGuest;

        #region Singletone

        private static UserAccount userClient;

        public static UserAccount UserClient { get { return userClient; } set { userClient = value; } }

        #endregion

        public int IdUserAccount { get { return idUserAccount; } set { idUserAccount = value; } }
        public string Nickname { get { return nickname; } set { nickname = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool IsGuest { get { return isGuest; } set { isGuest = value; } }
    }
}
