using Grpc.Health.V1;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using RevitOutOfContext_gRPC_ProtosF;
using System.Net.Http;
using System.Windows;
using AduSkin.Controls.Metro;
using static Grpc.Health.V1.HealthCheckResponse.Types;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using GrpcWpf.VM;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace GrpcWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();        
        }        
    }
    //[ValueConversion(typeof(String), typeof(ImageSource))]
    //public class StringToImageSourceConverter : IValueConverter
    //{
    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (!(value is string valueString))
    //        {
    //            return null;
    //        }
    //        try
    //        {
    //            ImageSource image = BitmapFrame.Create(new Uri(valueString), BitmapCreateOptions.IgnoreImageCache, BitmapCacheOption.OnLoad);
    //            return image;
    //        }
    //        catch { return null; }
    //    }
    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}