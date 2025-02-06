using UnityEditor;
using UnityEngine;

public static class ToolsMenu
{
    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateFolders()
    {
        CreateDirectories("_Project","Art","Materials","Prefabs","Scenes","Scripts");
        AssetDatabase.Refresh();
    }

    public static void CreateDirectories(string root, params string[] folders)
    {
        var fullPath = System.IO.Path.Combine(Application.dataPath, root);
        foreach (string folder in folders)
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(fullPath, folder));
        }
    }
}
