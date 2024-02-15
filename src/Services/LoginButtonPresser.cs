using AutoLoginer.UIADevtools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AutoLoginer
{
    internal class LoginButtonPresser : ILoginButtonPresser
    {
        private AutomationElement _buttonLogIn;
        public void PressButtonLogin(AutomationElement AE)
        {
            try
            {
                //searching for a button
                _buttonLogIn = AE.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Log In"));
                //checking for an invoke pattern (it should be)
                ButtonPresser.PressButton(_buttonLogIn);
            }
            catch (Exception)
            {
                //if something wrong happens
                Console.WriteLine($"something wrong happened in {typeof(LoginButtonPresser)}");
            }
        }

    }
}


