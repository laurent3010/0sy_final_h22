﻿using System.Windows;

namespace ExcelToExcel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow win = new MainWindow();

            win.Show();
        }
    }
}
