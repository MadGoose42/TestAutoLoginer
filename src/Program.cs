using AutoLoginer.UIADevtools;
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
            //Creating instances,
            //DI Transient mock for ButtonPresser and TextInserter
            IAutoLoginExecutor worker = new AutoLoginExecutor(
                new MainWindowFinder(),
                new LoginButtonPresser(
                    new ButtonPresser()), 
                new UserAuthenticator(
                    new TextInserter(), 
                    new ButtonPresser()), 
                new ConnectmyserverDialogCloser(
                    new ButtonPresser()));
            await worker.ExecuteAutoLogin(path, username, password);
#if DEBUG
            await Task.Delay(1000000000);
#endif
        }
    }
}
