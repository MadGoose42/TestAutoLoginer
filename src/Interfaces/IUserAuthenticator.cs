namespace AutoLoginer
{
    /// <summary>
    /// Inputs user data and presses OK button
    /// </summary>
    internal interface IUserAuthenticator
    {
        /// <summary>
        /// Inputs user data and presses OK button
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        void AuthenticateUser(string username, string password);
    }
}