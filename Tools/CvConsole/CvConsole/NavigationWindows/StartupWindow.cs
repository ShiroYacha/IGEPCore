using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices;

namespace CvConsole
{
    public partial class StartupWindow : UserControl
    {
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);

        private const string INPUTTYPE_SINGLE = "Single";
        private const string INPUTTYPE_STEREO = "Stereo";
        private const string SOURCETYPE_IMAGE = "Image";
        private const string SOURCETYPE_CAMERA = "Camera";
        private const string SOURCETYPE_VIDEO = "Video";

        private const string INPUTSOURCE_IMAGE = "Image source";
        private const string INPUTSOURCE_CAMERA = "Camera source";
        private const string INPUTSOURCE_VIDEO = "Video source";
        private const string INPUTSOURCE_IMAGE_STEREO = "Image stereo source";
        private const string INPUTSOURCE_CAMERA_STEREO = "Camera stereo source";
        private const string INPUTSOURCE_VIDEO_STEREO = "Video stereo source";
        private const string INPUTSOURCE_COMBOBOX_IMAGE = "Browse image...";
        private string[] INPUTSOURCE_COMBOBOX_CAMERA = new string[]{"0","1","2"};
        private const string INPUTSOURCE_COMBOBOX_VIDEO = "Browse video...";

        private bool onLoad = false;

        private Setting currentSetting;

        public StartupWindow()
        {
            InitializeComponent();
        }

        private void StartupWindow_Load(object sender, EventArgs e)
        {
            // Initialize setting
            currentSetting = new Setting();
            // Load models in list view
            findModelDataInFolder();
            // Update summary
            updateSummary();
            // Set MainWindow status
            MainWindow.SetStatus("Waiting for Startup settings ...");
        }

