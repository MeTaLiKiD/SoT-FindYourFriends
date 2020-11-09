using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoTFindYourFriends
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            IsRunningAsAdmin();
        }

        private void IsRunningAsAdmin()
        {
            try
            {
                var runningAsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

                if (!runningAsAdmin)
                {
                    MessageBox.Show(AppResources.NotRunningAsAdmin);
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(AppResources.UnexpectedError);
            }
        }

        private async void FindServer(object sender, EventArgs e)
        {
            // UI
            FindServerButton.Enabled = false;
            FindServerButton.Text = AppResources.SearchingServer;
            LoadingPicture.Visible = true;
            ServerTextBox.Text = string.Empty;
            ReportLabel.Text = string.Empty;
            ReportLabel.Visible = false;

            // Search server in a task (does not block UI)
            var sotServer = "";
            await Task.Run(() =>
            {
                // Find SoT UDP ports
                var udpPorts = ProcessPorts.ProcessPortMap
                    .FindAll(_ => _.ProcessName.ToLower() == "sotgame")
                    .Select(_ => _.PortNumber)
                    .ToList();

                // Get local ip address
                var localIpAddress = Dns
                    .GetHostEntry(Dns.GetHostName())
                    .AddressList
                    .Where(_ => _.AddressFamily == AddressFamily.InterNetwork)
                    .ToList();

                // Search which UDP port is the one used by SoT
                foreach (var localIp in localIpAddress)
                {
                    foreach (var udpPort in udpPorts)
                    {
                        var server = SoTServerFinder.FindSoTServer(localIp, udpPort);

                        if (!string.IsNullOrEmpty(server))
                        {
                            sotServer = server;
                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(sotServer))
                        break;
                }
            });

            if (string.IsNullOrEmpty(sotServer))
            {
                ReportLabel.Text = AppResources.ServerNotFound;
                ReportLabel.Visible = true;
            }
            else
                ServerTextBox.Text = sotServer;

            // UI
            FindServerButton.Enabled = true;
            FindServerButton.Text = AppResources.FindServer;
            LoadingPicture.Visible = false;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ServerTextBox.Text))
                Clipboard.SetText(ServerTextBox.Text);
        }

        private void DiscordLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/7pHP3xu");
        }

        private void GithubLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MeTaLiKiD/SoT-FindYourFriends");
        }
    }
}
