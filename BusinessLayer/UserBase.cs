using System;
namespace BusinessLayer
{
	public abstract class UserBase
	{
		public int ID { get; set;}
        public string Login { get; set; }
        public string Password { get; private set; }

        public UserBase(int id, string login, string password)
        {
            this.ID = id;
            this.Login = login;
            this.Password = password;

        }
    }

}

