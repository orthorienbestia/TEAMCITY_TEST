using System;
using UnityEditor;

public class MyEditorScript
{
    static void PerformBuild ()
    {
        try
        {
            string[] scenes = { "Assets/Scenes/MainScene.unity" };

            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
            {
                scenes = scenes, target = BuildTarget.Android, locationPathName = @"E:\Installed Software\GIT_CHECKOUT\TEAMCITY_TEST\consolebuild.apk"
            };
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}