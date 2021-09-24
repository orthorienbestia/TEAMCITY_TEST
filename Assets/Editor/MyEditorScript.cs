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
                scenes = scenes, target = BuildTarget.Android, locationPathName = @"\apk\consolebuild_%build.counter%.apk"
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