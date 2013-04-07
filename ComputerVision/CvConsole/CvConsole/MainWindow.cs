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

        public MainWindow()
        {
            InitializeComponent();
            // Initialize and store navigation views in a dictionary
            navigationDict.Add("Startup", new StartupWindow());
            navigationDict.Add("Monitors", new MonitorsWindow());
            navigationDict.Add("Models", new ModelsWindow());
            navigationDict.Add("Settings", new SettingsWindow());
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
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set initial view to start up
            panel_MainContainer.Controls.Add(navigationDict["Startup"]);

        }
    }
}
