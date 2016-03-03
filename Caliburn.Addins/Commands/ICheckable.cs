namespace Caliburn.Addins.Commands
{
    /// <summary>
    /// 跟按钮和菜单关于选中功能的接口
    /// </summary>
    public interface ICheckable
    {
        bool IsCheckable { get; set; }
        bool IsChecked { get; set; }
    }
}