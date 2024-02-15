using System.Windows.Automation;

namespace AutoLoginer.UIADevtools
{
    public interface ITextInserter
    {
        void InsertText(AutomationElement textItem, string text);
    }
}