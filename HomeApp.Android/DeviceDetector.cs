using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(HomeApp.Droid.DeviceDetector))]
namespace HomeApp.Droid
{
     class DeviceDetector : IDeviceDetector
    {
        public string GetDevice()
        {
            // Сообщаем строку с информацией о платформе
            return $"Запущено на устройстве {Build.Product},{System.Environment.NewLine} платформа {Device.RuntimePlatform}";
        }
    }
}
