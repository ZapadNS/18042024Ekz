using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerezinEkz.Other;

/// <summary>
/// Заправочная станция
/// </summary>
public class GasStation
{
    /// <summary>
    /// Дозаправка
    /// </summary>
    /// <param name="storageVolume">Хранилище топлива</param>
    /// <param name="volumeNow">Текущее топливо</param>
    /// <returns></returns>
    public static int AddFuel(int storageVolume, int volumeNow)
        => storageVolume + volumeNow;
}
