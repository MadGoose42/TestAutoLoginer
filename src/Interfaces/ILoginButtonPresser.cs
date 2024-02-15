using System.Windows.Automation;

namespace AutoLoginer
{
    /// <summary>
    /// Class that presses a LogIn button
    /// </summary>
    internal interface ILoginButtonPresser
    {
        /// <summary>
        /// Method that presses a LogIn button. Window should be already open.
        /// </summary>
        void PressButtonLogin(AutomationElement AE);
    }
}