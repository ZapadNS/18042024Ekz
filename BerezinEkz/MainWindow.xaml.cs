using BerezinEkz.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BerezinEkz;

/// <summary>
/// Главная
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Собитие клика получение массы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GetWeightButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var isVolume = int.TryParse(Volume.Text, out var volume);
            var isDensity = int.TryParse(Density.Text, out var density);
            if (!isDensity || !isVolume)
                throw new Exception("Введите корректно данные!");

            var fuel = new Fuel(volume, density);
            Weight.Text = fuel.GetWeight().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }
    }

    /// <summary>
    /// Событие клика получение текущего объёма
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GetVolumeResult_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var isVolume = int.TryParse(SecondVolume.Text, out var volume);
            var isVolumeNow = int.TryParse(VolumeNow.Text, out var volumeNow);
            if (!isVolume || !isVolumeNow)
                throw new Exception("Введите корректно данные!");

            var storage = new Storage(volume, volumeNow);
            VolumeResult.Text = storage.GetVolumeInStorage().ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }
    }

    /// <summary>
    /// Событие клика на дозаправку
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SetFuel_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var volume = VolumeResult.Text;
            if (volume == "")
                throw new Exception("Сначала вычислите доступный объём!");

            if (volume == "0")
                throw new Exception("Вам не нужно! Поверьте просто, не стоит.");

            var storageFuel = int.Parse(volume);
            var volumeNow = int.Parse(VolumeNow.Text);

            GasStation.AddFuel(storageFuel, volumeNow);
            MessageBox.Show("Вас успешно заправили!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }
    }
}
