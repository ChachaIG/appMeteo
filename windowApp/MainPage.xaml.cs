using callApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace windowApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CallWebApiAsync();
        }

        async Task CallWebApiAsync()
        {
            
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://forecastlabo2.azurewebsites.net/api/Forecast");
                if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                    string json = await response.Content.ReadAsStringAsync();
                     var forecasts = Newtonsoft.Json.JsonConvert.DeserializeObject<Forecasts[]>(json);
                    ForeCastListView.ItemsSource = forecasts;
                 }else
                 {
                     var dialog = new ContentDialog()
                     {
                         Title = "Ooooops",
                         MaxWidth = this.ActualWidth
                    };

                var panel = new StackPanel();
                panel.Children.Add(new TextBlock {
                    Text = "Une erreur s'est produite lors de la récupération des prévisions météo",
                    TextWrapping = TextWrapping.Wrap,
                });

                dialog.Content = panel;
                await dialog.ShowAsync();
                //try catch et appeler une méthode qui gère l'erreur
                //recherche google mot clé UWP / WPF  Universal App/ faire les recherches en anglais
            }  
        }
    }
}
