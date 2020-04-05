using System;
using System.Collections.Generic;
using PancakeFinder.ViewModels;
using Xamarin.Forms;

namespace PancakeFinder.Views
{
    public partial class PancakePage : ContentPage
    {
        public PancakePage()
        {
            InitializeComponent();
            BindingContext = new PancakePageViewModel();
            
        }
    }
}
