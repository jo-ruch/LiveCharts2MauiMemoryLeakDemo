namespace LiveCharts2MauiMemoryLeakDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
