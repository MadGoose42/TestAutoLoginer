using AutoLoginer;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Automation;

internal class AutoLoginExecutor : IAutoLoginExecutor
{
    private readonly IMainWindowFinder finder;
    private readonly ILoginButtonPresser loginButtonPresser;
    private readonly IUserAuthenticator userAuthenticator;
    private readonly IConnectmyserverDialogCloser connectmyserverDialogCloser;
    private AutomationElement _mainWindow;
    internal AutoLoginExecutor(IMainWindowFinder Finder, ILoginButtonPresser LoginButtonPresser, IUserAuthenticator UserAuthenticator, IConnectmyserverDialogCloser ConnectmyserverDialogCloser)
    {
        finder = Finder;
        loginButtonPresser = LoginButtonPresser;
        userAuthenticator = UserAuthenticator;
        connectmyserverDialogCloser = ConnectmyserverDialogCloser;
    }
    public async Task ExecuteAutoLogin(string path, string username, string password)
    {
        // preparations
        Console.WriteLine("App opened");
        _mainWindow = finder.GetMainWindow();

        //processing 1st window
        loginButtonPresser.PressButtonLogin(_mainWindow);
        Console.WriteLine("First window processed");

        //processing 2nd window
        userAuthenticator.AuthenticateUser(username, password);
        Console.WriteLine("Auth finished");

        //processing 3rd window
        Console.WriteLine("Dialog window closer created");
        connectmyserverDialogCloser.CloseDialogWindow(_mainWindow);
        Console.WriteLine("Dialog window closing finished");

        //app may be closed here, not sure if need to be
        Console.WriteLine("I'm done!");
    }
}
