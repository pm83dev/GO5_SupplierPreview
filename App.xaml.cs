using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using GO5_SupplierPreview.WPF.ViewModels;
using GO5_SupplierPreview.Infrastructure;
using GO5_SupplierPreview.Domain;
using System;

namespace GO5_SupplierPreview
{
    public partial class App : Application
    {
        private GadisOfficeBaseVuota1705_ProdEntities _dbContext;
        public static IServiceProvider ServiceProvider { get; private set; }

        public App()
        {
            // Creazione del contesto del database
            _dbContext = new GadisOfficeBaseVuota1705_ProdEntities();

            // Configurazione del container DI
            var serviceCollection = new ServiceCollection();

            // Registrazione delle dipendenze
            serviceCollection.AddSingleton<IRepository<Lingue>>(provider => new LingueRepo(_dbContext));
            serviceCollection.AddSingleton<IRepository<Fornitori>>(provider => new FornitoreRepo(_dbContext));

            // Registrazione dei view model
            serviceCollection.AddSingleton<MainViewModel>();
            serviceCollection.AddSingleton<HomeViewModel>();
            serviceCollection.AddSingleton<FornitoriViewModel>();

            // Registrazione delle views
            serviceCollection.AddSingleton<MainWindow>();

            // Costruzione del ServiceProvider
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        // Metodo di avvio dell'applicazione
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Creazione della finestra principale
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();

            // Assegna il DataContext della finestra principale
            mainWindow.DataContext = ServiceProvider.GetRequiredService<MainViewModel>();

            // Visualizza la finestra principale
            mainWindow.Show();

            // Richiama OpenHomeCommand dopo che la finestra è stata creata
            var mainViewModel = ServiceProvider.GetRequiredService<MainViewModel>();
            mainViewModel.OpenFornitoriCommand();
        }
    }
}
