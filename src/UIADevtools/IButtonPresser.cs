using System.Windows.Automation;

namespace AutoLoginer.UIADevtools
{
    public interface IButtonPresser
    {
        void PressButton(AutomationElement button);
    }
}