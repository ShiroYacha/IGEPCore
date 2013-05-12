using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CvConsole
{
    public partial class MainWindow : Form
    {
        private ResourceParser mainWindowParser=new ResourceParser("MainWindow","en-US");
        private Dictionary<string, Control> navigationDict=new Dictionary<string, Control>();

        private static MainWindow theMainWindow;

        private StartupWindow startupWindow;
        private MonitorsWindow monitorsWindow;
        private ModelsWindow modelsWindow;
        private SettingsWindow settingsWindow;

        public MainWindow()
        {
            // Set main window handle
            theMainWindow = this;
            // Initialize
            InitializeComponent();
            // Initialize and store navigation views in a dictionary
            startupWindow = new StartupWindow();
            monitorsWindow = new MonitorsWindow();
            modelsWindow = new ModelsWindow();
            settingsWindow = new SettingsWindow();
            navigationDict.Add("Startup", startupWindow);
            navigationDict.Add("Monitors", monitorsWindow);
            navigationDict.Add("Models", modelsWindow);
            navigationDict.Add("Settings", settingsWindow);
            // Set all controls dock to fill
            foreach (Control control in navigationDict.Values)
                control.Dock = DockStyle.Fill;
        }

        private void toolS_NavBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Reset style on all navigation items
            foreach (ToolStripItem item in toolS_NavBar.Items)
                item.Font = new Font(item.Font.FontFamily, mainWindowParser.GetData<Single>("NavItemFontSize"),FontStyle.Regular);
            // Set style on the selected navigation item
            e.ClickedItem.Font = new Font(e.ClickedItem.Font.FontFamily, mainWindowParser.GetData<Single>("SelectedNavItemFontSize"), FontStyle.Bold);
            // Navigate to selected view
            panel_MainContainer.Controls.Clear();
            panel_MainContainer.Controls.Add(navigationDict[e.ClickedItem.Text]);
            // Intercept events
            switch (e.ClickedItem.Text)
            {
                case "Monitors":
                    interceptOnNavigateToMonitorsWindow();
                    break;
            }
        }
        private void interceptOnNavigateToMonitorsWindow()
        {
            // Check if monitor is launchable
            if (SystemSettings.Setting == null)
                monitorsWindow.SetNotLaunchable();
            else monitorsWindow.SetLaunchable();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set initial view to start up
            panel_MainContainer.Controls.Add(navigationDict["Startup"]);
        }

        public static void SetStatus(string status)
        {
            theMainWindow.toolSS_AppStatus.Text = status;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control ctrl in navigationDict.Values)
                ctrl.Dispose();
        }
    }
}
