using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Spike.ZebraScanner.Constants;

namespace Spike.ZebraScanner
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Application, string>(Application.Current, "InitialScan", (sender, args) =>
            {
                lblXamForms.Text = $"Scanned Barcode {args}";
            });
        }
    }
}
