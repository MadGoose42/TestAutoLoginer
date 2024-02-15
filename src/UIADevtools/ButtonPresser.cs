using AutoLoginer;
using System;
using System.Windows.Automation;

namespace AutoLoginer.UIADevtools
{
    public class ButtonPresser : IButtonPresser
    {
        public void PressButton(AutomationElement button)
        {
            //checking for an invoke pattern (it should be)
            if (button.TryGetCurrentPattern(InvokePattern.Pattern, out var objPattern))
            {
                // casting to "InvokePattern" to be able to use "Invoke()"
                var invPattern = objPattern as InvokePattern;
                //pressing a button
                invPattern.Invoke();
            }
            else
            {
                //if something wrong happens
                throw new ApplicationException($"something wrong with {typeof(LoginButtonPresser)}: button pattern error");
            }
        }
    }
}




