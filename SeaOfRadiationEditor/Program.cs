using XFEExtension.NetCore.MemoryEditor.Manager;

namespace SeaOfRadiationEditor;

internal static class Program
{
    public static DynamicMemoryManager Manager { get; } = MemoryManager.CreateBuilder()
        .WithAutoReacquireProcess("Sea_of_Radiation_Prologue")
        .WithFindProcessWhenCreate()
        .BuildDynamicManager(
        MemoryItemBuilder.Create<int>("Reset")
                         .WithResolvePointer("mono-2.0-bdwgc.dll", 0x0072A200, 0x14A0, 0x0, 0x80, 0xE4, 0x0, 0x1EC)
                         .WithListener(),
        MemoryItemBuilder.Create<float>("TimeCounter")
                         .WithResolvePointer("mono-2.0-bdwgc.dll", 0x0072A200, 0x12E8, 0x0, 0x80, 0xE4, 0x0, 0x1E0)
                         .WithListener(),
        MemoryItemBuilder.Create<float>("Stamina")
                         .WithResolvePointer("mono-2.0-bdwgc.dll", 0x0072A200, 0x14E0, 0x48, 0x10, 0x20, 0x50, 0x20, 0x1B0)
                         .WithListener());
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var mainForm = new MainForm();
        Manager.CurrentProcessEntered += Manager_CurrentProcessEntered;
        Manager.CurrentProcessExit += Manager_CurrentProcessExit;
        if (Manager.CurrentProcess is not null && !Manager.CurrentProcess.HasExited)
            SystemProfile.IsGameRunning = true;
        else
            SystemProfile.IsGameRunning = false;
        Application.Run(mainForm);
    }
    private static void Manager_CurrentProcessExit(object? sender, EventArgs e) => SystemProfile.IsGameRunning = false;
    private static void Manager_CurrentProcessEntered(object? sender, EventArgs e) => SystemProfile.IsGameRunning = true;
}