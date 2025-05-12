using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BatExpert
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private string? currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
            InitAsync();
        }

        private async void InitAsync()
        {
            await webView21.EnsureCoreWebView2Async();
            string htmlPath = Path.Combine(Application.StartupPath, "index.html");

            if (!File.Exists(htmlPath))
            {
                MessageBox.Show($"Файл не найден: {htmlPath}");
                return;
            }

            webView21.CoreWebView2.Navigate($"file:///{htmlPath.Replace("\\", "/")}");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var code = await webView21.ExecuteScriptAsync("editor.getValue();");
                string text = JsonSerializer.Deserialize<string>(code);
                File.WriteAllText(sfd.FileName, text);
                currentFilePath = sfd.FileName;
            }
        }

        private async void Open_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                string escaped = text.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "").Replace("\n", "\\n");
                await webView21.ExecuteScriptAsync($"editor.setValue(\"{escaped}\");");
                currentFilePath = ofd.FileName;
            }
        }

        private async void DeleteAll_Click(object sender, EventArgs e)
        {
            await webView21.ExecuteScriptAsync("editor.setValue('');");
        }

        private async void Run_Click(object sender, EventArgs e)
        {
            var code = await webView21.ExecuteScriptAsync("editor.getValue();");
            string text = JsonSerializer.Deserialize<string>(code);

            if (currentFilePath != null)
            {
                File.WriteAllText(currentFilePath, text);
            }
            else
            {
                var sfd = new SaveFileDialog { Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, text);
                    currentFilePath = sfd.FileName;
                }
            }

            string tempPath = Path.Combine(Path.GetTempPath(), "run_temp.bat");
            File.WriteAllText(tempPath, text);
            System.Diagnostics.Process.Start("cmd.exe", $"/c \"{tempPath}\"");
        }

        private async void Undo_Click(object sender, EventArgs e)
        {
            try
            {
                await webView21.ExecuteScriptAsync("editor.getModel().undo();");
            }
            catch
            {
            }
        }

        private async void Redo_Click(object sender, EventArgs e)
        {
            try
            {
                await webView21.ExecuteScriptAsync("editor.getModel().redo();");
            }
            catch
            {
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HideRun_Click(object sender, EventArgs e)
        {
            Run.Visible = !Run.Visible;
        }
    }
}
