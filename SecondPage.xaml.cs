using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.VisualBasic;

namespace LiveCharts2MauiMemoryLeakDemo;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        Random rnd = new Random();
        IEnumerable<double> numbers = Enumerable.Range(1, 10_000).Select(r => rnd.NextDouble());

        InitializeComponent();

        MyChart.Series = new ISeries[]
           {
                new LineSeries<double>
                {
                    Values = numbers.ToArray()
                }
           };

        //Unloaded += (s, e) =>
        //{
        //    // Disconnecting hanlder causes casting exception
        //    MyChart.Handler?.DisconnectHandler();
        //};
    }

    ~SecondPage()
    {
        System.Diagnostics.Debug.WriteLine("Page destroyed");
    }
}