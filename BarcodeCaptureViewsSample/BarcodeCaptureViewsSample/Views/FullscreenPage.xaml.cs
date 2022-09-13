using BarcodeCaptureViewsSample.Resources;
using Xamarin.Forms;

namespace BarcodeCaptureViewsSample.Views
{
    public partial class FullscreenPage : ContentPage
    {
        public FullscreenPage()
        {
            this.InitializeComponent();
            this.Title = AppResources.Fullscreen;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ = this.viewModel.OnResumeAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.viewModel.OnSleep();
        }
    }
}
