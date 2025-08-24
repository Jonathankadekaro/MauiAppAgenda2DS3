using MauiAppAgenda2DS3.Helpers;

namespace MauiAppAgenda2DS3
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db 
        {
            get 
            {
                if (_db == null) 
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                         Environment.SpecialFolder.LocalApplicationData),   
                           "banco_sqlite_compras.db3" );

                    _db = new SQLiteDatabaseHelper(path);
                
                }                
            
                return _db;
            }
        
        }
        public App()
        {
            InitializeComponent();
        
            // return new Window(new AppShell());

            MainPage = new NavigationPage (new Views.ListaProduto());
        }
    }
}