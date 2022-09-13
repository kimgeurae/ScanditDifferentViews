using BarcodeCaptureViewsSample.Resources;
using Scandit.DataCapture.Core.Capture.Unified;

namespace BarcodeCaptureViewsSample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public string Version => string.Format(AppResources.VersionFormat, DataCaptureVersion.Version);
    }
}
