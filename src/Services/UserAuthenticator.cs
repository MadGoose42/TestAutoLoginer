﻿using AutoLoginer.UIADevtools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AutoLoginer
{
    internal class UserAuthenticator : IUserAuthenticator
    {
        private readonly ITextInserter textInserter;
        private readonly IButtonPresser buttonPresser;
        private AutomationElement _ae;
        private AutomationElement _usernameBox;
        private AutomationElement _passwordBox;
        private AutomationElement _okButton;
        internal UserAuthenticator(ITextInserter TextInserter, IButtonPresser ButtonPresser)
        {
            textInserter = TextInserter;
            buttonPresser = ButtonPresser;
        }
        public void AuthenticateUser(string username, string password)
        {
            try
            {
                //searching for a window
                _ae = AutomationElement.RootElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Connect to myserver"));
                //searching for a username element
                var comboBox = _ae.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "pane"));
                _usernameBox = comboBox.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "edit"));
                //_UsernameBox = _ae.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "User name:"));
                //searching for a password element
                var passwordBoxes = comboBox.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Password:"));
                foreach (AutomationElement passwordBox in passwordBoxes)
                {
                    if (passwordBox.Current.LocalizedControlType == "edit")
                    {
                        _passwordBox = passwordBox;
                        break;
                    }
                }
                if (_usernameBox == null)
                {
                    throw new ArgumentNullException("passwordBox is null");
                }
                //searching for a button
                _okButton = _ae.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "OK"));
                textInserter.InsertText(_usernameBox, username);
                textInserter.InsertText(_passwordBox, password);
                //pressing OK button
                buttonPresser.PressButton(_okButton);
            }
            catch (Exception)
            {
                //if something wrong happens
                Console.WriteLine($"something wrong happened in {typeof(UserAuthenticator)}");
            }
        }
    }
}
