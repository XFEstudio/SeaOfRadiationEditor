namespace SeaOfRadiationEditor;

public static class SystemProfile
{
    private static bool isGameRunning;

    public static bool IsGameRunning
    {
        get { return isGameRunning; }
        set
        {
            isGameRunning = value;
            if (value)
            {
                try
                {
                    MainForm.Current?.Invoke(() => MainForm.Current.Text = "辐射之海：序章 3项修改器[游戏进行中]");
                }
                catch { }
            }
            else
            {
                try
                {
                    MainForm.Current?.Invoke(() => MainForm.Current.Text = "辐射之海：序章 3项修改器[未启动游戏]");
                    MainForm.RemoveAllCheck();
                }
                catch { }
            }
        }
    }
}
