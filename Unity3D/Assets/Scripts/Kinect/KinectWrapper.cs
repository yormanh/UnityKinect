/*
	Description: 
*/

using System;

using System.Runtime.InteropServices;


namespace Assets.Kinect.Scripts
{
	//interfaces with DLL
	public class KinectWrapper
	{

		//const string msKinectUnityDLL = "..\\..\\..\\Source\\KinectUnityPlugin\\Debug\\KinectUnityPlugin.dll";
		const string msKinectUnityDLL = @"F:\Ficheros\UnityKinect\Source\KinectUnityPlugin\Debug\KinectUnityPlugin.dll";

		//Test
		[DllImport(msKinectUnityDLL)]
		public static extern int GetANumber();
		[DllImport(msKinectUnityDLL)]
		public static extern IntPtr GetAString();

	}
}