using GO5_SupplierPreview.Domain;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using GO5_SupplierPreview.Infrastructure;
using System.Windows;
using System.Windows.Input;
using GO5_SupplierPreview.Views;
using Microsoft.Extensions.DependencyInjection;
using GO5_SupplierPreview.ViewModel;

namespace GO5_SupplierPreview.WPF.ViewModels
{
    public class FornitoriViewModel : INotifyPropertyChanged
    {
        private readonly MainViewModel _mainViewModel;
        private ObservableCollection<Fornitori> _data;
        private readonly IRepository<Fornitori> _repo;
        private string _errorMessage;
        private Fornitori _fornitoreSelezionato;
        

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand OpenDetailsCommand { get; set;}

        // ObservableCollection fornitori
        public ObservableCollection<Fornitori> Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }

        // messaggio di errore
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public Fornitori FornitoreSelezionato
        {
            get => _fornitoreSelezionato;
            set
            {
                _fornitoreSelezionato = value;
                OnPropertyChanged(nameof(FornitoreSelezionato));
            }
        }



        // Costruttore con Dependency Injection per il servizio di dati
        public FornitoriViewModel(IRepository<Fornitori> repo, MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _repo = repo;
            LoadData();
            OpenDetailsCommand = new RelayCommand(OpenDetails);
        }

        // Metodo per caricare i dati
        public async void LoadData()
        {
            try
            {
                var fornitori = await _repo.GetAll();
                if (fornitori != null)
                {
                    Data = new ObservableCollection<Fornitori>(fornitori);
                }
                else
                {
                    ErrorMessage = "Nessun fornitore trovato";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento dei dati: {ex.Message}");
            }
        }

        private void OpenDetails(object parameter)
        {
            if (parameter is Fornitori fornitoreSelezionato)
            {
                FornitoreSelezionato = fornitoreSelezionato;

                var dettagliView = new DettagliFornitoreView();
                var linguaRepository = App.ServiceProvider.GetRequiredService<IRepository<Lingue>>();

                dettagliView.DataContext = new DettagliFornitoreViewModel(fornitoreSelezionato, linguaRepository, dettagliView);
                _mainViewModel.CurrentView = dettagliView;
            }
        }



        // Metodo per notificare il cambiamento delle proprietà
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
