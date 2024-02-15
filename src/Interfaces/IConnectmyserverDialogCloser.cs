using System.Windows.Automation;

namespace AutoLoginer
{
    /// <summary>
    /// Closes "Logged in as [username]" window
    /// </summary>
    internal interface IConnectmyserverDialogCloser
    {
        /// <summary>
        /// Closes "Logged in as [username]" window
        /// </summary>
        /// <param name="AE">UIA instance of main window</param>
        void CloseDialogWindow(AutomationElement AE);
    }
}