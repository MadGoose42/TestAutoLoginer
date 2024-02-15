using System.Windows.Automation;

namespace AutoLoginer
{
    internal class MainWindowFinder : IMainWindowFinder
    {
        private AutomationElement _ae;
        internal MainWindowFinder()
        {
            FindMainWindow();
        }
        internal void FindMainWindow()
        {
            //searching for a window
            _ae = AutomationElement.RootElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "MainWindow"));
        }
        public AutomationElement GetMainWindow() => _ae;
    }
}


