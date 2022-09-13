using System;
using System.Threading.Tasks;

namespace BarcodeCaptureViewsSample.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message, Action handler = null);
    }
}
