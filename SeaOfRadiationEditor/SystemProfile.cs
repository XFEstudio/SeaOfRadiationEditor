using XFEExtension.NetCore.ProfileExtension;

namespace SeaOfRadiationEditor;

public static partial class SystemProfile
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
                catch
                {
                    MainForm.Current!.Text = "辐射之海：序章 3项修改器[游戏进行中]";
                }
            }
            else
            {
                try
                {
                    MainForm.Current?.Invoke(() => MainForm.Current.Text = "辐射之海：序章 3项修改器[未启动游戏]");
                }
                catch
                {
                    MainForm.Current!.Text = "辐射之海：序章 3项修改器[未启动游戏]";
                }
                MainForm.RemoveAllCheck();
            }
        }
    }

    [ProfileProperty]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.checkBox1.Checked = value); } catch {}")]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.textBox1.Enabled = !value); } catch {}")]
    [ProfilePropertyAddSet(@"if(value) Program.Manager[""Reset""].StartListen(10); else Program.Manager[""Reset""].StopListen()")]
    [ProfilePropertyAddSet("resetFuncStart = value")]
    static bool resetFuncStart;
    [ProfileProperty]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.checkBox2.Checked = value); } catch {}")]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.textBox2.Enabled = !value); } catch {}")]
    [ProfilePropertyAddSet(@"if(value) Program.Manager[""TimeCounter""].StartListen(10); else Program.Manager[""TimeCounter""].StopListen()")]
    [ProfilePropertyAddSet("timeCounterFuncStart = value")]
    static bool timeCounterFuncStart;
    [ProfileProperty]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.checkBox3.Checked = value); } catch {}")]
    [ProfilePropertyAddSet(@"try{ MainForm.Current?.Invoke(() => MainForm.Current.textBox3.Enabled = !value); } catch {}")]
    [ProfilePropertyAddSet(@"if(value) Program.Manager[""Stamina""].StartListen(10); else Program.Manager[""Stamina""].StopListen()")]
    [ProfilePropertyAddSet("staminaFuncStart = value")]
    static bool staminaFuncStart;
}
