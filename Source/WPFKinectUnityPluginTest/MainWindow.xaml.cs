using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Assets.Kinect.Scripts;


namespace WPFKinectUnityPluginTest
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, RoutedEventArgs e)
		{
			lbResults.Items.Add("Test with WPF");

			int liTest = KinectWrapper.GetANumber();
			lbResults.Items.Add(liTest);

			IntPtr mpString = KinectWrapper.GetAString();
			string lsTest = Marshal.PtrToStringAnsi(mpString);
			lbResults.Items.Add(lsTest);

		}
	}
}
