using System.Windows.Automation;

namespace AutoLoginer
{
    /// <summary>
    /// Finds UIA instance of Main Window
    /// </summary>
    internal interface IMainWindowFinder
    {
        /// <summary>
        /// Finds UIA instance of Main Window
        /// </summary>
        /// <returns>UIA representation of Main Window</returns>
        AutomationElement GetMainWindow();
    }
}