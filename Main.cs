using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace FinanceApp
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
            LoadCartesianChart();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        /// <summary>
        /// function to load cartesian chart 
        /// </summary>
        private void LoadCartesianChart()
        {
            cartesianChart1.Series.Add
                  (new LineSeries
                  {
                      Values = new ChartValues<double> { 726, 777, 688, 744, 907, 848, 863, 639 },
                      Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)59, (byte)(int)200, (byte)(int)247)),
                      Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(100, (byte)(int)59, (byte)(int)200, (byte)(int)247)),
                      LineSmoothness = 10,
                      Title = "Value:",
                      PointGeometry = DefaultGeometries.None,
                      PointGeometrySize = 7,
                  }
                  ) ;
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            var brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)(int)32, (byte)(int)32, (byte)(int)32));
            cartesianChart1.DataTooltip.Foreground = brush;
        }
    }
}
