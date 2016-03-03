using System.Windows.Input;

namespace Caliburn.Addins.Commands
{
    /// <summary>
    /// 热键接口
    /// </summary>
    public interface IHotKey
    {
        KeyGesture HotKey { get; set; }
        string HotKeyText { get; }
    }
}