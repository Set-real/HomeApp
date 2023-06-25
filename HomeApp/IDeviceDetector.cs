using System;
using System.Collections.Generic;
using System.Text;

namespace HomeApp
{
    /// <summary>
    /// Общий интерфейс для классов отдельных платформ
    /// </summary>
    public interface IDeviceDetector
    {
        /// <summary>
        /// Полученин информации об устройтве
        /// </summary>
        /// <returns></returns>
        string GetDevice();
    }
}
