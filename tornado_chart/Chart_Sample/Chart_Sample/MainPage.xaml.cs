using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chart_Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        void SecondaryAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            //Change the negative values into absolute value.
            double label = Math.Abs(Convert.ToDouble(e.LabelContent));
            e.LabelContent = label.ToString();
        }
    }
}