using GO5_SupplierPreview.Domain;
using GO5_SupplierPreview.Infrastructure;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Markup;
using System;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Controls;
using GO5_SupplierPreview.Views;
using System.Windows.Documents;
using System.Windows.Media;

namespace GO5_SupplierPreview.ViewModel
{
    public class DettagliFornitoreViewModel : INotifyPropertyChanged
    {
        private readonly IRepository<Lingue> _linguaRepository;
        private Fornitori _fornitore;
        private string _linguaSelezionata;
        private DettagliFornitoreView _dettagliFornitoreView;

        public Fornitori Fornitore
        {
            get => _fornitore;
            set
            {
                _fornitore = value;
                OnPropertyChanged(nameof(Fornitore));
            }
        }

        public ObservableCollection<string> LingueDisponibili { get; } = new ObservableCollection<string>();

        public string LinguaSelezionata
        {
            get => _linguaSelezionata;
            set
            {
                if (_linguaSelezionata != value)
                {
                    _linguaSelezionata = value;
                    OnPropertyChanged(nameof(LinguaSelezionata));
                }
            }
        }

        private BitmapImage _immagineFornitore;
        public BitmapImage ImmagineFornitore
        {
            get { return _immagineFornitore; }
            set
            {
                _immagineFornitore = value;
                OnPropertyChanged(nameof(ImmagineFornitore));
            }
        }

       

        public ObservableCollection<PropertyInfo> Properties { get; set; }
        public ICommand SaveCommand { get; }
        public ICommand PrintPdfCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public DettagliFornitoreViewModel(Fornitori fornitore, IRepository<Lingue> linguaRepository, DettagliFornitoreView dettagliFornitoreView )
        {
            Fornitore = fornitore;
            _linguaRepository = linguaRepository;

            _dettagliFornitoreView = dettagliFornitoreView;

            UpdateProperties();
            PrintPdfCommand = new RelayCommand(_ => StampaPdf());

            CaricaLingueAsync(); 
            CaricaImmaginInizialee(fornitore.FornitoreID);
        }

        private async void CaricaLingueAsync()
        {
            var lingue = await Task.Run(() => _linguaRepository.GetAll());
            App.Current.Dispatcher.Invoke(() =>
            {
                LingueDisponibili.Clear();
                foreach (var lingua in lingue)
                    LingueDisponibili.Add(lingua.Descrizione);
            });
        }

        private void UpdateProperties()
        {
            if (Properties == null)
            {
                Properties = new ObservableCollection<PropertyInfo>();
            }

            Properties.Clear();

            if (Fornitore != null)
            {
                foreach (var property in typeof(Fornitori).GetProperties())
                {
                    Properties.Add(new PropertyInfo { Key = property.Name, Value = property.GetValue(Fornitore) });
                }
            }
        }

        private void CaricaImmaginInizialee(int fornitoreId) 
        {
            switch (fornitoreId)
            {
                case 1:
                    CaricaImmagine("05355b12-c36b-4b16-a607-9327a1e2af0f.c10.jpg");
                    break;
                case 2:
                    CaricaImmagine("Rarita.Jpg");
                    break;
                case 3:
                    CaricaImmagine("05355b12-c36b-4b16-a607-9327a1e2af0f.c10.jpg");
                    break;
                default:
                    CaricaImmagine("Rarita.Jpg");
                    break;
            }
        }

        // Metodo per caricare l'immagine dal progetto
        public void CaricaImmagine(string nomeImmagine)
        {
            // percorso immagine nella cartella 'Images'
            string percorsoImmagine = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", nomeImmagine);

            // Verifica se il file esiste
            if (File.Exists(percorsoImmagine))
            {
                
                ImmagineFornitore = new BitmapImage(new Uri(percorsoImmagine));
            }
            else
            {
                MessageBox.Show("Immagine non trovata");
            }
        }

        // Metodo per l'anteprima di stampa
        private void ShowPrintPreview()
        {
            
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                
                FixedDocument fixedDocument = new FixedDocument();

                PageContent pageContent = new PageContent();
                fixedDocument.Pages.Add(pageContent);

                FixedPage fixedPage = new FixedPage
                {
                    Width = _dettagliFornitoreView.ActualWidth,
                    Height = _dettagliFornitoreView.ActualHeight
                };

                fixedPage.Children.Add(CreateVisualForPrinting());

                ((IAddChild)pageContent).AddChild(fixedPage);

                // Invia il documento alla stampante
                printDialog.PrintDocument(fixedDocument.DocumentPaginator, "Stampa Dettagli Fornitore");
            }
        }

        private UIElement CreateVisualForPrinting()
        {
            var userControl = _dettagliFornitoreView; 

            // Crea un VisualBrush per disegnare l'intero UserControl
            var visualBrush = new VisualBrush(_dettagliFornitoreView);

            var drawingGroup = new DrawingGroup();
            using (DrawingContext dc = drawingGroup.Open())
            {
                dc.DrawRectangle(visualBrush, null, new Rect(0, 0, _dettagliFornitoreView.ActualWidth, _dettagliFornitoreView.ActualHeight));
            }

            var drawingImage = new DrawingImage(drawingGroup);

            var image = new Image
            {
                Source = drawingImage,
                Width = _dettagliFornitoreView.ActualWidth,
                Height = _dettagliFornitoreView.ActualHeight
            };

            return image;
        }




        private void StampaPdf()
        {
            try
            {
                PrintPdfCommand_Executed();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"errore durante la stampa: {ex.Message}");
            }
            
        }

        private void PrintPdfCommand_Executed()
        {
            // Implementa la logica per visualizzare l'anteprima e stampare
            ShowPrintPreview();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class PropertyInfo
        {
            public string Key { get; set; }
            public object Value { get; set; }
        }
    }
}
