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
        Trace.WriteLine($"���ƣ�{e.CustomName} ��ַ��{sender:X}\t�Ƿ��ȡ��ֵ  �ϴΣ�{e.PreviousValueGetSuccessful}  ��Σ�{e.CurrentValueGetSuccessful}  ֵ�ӣ�{e.PreviousValue}  ���Ϊ��{e.CurrentValue}");
        switch (e.CustomName)
        {
            case "Reset":
                if (e.CurrentValueGetSuccessful && checkBox1.Checked)
                {
                    if (!sender.Write(int.Parse(textBox1.Text)))
                        Trace.WriteLine($"Resetд��ʧ��");
                }
                break;
            case "TimeCounter":
                if (e.CurrentValueGetSuccessful && checkBox2.Checked)
                {
                    if (!sender.Write(float.Parse(textBox2.Text)))
                        Trace.WriteLine("TimeCounterд��ʧ��");
                }
                break;
            case "Stamina":
                if (e.CurrentValueGetSuccessful && checkBox3.Checked)
                {
                    if (!sender.Write(float.Parse(textBox3.Text)))
                        Trace.WriteLine("Staminaд��ʧ��");
                }
                break;
            default:
                break;
        }
    }

    private async void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart())
                {
                    try
                    {
                        textBox1.Enabled = false;
                        Program.Manager["Reset"].Write(int.Parse(textBox1.Text));
                        await Program.Manager["Stamina"].StartListen();
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart())
                {
                    try
                    {
                        textBox2.Enabled = false;
                        Program.Manager["TimeCounter"].Write(float.Parse(textBox2.Text));
                        await Program.Manager["Stamina"].StartListen();
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
            else
            {
                textBox2.Enabled = true;
            }
        }
    }

    private async void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (CheckGameStart())
                {
                    try
                    {
                        textBox3.Enabled = false;
                        Program.Manager["Stamina"].Write(float.Parse(textBox3.Text));
                        await Program.Manager["Stamina"].StartListen();
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine(ex.ToString());
                    }
                }
                else
                {
                    checkBox3.Checked = false;
                }
            }
            else
            {
                textBox3.Enabled = true;
            }
        }
    }

    private static bool CheckGameStart()
    {
        if (!SystemProfile.IsGameRunning)
        {
            MessageBox.Show("��������Ϸ");
            return false;
        }
        return true;
    }

    public static void RemoveAllCheck()
    {
        Current?.Invoke(() => Current.checkBox1.Checked = false);
        Current?.Invoke(() => Current.checkBox2.Checked = false);
        Current?.Invoke(() => Current.checkBox3.Checked = false);
    }
}
