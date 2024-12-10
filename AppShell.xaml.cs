namespace LiveCharts2MauiMemoryLeakDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("secondpage", typeof(SecondPage));

            InitializeComponent();
        }
    }
}
