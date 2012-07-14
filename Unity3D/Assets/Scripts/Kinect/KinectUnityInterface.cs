/*
 Description: 
 
*/
using System;
using UnityEngine;
using System.Collections;

using System.Runtime.InteropServices;
using Assets.Kinect.Scripts;



public class KinectUnityInterface : MonoBehaviour 
{


	// Use this for initialization
	void Start () 
	{
		Tests();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}



	//Test
	private void Tests()
	{
		int liTest = KinectWrapper.GetANumber();
		print (liTest);

		IntPtr mpString = KinectWrapper.GetAString();
		string lsTest = Marshal.PtrToStringAnsi(mpString);
		print(lsTest);

	}


}
