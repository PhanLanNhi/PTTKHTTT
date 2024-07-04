using Form1.Connect_DB.Model;

namespace Form1.Connect_DB.Services
{
    public class AccountService
    {
        public AccountService() { }

        public bool IsExisted(string un, string pw)
        {
            Account account = new Account(un, pw);
            return account.IsExisted();
        }
    }
}
