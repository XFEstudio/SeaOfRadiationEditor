using System.Diagnostics;
using XFEExtension.NetCore.MemoryEditor;

namespace SeaOfRadiationEditor;

public partial class MainForm : Form
{
    public static MainForm? Current { get; set; }
    public MainForm()
    {
        InitializeComponent();
        Current = this;
        Program.Manager.ValueChanged += Manager_ValueChanged;
    }

    private void Manager_ValueChanged(XFEExtension.NetCore.MemoryEditor.Manager.MemoryItem sender, MemoryValue e)
    {
        Trace.WriteLine($"名称：{e.CustomName} 地址：{sender:X}\t是否读取到值  上次：{e.PreviousValueGetSuccessful}  这次：{e.CurrentValueGetSuccessful}  值从：{e.PreviousValue}  变更为：{e.CurrentValue}");
        switch (e.CustomName)
        {
            case "Reset":
                if (e.CurrentValueGetSuccessful && SystemProfile.ResetFuncStart)
                {
                    if (!sender.Write(int.Parse(textBox1.Text)))
                        Trace.WriteLine($"Reset写入失败");
                }
                break;
            case "TimeCounter":
                if (e.CurrentValueGetSuccessful && SystemProfile.TimeCounterFuncStart)
                {
                    if (!sender.Write(float.Parse(textBox2.Text)))
                        Trace.WriteLine("TimeCounter写入失败");
                }
                break;
            case "Stamina":
                if (e.CurrentValueGetSuccessful && SystemProfile.StaminaFuncStart)
                {
                    if (!sender.Write(float.Parse(textBox3.Text)))
                        Trace.WriteLine("Stamina写入失败");
                }
                break;
            default:
                break;
        }
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart(checkBox))
                {
                    SystemProfile.ResetFuncStart = true;
                    Program.Manager["Reset"].Write(int.Parse(textBox1.Text));
                }
            }
            else
            {
                SystemProfile.ResetFuncStart = false;
            }
        }
    }

    private void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart(checkBox))
                {
                    SystemProfile.TimeCounterFuncStart = true;
                    Program.Manager["TimeCounter"].Write(float.Parse(textBox2.Text));
                }
            }
            else
            {
                SystemProfile.TimeCounterFuncStart = false;
            }
        }
    }

    private void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart(checkBox))
                {
                    SystemProfile.StaminaFuncStart = true;
                    Program.Manager["Stamina"].Write(float.Parse(textBox3.Text));
                }
            }
            else
            {
                SystemProfile.StaminaFuncStart = false;
            }
        }
    }

    private static bool CheckGameStart(CheckBox checkBox)
    {
        if (!SystemProfile.IsGameRunning)
        {
            MessageBox.Show("请启动游戏");
            RemoveAllCheck();
            return false;
        }
        return true;
    }

    public static void RemoveAllCheck()
    {
        SystemProfile.ResetFuncStart = false;
        SystemProfile.TimeCounterFuncStart = false;
        SystemProfile.StaminaFuncStart = false;
    }
}
