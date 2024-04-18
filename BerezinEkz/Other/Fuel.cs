using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerezinEkz.Other;

/// <summary>
/// Топливо
/// </summary>
public class Fuel
{
    /// <summary>
    /// Объём
    /// </summary>
    private int _volume { get; set; }

    /// <summary>
    /// Плотность
    /// </summary>
    private int _density { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="volume">Объём</param>
    /// <param name="density">Плотность</param>
    public Fuel(int volume, int density)
    {
        _volume = volume;
        _density = density;
    }

    /// <summary>
    /// Получение массы
    /// </summary>
    /// <returns></returns>
    public int GetWeight()
        => _density * _volume;
}
