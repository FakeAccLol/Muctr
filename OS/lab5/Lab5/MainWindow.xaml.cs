using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Runtime.InteropServices;
using System.IO;

namespace OS5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            /*string path = @"D:\WhiRav_D\Programs\C#\OS\lab5\DllLib\bin\Debug\OS5Lib.dll";
            AppDomain domain = AppDomain.CreateDomain("test");
            AssemblyName name = AssemblyName.GetAssemblyName(path);
            Assembly assembly = domain.Load(path);
            Type type = assembly.GetType("GameOverDll.Class1");
            dynamic instance = Activator.CreateInstance(type);
            string text = instance.Load();
            textBox.Text = text;
            AppDomain.Unload(domain);*/
            
            Assembly assembly = Assembly.LoadFile(@"D:\WhiRav_D\Programs\C#\OS\lab5\DllLib\bin\Debug\OS5Lib.dll");
            Type type = assembly.GetType("DllLib.Class1");
            MethodInfo instance = type.GetMethod("ReturnMessage");

            string text = (string)instance.Invoke(null, null);

            textBox.Text = text;

            AppDomain.CurrentDomain.AssemblyResolve += (s, a) => { if (a.Name == assembly.FullName) return null; else return assembly; };
        }
    }
}
