using CommunityToolkit.Mvvm.DependencyInjection;
using KanBoard.ViewModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace KanBoard
{
    public sealed partial class MainBoardPage : Page
    {
        public MainBoardViewModel ViewModel { get; }

        public MainBoardPage()
        {
            this.InitializeComponent();
            ViewModel = Ioc.Default.GetService<MainBoardViewModel>();
        }
    }
}
