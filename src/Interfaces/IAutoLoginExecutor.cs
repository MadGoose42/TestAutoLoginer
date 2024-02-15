using System.Threading.Tasks;

/// <summary>
/// Executes automatic process of logging in
/// </summary>
internal interface IAutoLoginExecutor
{
    /// <summary>
    /// Executes automatic process of logging in
    /// </summary>
    /// <param name="path">Represents a path to AuthTest.exe</param>
    /// <param name="username">Username</param>
    /// <param name="password">Password</param>
    /// <returns></returns>
    Task ExecuteAutoLogin(string path, string username, string password);
}