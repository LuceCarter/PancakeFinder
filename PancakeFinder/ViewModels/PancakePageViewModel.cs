using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using PancakeFinder.Models;
using Xamarin.Forms;

namespace PancakeFinder.ViewModels
{
    public class PancakePageViewModel : BaseViewModel
    {
        public ICommand GetPancakesCommand { get; }
        public ObservableCollection<Pancake> Pancakes { get; }
        public PancakePageViewModel()
        {
            GetPancakesCommand = new Command(async () => await GetPancakesAsync());
            Pancakes = new ObservableCollection<Pancake>();
        }

        HttpClient httpClient;
        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        private async Task GetPancakesAsync()
        {   //using (var fileStream = assembly.GetManifestResourceStream("PancakeFinder.pancakes.json"))
            //{
            //    using (var reader = new System.IO.StreamReader(fileStream))
            //    {
            //        json = await reader.ReadToEndAsync();

            //        var pancakes = Pancake.FromJson(json);

            //        Pancakes.Clear();
            //        foreach (var pancake in pancakes)
            //            Pancakes.Add(pancake);
            //    }
            //}

            if(Xamarin.Essentials.Connectivity.NetworkAccess == Xamarin.Essentials.NetworkAccess.Internet)
            {
                try
                {
                    var json = await Client.GetStringAsync("https://thewissen.io/pancakes.json");

                    var pancakes = Pancake.FromJson(json);

                    Pancakes.Clear();
                    foreach (var pancake in pancakes)
                        Pancakes.Add(pancake);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Unable to get pancakes: {e.Message}");
                    await Application.Current.MainPage.DisplayAlert("Error!", e.Message, "OK");
                }
            }
        }
    }
}
