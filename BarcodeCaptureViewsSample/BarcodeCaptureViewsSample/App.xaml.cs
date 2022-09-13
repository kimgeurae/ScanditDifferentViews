using BarcodeCaptureViewsSample.Services;
using BarcodeCaptureViewsSample.Views;
using Xamarin.Forms;

namespace BarcodeCaptureViewsSample
{
    public partial class App : Application
    {
        private NavigationPage navigationPage;

        public class MessageKeys
        {
            public const string OnStart = nameof(OnStart);
            public const string OnSleep = nameof(OnSleep);
            public const string OnResume = nameof(OnResume);
        }

        public App()
        {
            this.InitializeComponent();
            this.InitializeMainPage();

            DependencyService.Register<IMessageService, MessageService>();
        }

        protected override void OnStart()
        {
            MessagingCenter.Send(this, MessageKeys.OnStart);
        }

        protected override void OnSleep()
        {
            MessagingCenter.Send(this, MessageKeys.OnSleep);
        }

        protected override void OnResume()
        {
            MessagingCenter.Send(this, MessageKeys.OnResume);
        }

        private void InitializeMainPage()
        {
            var mainPage = new MainPage();
            this.navigationPage = new NavigationPage(mainPage);
            this.MainPage = this.navigationPage;
        }
    }
}
