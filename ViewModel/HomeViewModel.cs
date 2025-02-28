using System.ComponentModel;
using System.Windows.Input;

namespace GO5_SupplierPreview.WPF.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private readonly MainViewModel _mainViewModel;

        public ICommand OpenFornitoriCommand { get; set; }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            OpenFornitoriCommand = new RelayCommand(OpenFornitori);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OpenFornitori(object obj)
        {
            _mainViewModel.OpenFornitoriCommand();
        }
    }
}
