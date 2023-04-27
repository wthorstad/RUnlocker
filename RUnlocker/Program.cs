using System;
using System.IO;
using Newtonsoft.Json;

class RUnlocker
{
    static void Main(string[] args)
    {
        string robloxPath = GetRecentRobloxPath();

        string clientSettingsPath = Path.Combine(robloxPath, "ClientSettings");
        if (Directory.Exists(clientSettingsPath))
        {
            Directory.Delete(clientSettingsPath, true);
        }
        Directory.CreateDirectory(clientSettingsPath);

        int fps = -1;
        while (fps < 0)
        {
            Console.Write("Enter your desired FPS value: ");
            if (!int.TryParse(Console.ReadLine(), out fps))
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        string settingsJson = JsonConvert.SerializeObject(new { DFIntTaskSchedulerTargetFps = fps });
        File.WriteAllText(Path.Combine(clientSettingsPath, "ClientAppSettings.json"), settingsJson);

        Console.WriteLine("RUnlocker has finished creating the ClientSettings folder and setting the FPS value.");
    }

    static string GetRecentRobloxPath()
    {
        string robloxPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Roblox", "Versions");
        DirectoryInfo robloxDir = new DirectoryInfo(robloxPath);
        DirectoryInfo mostRecent = null;
        foreach (DirectoryInfo dir in robloxDir.GetDirectories())
        {
            if (mostRecent == null || dir.LastWriteTime > mostRecent.LastWriteTime)
            {
                mostRecent = dir;
            }
        }
        return mostRecent.FullName;
    }
}
