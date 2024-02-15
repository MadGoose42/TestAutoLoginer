using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLoginer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //userdata mock
            string username = "444";
            string password = "555";
            //path mock
            var path = Path.Combine("app", "AuthTest");
            //autologin
            Console.WriteLine("Hello world");
            var process = Process.Start(path);
            IAutoLoginExecutor worker = new AutoLoginExecutor(new MainWindowFinder(), new LoginButtonPresser(), new UserAuthenticator(), new ConnectmyserverDialogCloser());
            await worker.ExecuteAutoLogin(path, username, password);
#if DEBUG
            await Task.Delay(1000000000);
#endif
        }
    }
}
