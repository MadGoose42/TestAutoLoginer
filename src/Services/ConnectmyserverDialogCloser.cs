using AutoLoginer.UIADevtools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AutoLoginer
{
    internal class ConnectmyserverDialogCloser : IConnectmyserverDialogCloser
    {
        private AutomationElement _okButton;
        public void CloseDialogWindow(AutomationElement AE)
        {
            try
            {
                //searching for a button
                _okButton = AE.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "OK"));
                //pressing a button
                ButtonPresser.PressButton(_okButton);
            }
            catch (Exception)
            {
                //if something wrong happens
                Console.WriteLine($"something wrong happened in {typeof(ConnectmyserverDialogCloser)}");
            }
        }
    }
}
