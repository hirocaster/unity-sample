using UnityEngine;
using UnityEditor;

using System.Collections;

public class BuildBatch : MonoBehaviour
{
	
	// build iOS app
	private static void Buildpackages ()
	{
		Debug.Log ("///////////	build start	///////////");
		
		
		string [] scene = {
			"Assets/default-android.unity"
		};

		// set cheched
		EditorUserBuildSettings.symlinkLibraries = true;
		EditorUserBuildSettings.development = true;

		//set Build-target : Device
		PlayerSettings.iOS.sdkVersion = iOSSdkVersion.DeviceSDK;

		//BUILD for device

		// for iPhone
		
		// BuildOptions opt = BuildOptions.SymlinkLibraries | 
		// 	BuildOptions.Development | 
		//	BuildOptions.ConnectWithProfiler | 
		//	BuildOptions.AllowDebugging;
		// string dstDevice = "Device";
		// string errorMsg_Device = BuildPipeline.BuildPlayer (scene, dstDevice, BuildTarget.iOS, opt);

		// for Android
		string errorMsg_Device = BuildPipeline.BuildPlayer (scene, "android.apk", BuildTarget.Android, BuildOptions.None);
			
				
		if (string.IsNullOrEmpty (errorMsg_Device)) {
			Debug.Log ("///////////	device build succeeded ///////////");
		} else {
			Debug.Log ("///////////	device build failure	 ///////////");
			Debug.LogError (errorMsg_Device);
		}

	}
}