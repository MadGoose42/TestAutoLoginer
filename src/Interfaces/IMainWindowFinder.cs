using System.Windows.Automation;

namespace AutoLoginer
{
    internal interface IMainWindowFinder
    {
        AutomationElement GetMainWindow();
    }
}