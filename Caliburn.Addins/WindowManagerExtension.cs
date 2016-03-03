using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Addins
{
    public static class WindowManagerExtension
    {
        public static DialogResult<TViewModel> ShowDialog<TViewModel>(this WindowManager windowManager,Action<TViewModel> callBack)
        {
            TViewModel viewModel = IoC.Get<TViewModel>();
            callBack(viewModel);
            bool? result = windowManager.ShowDialog(viewModel);
            return new DialogResult<TViewModel>() { ViewModel = viewModel, Result = result };
        }

        public static TViewModel ShowWindow<TViewModel>(this WindowManager windowManager,Action<TViewModel> callBack)
        {
            TViewModel viewModel = IoC.Get<TViewModel>();
            callBack(viewModel);
            windowManager.ShowWindow(viewModel);
            return viewModel;
        }

        public static TViewModel ShowPopup<TViewModel>(this WindowManager windowManager,Action<TViewModel> callBack)
        {
            TViewModel viewModel = IoC.Get<TViewModel>();
            callBack(viewModel);
            windowManager.ShowPopup(viewModel);
            return viewModel;
        }
    }
}
