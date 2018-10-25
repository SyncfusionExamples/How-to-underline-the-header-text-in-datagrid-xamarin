using Syncfusion.SfDataGrid.XForms;
using Syncfusion.SfDataGrid.XForms.Renderers;
using Syncfusion.SfNumericTextBox.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sequenceOrderGrid.GridStyle = new CustomStyle();
        }
    }

    public class CustomStyle : DataGridStyle
    {
        public override GridLinesVisibility GetGridLinesVisibility()
        {
            return GridLinesVisibility.None;
        }
    }
}
    

    
