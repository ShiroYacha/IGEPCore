using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.UI;

using IgepCore.CV;
using IgepCore.CV.InputSystem;
using IgepCore.CV.ProcessSystem;

namespace CvConsole
{
    public partial class MonitorsWindow : UserControl
    {
        // Navigation codes
        private const string MONITORCODE_INPUTSYSTEM = "InputSystem";

        private ICvSystem cvSystem;
        private MonitorSystem monitorSystem;

        public MonitorsWindow()
        {
            InitializeComponent();
            // Handle destruction
            this.HandleDestroyed += (s, e) => { stopSystem(); };
        }

        public void SetLaunchable()
        {
            btn_Launch.Text = "Launch";
            btn_Launch.Enabled = true;
        }
        public void SetNotLaunchable()
        {
            btn_Launch.Text = "Not launchable (Config startup first)";
            btn_Launch.Enabled = false;
        }

        private void MonitorsWindow_Load(object sender, EventArgs e)
        {
            // Setup monitor system
            monitorSystem = new MonitorSystem();
        }
        private void listV_MonitorNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listV_MonitorNavigation.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listV_MonitorNavigation.Items)
                    item.Font = new Font(listV_MonitorNavigation.Font, FontStyle.Regular);
                ListViewItem selectedItem = listV_MonitorNavigation.SelectedItems[0];
                selectedItem.Font = new Font(listV_MonitorNavigation.Font, FontStyle.Bold);
                string selectedCode = selectedItem.Name;
                monitorSystem.NavigateToMonitor(selectedCode);
            }
        }
        private void displayTimer_Tick(object sender, EventArgs e)
        {
            monitorSystem.UpdateCurrentMonitor();
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            if (btn_Launch.Text == "Launch")
            {
                // Launch system
                createAndLaunchSystem();
                // Populate navigation panel
                listV_MonitorNavigation.Items.Clear();
                listV_MonitorNavigation.Items.AddRange(monitorSystem.RegisteredMonitorCodes.ConvertAll<ListViewItem>(
                        (code)=>{
                            ListViewItem item=new ListViewItem(code);
                            item.Name=code;
                            return item;
                        }
                    ).ToArray());
                // Set init monitor
                listV_MonitorNavigation.Items[MONITORCODE_INPUTSYSTEM].Selected = true;
                listV_MonitorNavigation.Select();
                // Enable display timer
                displayTimer.Enabled = true;
                // Set button to Stop
                btn_Launch.Text = "Stop";
            }
            else
            {
                // Init
                stopSystem();
                // Set button to Launch
                btn_Launch.Text = "Launch";
            }
        }
        private void createAndLaunchSystem()
        {
            // Cv system
            cvSystem = new BasicCvSystem();
            // Input system
            setupInputSystem();
            // Process system
            setupProcessSystem();
            // Launch system
            cvSystem.LaunchSystem();
        }
        private void setupInputSystem()
        {
            IInputSystem inputSystem;
            Setting setting=SystemSettings.Setting;
            // Create input system
            switch (setting.InputType)
            {
                case "Single":
                    if (setting.SourceType == "Camera")
                        inputSystem = InputSystemFactory.CreateSingleCameraInputSystem(int.Parse(setting.Source[0]));
                    else inputSystem = InputSystemFactory.CreateSingleImageInputSystem(setting.Source[0]);
                    break;
                case "Stereo":
                    if (setting.SourceType == "Camera")
                        inputSystem = InputSystemFactory.CreateStereoCameraInputSystem(int.Parse(setting.Source[0]), int.Parse(setting.Source[1]));
                    else inputSystem = InputSystemFactory.CreateStereoImageInputSystem(setting.Source[0], setting.Source[1]);
                    break;
                default: throw new ArgumentNullException("Input system is invalid or null.");
            }
            // Bind input system to monitor system and cv system
            cvSystem.InputSystem = inputSystem;
            monitorSystem.RegisterMonitor(MONITORCODE_INPUTSYSTEM, inputSystem, panel_Monitor);
        }
        private void setupProcessSystem()
        {
            NativeLayerProcessSystem processSystem;
            // Create process system
            processSystem = ProcessSystemFactory.CreateNativeLayerProcessSystem();
            // Bind process system to monitor system and cv system
            cvSystem.ProcessSystem = processSystem;
            List<ILayer> layerSequenceList = processSystem.LayerSequenceList;
            foreach (ILayer layer in layerSequenceList)
                monitorSystem.RegisterMonitor(layer.Name, layer, panel_Monitor);
        }
        private void stopSystem()
        {
            // Disable the update timer
            displayTimer.Enabled = false;
            // Clear panel control
            panel_Monitor.Controls.Clear();
            // Reset monitor system
            listV_MonitorNavigation.Items.Clear();
            monitorSystem = new MonitorSystem();
            // Stop system
            if (cvSystem != null) cvSystem.StopSystem();
        }
    }
}
