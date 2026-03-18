using UnityEngine;
using System.IO;
using UnityEditor; // For Building Asset Bundles


public class AssetBundle_Builder_Editor
{
    static readonly string FileExt = ".mobj";

    [MenuItem("Madness/AssetBundle/ >> Build (Compressed) *RECOMMENDED*")]
    static void Build_Compressed()
    {
        BuildAllAssetBundles(BuildAssetBundleOptions.ChunkBasedCompression);
    }
    [MenuItem("Madness/AssetBundle/ >> Build (Uncompressed)")]
    static void Build_Uncompressed()
    {
        BuildAllAssetBundles(BuildAssetBundleOptions.UncompressedAssetBundle);
    }


    static void BuildAllAssetBundles(BuildAssetBundleOptions inBuildOption)
    {
        try
        {
            DirectoryInfo thisDir = Directory.CreateDirectory(Application.persistentDataPath + "/MadObjs/");

            AssetBundleManifest abm = 
            BuildPipeline.BuildAssetBundles(thisDir.FullName,
                                            BuildAssetBundleOptions.None,
                                            BuildTarget.StandaloneWindows64);

            bool openFolder = true;
            string[] allBundles = abm.GetAllAssetBundles();            
            foreach (string s in allBundles)
            {
                try
                {
                    if (s.Length > 4 && s.Substring(s.Length - 4) != FileExt)
                    {
                        File.Delete(thisDir.FullName + s + FileExt);
                        File.Delete(thisDir.FullName + s + ".manifest");
                        File.Move(thisDir.FullName + s, thisDir.FullName + s + FileExt);

                        WriteManifest(thisDir.FullName, s + FileExt, out string outLog);

                        Debug.Log("CREATED: " + s + FileExt + "\n" + outLog);
                    }
                    else
                        Debug.Log("DEV: FILETYPE EXISTS?");
                 
                    if (openFolder)
                        EditorUtility.RevealInFinder(thisDir.FullName + s + FileExt);
                    openFolder = false;
                }
                catch (System.Exception ex)
                {
                    Debug.Log("CREATED: " + s + " <color=red>(Couldn't set .MOBJ File Extension)</color>\n" + ex);
                }
            }

            File.Delete(thisDir.FullName + thisDir.Name);
            File.Delete(thisDir.FullName + thisDir.Name + ".manifest");


            if (allBundles.Length == 0)
                Debug.LogWarning("No Asset Bundles Exported!");
            else
                Debug.LogWarning("Asset Bundle" + (allBundles.Length > 1 ? "s" : "") + " Exported Successfully to <color=#DDFFDD>" + thisDir.FullName + "</color>");

        } catch (System.Exception ex)
        {
            Debug.LogError("<color=red>ERROR!</color> Asset Bundle Build FAILED (click for more)\n" + ex);
        }
    }

    static void WriteManifest(string inPath, string inFilename, out string outLog)
    {
        outLog = "";

        try
        {
            // RE-ENABLE THIS IF USING --> // DirectoryInfo manifestDir = Directory.CreateDirectory(inPath + "/Manifests/");

            // This points to the "AppData/LocalLow/GibbingTree/Madness Project Nexus Mod Kit/MadObjs/" folder for the ModTools project.
            // Use manifestDir.FullName to get the path.


            // DARKSIGNAL: Write whatever you like here!
            //
            // inFilename <-- The the .mobj filename, including the extension.
            //
            // outLog <-- This is for the debug on line 36, so you can check whatever you want
            //
            // Use manifestDir to locate the asset bundle and read it for parts and export a log.

        }
        catch (System.Exception ex)
        {
            outLog = "ERROR: " + ex;
        }
    }
}

