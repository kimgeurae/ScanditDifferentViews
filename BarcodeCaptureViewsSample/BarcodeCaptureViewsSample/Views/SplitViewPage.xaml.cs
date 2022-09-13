using System;
using BarcodeCaptureViewsSample.Resources;
using Xamarin.Forms;

namespace BarcodeCaptureViewsSample.Views
{
    public partial class SplitViewPage : ContentPage
    {
        public SplitViewPage()
        {
            this.InitializeComponent();
            this.Title = AppResources.SplitView;
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

        private void OnClearToolbarItemClicked(object sender, EventArgs args)
        {
            this.viewModel.ClearResults();
        }

        private void OnTapToContinueTapped(object sender, EventArgs args)
        {
            _ = this.viewModel.OnResumeAsync();
        }
    }
}