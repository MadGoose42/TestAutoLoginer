using System.Threading.Tasks;

internal interface IAutoLoginExecutor
{
    Task ExecuteAutoLogin(string path, string username, string password);
}