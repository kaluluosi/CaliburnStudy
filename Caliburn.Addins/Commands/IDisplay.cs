namespace Caliburn.Addins.Commands
{
    /// <summary>
    /// 跟UI有关的显示内容接口
    /// </summary>
    public interface IDisplay
    {
        string Icon { get; set; }
        string Name { get;  set; }
        string ToolTip { get; set; }
    }
}