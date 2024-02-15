using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AutoLoginer.UIADevtools
{
    public static class TextInserter
    {
        /// <summary>
        /// Inserts 
        /// </summary>
        /// <param name="textItem">UIA object with <see cref="ValuePattern"/>.</param>
        /// <param name="text">Text that you want to insert</param>
        /// <exception cref="ApplicationException"></exception>
        public static void InsertText(AutomationElement textItem, string text)
        {
            //checking for an edit pattern (it should be)
            if (textItem.TryGetCurrentPattern(ValuePattern.Pattern, out var objPattern))
            {
                // casting to "InvokePattern" to be able to use "Invoke()"
                var invPattern = objPattern as ValuePattern;
                //pressing a button
                invPattern.SetValue(text);
            }
            else
            {
                //if something wrong happens
                throw new ApplicationException($"something wrong with {typeof(LoginButtonPresser)}: button pattern error");
            }
        }
    }
}
