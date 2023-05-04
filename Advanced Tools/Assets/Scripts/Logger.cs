using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Logger : MonoBehaviour
{
    float fps;
	string text;

	StreamWriter writer;

	private void Start()
	{
		if (!Directory.Exists("C:/AdvancedToolsLogs"))
		{
			Directory.CreateDirectory("C:/AdvancedToolsLogs");
		}

		writer = new StreamWriter("C:/AdvancedToolsLogs/FirstName_LastName_ddmmyyyy_Log_V1.txt", true);
	}

	private void FixedUpdate()
    {
        FileLogger();
    }

    private void FileLogger()
    {
		//Frames per second for either build or editor
		//#if UNITY_EDITOR

			///The top one is the "New" version of the bottom line
			fps = Time.captureFramerate;
			//fps = 1.0f / Time.captureDeltaTime;
		//#else
		//fps = Time.delta
		//#endif

		//float avgFrameRate = Time.frameCount / Time.time;
		//float FrameRate = Time.frameCount / Time.deltaTime;

		//var x = UnityEditor.UnityStats.frameTime;

		text = "FPS: " + fps + "\n" + 
				//"FrameTime: " + x + "\n" +
				//"avgFrameRate: " + avgFrameRate + "\n" +
				"-";

		writer.WriteLine(text);
	}
}