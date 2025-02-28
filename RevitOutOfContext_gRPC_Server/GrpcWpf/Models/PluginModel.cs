using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Resources;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Drawing;
using Grpc.Net.Client;
using RevitOutOfContext_gRPC_ProtosF;

namespace GrpcWpf.Models
{
    public class PluginModel(string name, BitmapSource image, /*string mainClassName, string mainMethodName, */string fullAssemblyPath)
    {
        public string Name => name;
        public BitmapSource Image => image;
        //public string MainClassName => mainClassName;
        //public string MainMethodName => mainMethodName;
        public string FullAssemblyPath => fullAssemblyPath;
    }
}