        private void findModelDataInFolder()
        {
            // Clear list view items
            listV_FoundModelData.Items.Clear();
            // Add items in list view 
            string folderPath = StaticResources.GetFolderPathFromBin("Models", "ModelDataXml");
            string[] modelDataPaths = Directory.GetFiles(folderPath);
            listV_FoundModelData.Items.AddRange(
                Array.ConvertAll<string, ListViewItem>(
                    modelDataPaths.Where((filePath) => { return Path.GetExtension(filePath) == ".xml"; }).ToArray(),
                    (stringPath)=>
                        {
                            string key=Path.GetFileNameWithoutExtension(stringPath);
                            ListViewItem item = new ListViewItem(key);
                            item.Name=key;
                            return item;
                        }
                )
                );
        }
        private void btn_MoveAllRight_Click(object sender, EventArgs e)
        {
            listV_LoadedModelData.Items.Clear();
            listV_LoadedModelData.Items.AddRange((from ListViewItem item in listV_FoundModelData.Items
                                                  select (ListViewItem)item.CloneWithName()).ToArray());
            currentSetting.Models = (from ListViewItem item in listV_LoadedModelData.Items select item.Text).ToList();
            updateSummary();
        }
        private void btn_MoveAllLeft_Click(object sender, EventArgs e)
        {
            listV_LoadedModelData.Items.Clear();
            currentSetting.Models = (from ListViewItem item in listV_LoadedModelData.Items select item.Text).ToList();
            updateSummary();
        }
        private void btn_MoveRight_Click(object sender, EventArgs e)
        {
            listV_LoadedModelData.Items.AddRange((from ListViewItem item in listV_FoundModelData.SelectedItems
                                                  where !listV_LoadedModelData.Items.ContainsKey(item.Name)
                                                  select (ListViewItem)item.CloneWithName()).ToArray());
            btn_MoveRight.Enabled = false;
            currentSetting.Models = (from ListViewItem item in listV_LoadedModelData.Items select item.Text).ToList();
            updateSummary();
        }
        private void btn_MoveLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listV_LoadedModelData.SelectedItems)
                listV_LoadedModelData.Items.RemoveByKey(selectedItem.Name);
            btn_MoveLeft.Enabled = false;
            currentSetting.Models = (from ListViewItem item in listV_LoadedModelData.Items select item.Text).ToList();
            updateSummary();
        }
        private void listV_FoundModelData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_MoveRight.Enabled = true;
        }
        private void listV_LoadedModelData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btn_MoveLeft.Enabled = true;
        }

        private void comboB_SourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable comboboxs
            comboB_LeftSource.Enabled = true;
            comboB_RightSource.Enabled = true;
            comboB_LeftSource.Items.Clear();
            comboB_RightSource.Items.Clear();
            if (!onLoad) currentSetting = new Setting();
            // Generate combobox items
            switch ((string)comboB_SourceType.SelectedItem)
            {
                case INPUTSOURCE_IMAGE:
                    comboB_LeftSource.Items.Add(INPUTSOURCE_COMBOBOX_IMAGE);
                    comboB_RightSource.Enabled = false;
                    currentSetting.InputType = INPUTTYPE_SINGLE;
                    currentSetting.SourceType = SOURCETYPE_IMAGE;
                    break;
                case INPUTSOURCE_CAMERA:
                    comboB_LeftSource.Items.AddRange(INPUTSOURCE_COMBOBOX_CAMERA);
                    comboB_RightSource.Enabled = false;
                    currentSetting.InputType = INPUTTYPE_SINGLE;
                    currentSetting.SourceType = SOURCETYPE_CAMERA;
                    break;
                case INPUTSOURCE_VIDEO:
                    comboB_LeftSource.Items.Add(INPUTSOURCE_COMBOBOX_VIDEO);
                    comboB_RightSource.Enabled = false;
                    currentSetting.InputType = INPUTTYPE_SINGLE;
                    currentSetting.SourceType = SOURCETYPE_VIDEO;
                    break;
                case INPUTSOURCE_IMAGE_STEREO:
                    comboB_LeftSource.Items.Add(INPUTSOURCE_COMBOBOX_IMAGE);
                    comboB_RightSource.Items.Add(INPUTSOURCE_COMBOBOX_IMAGE);
                    currentSetting.InputType = INPUTTYPE_STEREO;
                    currentSetting.SourceType = SOURCETYPE_IMAGE;
                    break;
                case INPUTSOURCE_CAMERA_STEREO:
                    comboB_LeftSource.Items.AddRange(INPUTSOURCE_COMBOBOX_CAMERA);
                    comboB_RightSource.Items.AddRange(INPUTSOURCE_COMBOBOX_CAMERA);
                    currentSetting.InputType = INPUTTYPE_STEREO;
                    currentSetting.SourceType = SOURCETYPE_CAMERA;
                    break;
                case INPUTSOURCE_VIDEO_STEREO:
                    comboB_LeftSource.Items.Add(INPUTSOURCE_COMBOBOX_VIDEO);
                    comboB_RightSource.Items.Add(INPUTSOURCE_COMBOBOX_VIDEO);
                    currentSetting.InputType = INPUTTYPE_STEREO;
                    currentSetting.SourceType = SOURCETYPE_VIDEO;
                    break;
            }
            // Update summary
            updateSummary();
        }
        private void comboB_LeftSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboB_LeftSource.SelectedItem as string == INPUTSOURCE_COMBOBOX_IMAGE)
            {
                string selectedLeftSourcePath = browseImageFile();
                if (selectedLeftSourcePath != null)
                {
                    comboB_LeftSource.Items.Clear();
                    comboB_LeftSource.Items.AddRange(new string[] { INPUTSOURCE_COMBOBOX_IMAGE,selectedLeftSourcePath });
                }
                comboB_LeftSource.SelectedItem = selectedLeftSourcePath;
                currentSetting.Source = new string[] { selectedLeftSourcePath };
            }
            else if (comboB_LeftSource.SelectedItem as string== INPUTSOURCE_COMBOBOX_VIDEO)
            {
                string selectedLeftSourcePath = browseVideoFile();
                if (selectedLeftSourcePath != null)
                {
                    comboB_LeftSource.Items.Clear();
                    comboB_LeftSource.Items.AddRange(new string[] { INPUTSOURCE_COMBOBOX_IMAGE, selectedLeftSourcePath });
                }
                comboB_LeftSource.SelectedItem = selectedLeftSourcePath;
                currentSetting.Source = new string[] { selectedLeftSourcePath };
            }
            else // Camera channel
            {
                currentSetting.Source = new string[] { comboB_LeftSource.SelectedItem as string};
            }
            // Update summary
            updateSummary();
        }
        private void comboB_RightSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboB_RightSource.SelectedItem as string == INPUTSOURCE_COMBOBOX_IMAGE)
            {
               string selectedRightSourcePath = browseImageFile();
               if (selectedRightSourcePath != null)
               {
                   comboB_RightSource.Items.Clear();
                   comboB_RightSource.Items.AddRange(new string[] { INPUTSOURCE_COMBOBOX_VIDEO, selectedRightSourcePath });
               }
                comboB_RightSource.SelectedItem = selectedRightSourcePath;
                currentSetting.Source = new string[] { selectedRightSourcePath };
            }
            else if (comboB_RightSource.SelectedItem as string == INPUTSOURCE_COMBOBOX_VIDEO)
            {
                string selectedRightSourcePath = browseVideoFile();
                if (selectedRightSourcePath != null)
                {
                    comboB_RightSource.Items.Clear();
                    comboB_RightSource.Items.AddRange(new string[] { INPUTSOURCE_COMBOBOX_VIDEO, selectedRightSourcePath });
                }
                comboB_RightSource.SelectedItem = selectedRightSourcePath;
                currentSetting.Source = new string[] { selectedRightSourcePath };
            }
            else // Camera channel
            {
                currentSetting.Source = new string[] { comboB_RightSource.SelectedItem as string };
            }
            // Update summary
            updateSummary();
        }
        private string browseImageFile()
        {
            openFileDialog_Image.Title = "Load Image file";
            openFileDialog_Image.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog_Image.InitialDirectory = StaticResources.GetFolderPathFromBin("Images");
            if (openFileDialog_Image.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog_Image.FileName;
            }
            else return null;
        }
        private string browseVideoFile()
        {
            openFileDialog_Video.Title = "Load Video file";
            openFileDialog_Video.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav";
            openFileDialog_Video.InitialDirectory = StaticResources.GetFolderPathFromBin("Videos");
            if (openFileDialog_Video.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog_Video.FileName;
            }
            else return null;
        }

        private void richTextB_Summary_MouseDown(object sender, MouseEventArgs e)
        {
            // Hide the IBeam in the rich text box
            HideCaret(richTextB_Summary.Handle);
        }
        private void richTextB_Summary_MouseEnter(object sender, EventArgs e)
        {
            // Hide the IBeam in the rich text box
            HideCaret(richTextB_Summary.Handle);
        }
        private void updateSummary()
        {
            // Clear all
            richTextB_Summary.Clear();
            // Generate summaries
            List<string> summary = new List<string>();
            summary.Add("Input type:"); // Title "Input type" 
            if (currentSetting.InputType != null) 
                summary.Add(currentSetting.InputType); // Context "Input type" 
            summary.Add(Environment.NewLine);
            summary.Add("Source type:"); // Title "Input type" 
            if (currentSetting.SourceType != null) 
                summary.Add(currentSetting.SourceType); // Context "Input type" 
            summary.Add(Environment.NewLine);
            if (!comboB_RightSource.Enabled)
            {
                summary.Add("Source:"); // Title "Source" 
                if (currentSetting.Source != null) 
                    summary.Add(currentSetting.Source[0]); // Context "Source" 
                summary.Add(Environment.NewLine);
            }
            else
            {
                summary.Add("Left source:"); // Title "Left source" 
                if (currentSetting.Source != null) 
                    summary.Add(currentSetting.Source[0]); // Context "Left source" 
                summary.Add("Right source:"); // Title "Right source" 
                if (currentSetting.Source != null) 
                    summary.Add(currentSetting.Source[1]); // Context "Right source" 
                summary.Add(Environment.NewLine);
            }
            summary.Add("Loaded models:"); // Title "Loaded models" 
            if (currentSetting.Models != null) 
                summary.AddRange(currentSetting.Models); // Context "Left source" 
            summary.Add(Environment.NewLine);
            // Populate summary in rich text box
            richTextB_Summary.Lines=summary.ToArray();
            // Set colors
            setSummaryColor("Input type:", Color.Blue);
            setSummaryColor("Source type:", Color.Blue);
            setSummaryColor("Source:", Color.Blue);
            setSummaryColor("Left source:", Color.Blue);
            setSummaryColor("Right source:", Color.Blue);
            setSummaryColor("Loaded models:", Color.Blue);
        }
        private void setSummaryColor(string text, Color color)
        {
            if (richTextB_Summary.Find(text) >= 0)
            {
                int my1stPosition = richTextB_Summary.Find(text);
                richTextB_Summary.SelectionStart = my1stPosition;
                richTextB_Summary.SelectionLength = text.Length;
                richTextB_Summary.SelectionColor = color;
            } 
        }

        private bool checkCompleteness()
        {
            return currentSetting.SourceType != null && currentSetting.SourceType != string.Empty
                && currentSetting.InputType != null && currentSetting.InputType != string.Empty
                && currentSetting.Source != null && currentSetting.Source.Length != 0 && currentSetting.Source[0] != string.Empty
                && currentSetting.Models != null && currentSetting.Models.Count != 0 && currentSetting.Models[0] != string.Empty;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkCompleteness())
            {
                saveFileDialog_SaveStartUp.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog_SaveStartUp.Title = "Append to an Xml File";
                saveFileDialog_SaveStartUp.InitialDirectory = StaticResources.GetFolderPathFromBin("Settings");
                if (saveFileDialog_SaveStartUp.ShowDialog() == DialogResult.OK)
                {
                    string serializedSetting = currentSetting.Serialize<Setting>();
                    XmlSerializer serializer = new XmlSerializer(typeof(Setting));
                    FileStream fs = new FileStream(saveFileDialog_SaveStartUp.FileName, FileMode.Create);
                    serializer.Serialize(fs, currentSetting);
                    fs.Close();
                    MessageBox.Show("Save done.", "Save settings");
                }
            }
            else
                MessageBox.Show("Information incomplete", "Save settings");
        }
        private void btn_Load_Click(object sender, EventArgs e)
        {
            openFileDialog_Settings.Filter = "XML files (*.xml)|*.xml";
            openFileDialog_Settings.Title = "Open an Xml File";
            openFileDialog_Settings.InitialDirectory = StaticResources.GetFolderPathFromBin("Settings");
            if (openFileDialog_Settings.ShowDialog() == DialogResult.OK)
            {
                using (var stream = System.IO.File.OpenRead(openFileDialog_Settings.FileName))
                {
                    // Start
                    onLoad = true;
                    // Deserialize
                    XmlSerializer serializer = new XmlSerializer(typeof(Setting));
                    currentSetting = serializer.Deserialize(stream) as Setting;
                    // Update controls
                    comboB_SourceType.SelectedItem = currentSetting.SourceType + (currentSetting.InputType == INPUTTYPE_STEREO ? " stereo " : " ") + "source";
                    comboB_LeftSource.Items.Add(currentSetting.Source[0]);
                    comboB_LeftSource.SelectedItem = currentSetting.Source[0];
                    if (currentSetting.Source.Length>1)
                    {
                        comboB_RightSource.Items.Add(currentSetting.Source[1]);
                        comboB_RightSource.SelectedItem = currentSetting.Source[1];
                    }
                    listV_LoadedModelData.Items.Clear();
                    listV_LoadedModelData.Items.AddRange(
                         Array.ConvertAll<string, ListViewItem>(
                             currentSetting.Models.ToArray(),
                             (stringPath) =>
                             {
                                 string key = Path.GetFileNameWithoutExtension(stringPath);
                                 ListViewItem item = new ListViewItem(key);
                                 item.Name = key;
                                 return item;
                             }
                         )
                         );
                    // Update summary
                    updateSummary();
                    // Finish
                    onLoad = false;
                }
            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "Start")
                if(checkCompleteness())
                    lockAll();
                else MessageBox.Show("Information incomplete", "Save settings");
            else
                unlockAll();
        }
        private void lockAll()
        {
            groupB_Input.Enabled = false;
            groupB_Models.Enabled = false;
            btn_Save.Enabled = false;
            btn_Load.Enabled = false;
            btn_Start.Text = "Stop";
            SystemSettings.Setting = currentSetting;
            // Set MainWindow status
            MainWindow.SetStatus("Ready ...");
        }
        private void unlockAll()
        {
            groupB_Input.Enabled = true;
            groupB_Models.Enabled = true;
            btn_Save.Enabled = true;
            btn_Load.Enabled = true;
            btn_Start.Text = "Start";
            SystemSettings.Setting = null;
            // Set MainWindow status
            MainWindow.SetStatus("Waiting for Startup settings ...");
        }

    }
}
