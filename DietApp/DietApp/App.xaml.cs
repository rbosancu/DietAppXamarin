using DietApp.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DietApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
            MicDejun bau = new MicDejun();

            foreach (var aliment in bau.alimente)
            {
                Console.WriteLine($"Ma numesc {aliment.arataNumeleBulangiule()} am {aliment.Calorii} calorii si ma doare in pula");
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
