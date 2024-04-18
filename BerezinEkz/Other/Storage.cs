using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerezinEkz.Other;

/// <summary>
/// Объём топлива
/// </summary>
public class Storage
{
    /// <summary>
    /// Топливо
    /// </summary>
    private int _volume { get; set; }

    /// <summary>
    /// Текущее топливо
    /// </summary>
    private int _volumeNow { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="volume">Топливо</param>
    /// <param name="volumeNow">Текущее топливо</param>
    public Storage(int volume, int volumeNow)
    {
        _volume = volume;
        _volumeNow = volumeNow;
    }

    /// <summary>
    /// Получение текущего объема
    /// </summary>
    /// <returns></returns>
    public int GetVolumeInStorage() 
        => _volume - _volumeNow;
}
