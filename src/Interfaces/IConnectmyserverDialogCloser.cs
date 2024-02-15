using System.Windows.Automation;

namespace AutoLoginer
{
    internal interface IConnectmyserverDialogCloser
    {
        void CloseDialogWindow(AutomationElement AE);
    }
}