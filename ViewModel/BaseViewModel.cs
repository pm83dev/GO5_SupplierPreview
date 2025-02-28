using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GO5_SupplierPreview.WPF.ViewModels
{
    // Classe BaseViewModel astratta
    public abstract class BaseViewModel<T> : INotifyPropertyChanged where T : class
    {
        private ObservableCollection<T> _items;
        private string _errorMessage;

        // Proprietà che rappresenta la collezione di oggetti
        public ObservableCollection<T> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        // Proprietà per gestire il messaggio di errore
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }
        }

        // Costruttore che potrebbe contenere logica di inizializzazione comune
        public BaseViewModel()
        {
            _items = new ObservableCollection<T>();
            LoadDataAsync();
        }

        // Metodo asincrono per caricare i dati
        private async void LoadDataAsync()
        {
            try
            {
                await LoadData();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Errore nel caricamento dei dati: {ex.Message}";
            }
        }

        // Metodo astratto che deve essere implementato dalle classi derivate
        // Qui possiamo fare in modo che LoadData ritorni un Task per operazioni asincrone
        public abstract Task LoadData(Expression<Func<T, bool>> filter = null);

        // Evento per notificare il cambiamento delle proprietà
        public event PropertyChangedEventHandler PropertyChanged;

        // Metodo per invocare l'evento PropertyChanged
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
