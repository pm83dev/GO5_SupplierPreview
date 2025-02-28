using GO5_SupplierPreview.WPF.Views;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace GO5_SupplierPreview.WPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private UserControl _currentView;
        public UserControl CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        // Comandi per la navigazione
        public ICommand HomeCommand { get; }
        public ICommand FornitoriCommand { get; }
        public ICommand ClientiCommand { get; }

        public MainViewModel()
        {
            HomeCommand = new RelayCommand(_ => OpenHomeCommand());
            FornitoriCommand = new RelayCommand(_ => OpenFornitoriCommand());
            ClientiCommand = new RelayCommand(_ => OpenClientiCommand());
        }

        public void OpenHomeCommand()
        {
            var homeView = new HomeView();
            homeView.DataContext = App.ServiceProvider.GetRequiredService<HomeViewModel>();
            CurrentView = homeView;
        }

        public void OpenFornitoriCommand()
        {
            var fornitoreView = new FornitoriView();
            fornitoreView.DataContext = App.ServiceProvider.GetRequiredService<FornitoriViewModel>();
            CurrentView = fornitoreView;
        }

        public void OpenClientiCommand()
        {
            var clienteView = new ClientiView();
            clienteView.DataContext = new ClientiViewModel();
            CurrentView = clienteView;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
