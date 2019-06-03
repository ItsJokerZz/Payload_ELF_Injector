using librpc;
using Payload_ELF_Injector.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payload_ELF_Injector
{
    public partial class Tool : Form
    {
        public Tool()
        {
            InitializeComponent();
            TestConnection();
        }

        string Payload_File;
        string Payload;
        string ELF_File;
        string ELF;
        readonly string jkPatch_Payload = Application.StartupPath + "\\payload.bin";
        readonly string jkPatch_ELF = Application.StartupPath + "\\kpayload.elf";
        public static PS4RPC ps4 = new PS4RPC(Settings.Default.IP);
        private string selectedProcess = null;
        private ProcessList pList = null;

        void TestConnection()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    ps4.Connect();

                    Invoke((MethodInvoker)delegate
                    {
                        CurrentStatus_Label.ForeColor = Color.LimeGreen;
                        CurrentStatus_Label.Text = "Already connected to PS4 using jkPatch!";

                        GetProcesses();

                        IP_TextBox.Enabled = false;
                        Port_TextBox.Enabled = false;
                        InjectjkPatch_Button.Enabled = false;
                        ConnectPS4_Button.Enabled = false;
                        SelectELF_Button.Enabled = true;
                        InjectELF_Button.Enabled = true;
                        Proccesses_ComboBox.Enabled = true;
                        RefreshProcesses_Button.Enabled = true;
                    });
                }
                catch
                {
                }
            });
        }

        private void Tool_Load(object Injecter, EventArgs e)
        {
            IP_TextBox.Text = Settings.Default.IP;
            Port_TextBox.Text = Settings.Default.PORT;

            ConnectPS4_Button.Enabled = false;
            InjectPayload_Button.Enabled = false;
            SelectELF_Button.Enabled = false;
            InjectELF_Button.Enabled = false;
            Proccesses_ComboBox.Enabled = false;
            RefreshProcesses_Button.Enabled = false;
        }

            void SocketConnection(string IP, string Payload, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.ReceiveTimeout = 1500;
            socket.SendTimeout = 1500;
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(Payload);
            socket.Close();
        }

        private void IP_TextBox_TextChanged(object Injecter, EventArgs e)
        {
            Settings.Default.IP = IP_TextBox.Text;
            Settings.Default.Save();
        }

        private void Port_TextBox_TextChanged(object Injecter, EventArgs e)
        {
            Settings.Default.PORT = Port_TextBox.Text;
            Settings.Default.Save();
        }

        private void InjectjkPatch_Button_Click(object sender, EventArgs e)
        {
            jkPatch_BGWorker.RunWorkerAsync();
        }

        private void ConnectPS4_Button_Click(object Injecter, EventArgs e)
        {
            try
            {
                ps4.Connect();
                Calling.Notify("ItsJokerZz's\nPayload + ELF Injector\n\nhas connected!\n\n\n", 210);
                selectedProcess = null;
                GetProcesses();

                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.LimeGreen;
                    CurrentStatus_Label.Text = "Connected to PS4 using jkPatch!";

                    IP_TextBox.Enabled = false;
                    Port_TextBox.Enabled = false;
                    InjectjkPatch_Button.Enabled = false;
                    ConnectPS4_Button.Enabled = false;
                    SelectELF_Button.Enabled = true;
                    InjectELF_Button.Enabled = true;
                    Proccesses_ComboBox.Enabled = true;
                    RefreshProcesses_Button.Enabled = true;
                });
            }
            catch (Exception)
            {
                CurrentStatus_Label.ForeColor = Color.Red;
                CurrentStatus_Label.Text = "Connection to PS4 using jkPatch failed!";
            }
        }

        private void SelectPayload_Button_Click(object Injecter, System.EventArgs e)
        {
            OpenPayloadDialog.ShowDialog();
            Payload_File = OpenPayloadDialog.FileName;
            Payload = Path.GetFileNameWithoutExtension(OpenPayloadDialog.FileName);

            CurrentStatus_Label.ForeColor = Color.RoyalBlue;
            CurrentStatus_Label.Text = $"{Payload}.bin has been selected!";

            InjectPayload_Button.Enabled = true;
        }

        private void InjectPayload_Button_Click(object sender, EventArgs e)
        {
            Payload_BGWorker.RunWorkerAsync();
        }

        private void SelectELF_Button_Click(object Injecter, System.EventArgs e)
        {
            OpenELFDialog.ShowDialog();
            ELF_File = OpenELFDialog.FileName;
            ELF = Path.GetFileNameWithoutExtension(OpenELFDialog.FileName);

            CurrentStatus_Label.ForeColor = Color.RoyalBlue;
            CurrentStatus_Label.Text = $"{ELF}.elf has been selected!";

            InjectELF_Button.Enabled = true;
        }

        private void Proccesses_ComboBox_SelectedIndexChanged(object Injecter, EventArgs e)
        {
            if (Proccesses_ComboBox.Text == "  Select a Process")
            {
            }
            else
            {
                selectedProcess = Proccesses_ComboBox.SelectedItem.ToString();
            }
        }

        private void RefreshProcesses_Button_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void InjectELF_Button_Click(object sender, EventArgs e)
        {
            ELF_BGWorker.RunWorkerAsync();
        }

        private void JkPatch_BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.RoyalBlue;
                    CurrentStatus_Label.Text = $"Sending payload.bin to {IP_TextBox.Text}:{Port_TextBox.Text}...";
                });
                SocketConnection(IP_TextBox.Text, jkPatch_Payload, Convert.ToInt32(Port_TextBox.Text));
                Thread.Sleep(2000);
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.Text = $"Sending kpayload.elf to {IP_TextBox.Text}:9023...";
                });
                SocketConnection(IP_TextBox.Text, jkPatch_ELF, 9023);
                Thread.Sleep(1000);
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.LimeGreen;
                    CurrentStatus_Label.Text = "jkPatch injected successfully!";
                    Calling.Notify("Payload + ELF Injector\nCreated by ItsJokerZz\n\njkPatch injected successfully!\n\n\n", 210);

                    InjectjkPatch_Button.Enabled = false;
                    ConnectPS4_Button.Enabled = true;
                });
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        CurrentStatus_Label.ForeColor = Color.Red;
                        CurrentStatus_Label.Text = "jkPatch injection failed!";

                    });
                }
                else
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void Payload_BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.RoyalBlue;
                    CurrentStatus_Label.Text = $"Sending {Payload}.bin to {IP_TextBox.Text}:{Port_TextBox.Text}...";
                });
                SocketConnection(IP_TextBox.Text, Payload_File, Convert.ToInt32(Port_TextBox.Text));
                Thread.Sleep(1000);
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.LimeGreen;
                    CurrentStatus_Label.Text = $"{Payload}.bin injected successfully!";
                });
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        CurrentStatus_Label.ForeColor = Color.Red;
                        CurrentStatus_Label.Text = $"{Payload}.bin injection failed!";
                    });
                }
                else
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void ELF_BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.RoyalBlue;
                    CurrentStatus_Label.Text = $"Sending {ELF}.elf to {IP_TextBox.Text}:{Port_TextBox.Text}...";
                });

                byte[] elf = File.ReadAllBytes(ELF_File);
                Process process = pList.FindProcess(selectedProcess);
                ps4.LoadElf(process.pid, elf);
                Thread.Sleep(1000);
                Invoke((MethodInvoker)delegate
                {
                    CurrentStatus_Label.ForeColor = Color.LimeGreen;
                    CurrentStatus_Label.Text = $"{ELF}.elf injected successfully!";
                });
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        CurrentStatus_Label.ForeColor = Color.Red;
                        CurrentStatus_Label.Text = $"{ELF}.elf injection failed!";

                    });
                }
                else
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        void GetProcesses()
        {
            try
            {
                Proccesses_ComboBox.Items.Clear();
                pList = ps4.GetProcessList();
                Process[] processes = pList.processes;
                foreach (Process process in processes)
                {
                    Proccesses_ComboBox.Items.Add(process.name);
                }
            }
            catch (Exception)
            {
                CurrentStatus_Label.ForeColor = Color.Red;
                CurrentStatus_Label.Text = "Unable to grab processes";
            }
        }
    }
}
