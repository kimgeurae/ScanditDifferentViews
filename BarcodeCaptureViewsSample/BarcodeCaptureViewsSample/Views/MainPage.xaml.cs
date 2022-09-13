using System;
using BarcodeCaptureViewsSample.Resources;
using Xamarin.Forms;

namespace BarcodeCaptureViewsSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Title = AppResources.Title;
        }

        private void OnFullscreenLabelTapped(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new FullscreenPage());
        }

        private void OnSplitViewLabelTapped(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new SplitViewPage());
        }
    }
}
