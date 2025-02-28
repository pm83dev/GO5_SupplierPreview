using GO5_SupplierPreview.WPF.ViewModels;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace GO5_SupplierPreview
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }
    }
}
