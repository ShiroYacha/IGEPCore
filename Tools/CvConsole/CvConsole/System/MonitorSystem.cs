using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Structure;

using IgepCore.CV;

namespace CvConsole
{
    public class MonitorAdapter
    {
        private ImageBox monitor;
        private IDisplayable displayable;
        private Panel dockingPanel;

        public MonitorAdapter(IDisplayable displayable, Panel dockingPanel)
        {
            this.displayable=displayable;
            this.dockingPanel=dockingPanel;
            monitor = new ImageBox();
            monitor.SizeMode = PictureBoxSizeMode.Normal;
        }

        public void Update()
        {
            monitor.Image = displayable.Display(dockingPanel.Width, dockingPanel.Height);
        }

        public void MoveToFront()
        {
            // Set monitor in panel
            dockingPanel.Controls.Clear();
            dockingPanel.Controls.Add(monitor);
            // Setup monitor size
            monitor.Width = dockingPanel.Width;
            monitor.Height = dockingPanel.Height;
            // Register size change event
            dockingPanel.SizeChanged += Resize;
        }

        public void MoveToBack()
        {
            // Unregister size change event
            dockingPanel.SizeChanged -= Resize;
        }

        private void Resize(object sender,EventArgs e)
        {
            monitor.Width = dockingPanel.Width;
            monitor.Height = dockingPanel.Height;
        }
    }

    public class MonitorSystem
    {
        private MonitorAdapter currentMonitor;
        private Dictionary<string, MonitorAdapter> monitorDict=new Dictionary<string,MonitorAdapter>();

        public List<string> RegisteredMonitorCodes
        {
            get {return monitorDict.Keys.ToList();}
        }

        public void UpdateCurrentMonitor()
        {
            currentMonitor.Update();
        }

        public void RegisterMonitor(string name, IDisplayable displayable, Panel dockingPanel)
        {
            monitorDict.Add(name,new MonitorAdapter(displayable,dockingPanel));
        }

        public void NavigateToMonitor(string code)
        {
            // Move to back the current monitor if set
            if(currentMonitor!=null) currentMonitor.MoveToBack();
            // Move to front the new monitor
            currentMonitor = monitorDict[code];
            currentMonitor.MoveToFront();
        }
    }
}
