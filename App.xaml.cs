using carnet.Models.Business;
using carnet.services.business;
namespace carnet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var settings = SettingsService.Instance;


            Task.Run(async () =>
            {
                await DatabaseService.InitializeAsync(); 
                await NoteService.Instance.LoadNotesAsync(userId:0); 
            }).Wait();

            MainPage = new AppShell();
        }
    }
}