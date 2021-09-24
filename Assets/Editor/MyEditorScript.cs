using System;
using UnityEditor;

public class MyEditorScript
{
    static void PerformBuild ()
    {
        try
        {
            string[] scenes = { "Assets/Scenes/MainScene.unity" };
            BuildPipeline.BuildPlayer(scenes,"/home/akshay/Unity Projects/Cloud Build Test/Builds/androidbuild.apk",BuildTarget.Android,BuildOptions.None);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}