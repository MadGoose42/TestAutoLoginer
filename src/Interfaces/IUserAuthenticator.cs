namespace AutoLoginer
{
    internal interface IUserAuthenticator
    {
        void AuthenticateUser(string username, string password);
    }
}