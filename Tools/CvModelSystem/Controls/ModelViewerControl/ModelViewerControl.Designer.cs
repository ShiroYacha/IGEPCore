namespace CvModelSystem.Controls.ModelViewerControl
{
    partial class ModelViewerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLP_Main
            // 
            this.tableLP_Main.ColumnCount = 1;
            this.tableLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLP_Main.Name = "tableLP_Main";
            this.tableLP_Main.RowCount = 2;
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLP_Main.Size = new System.Drawing.Size(438, 399);
            this.tableLP_Main.TabIndex = 0;
            // 
            // ModelViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLP_Main);
            this.Name = "ModelViewerControl";
            this.Size = new System.Drawing.Size(438, 399);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_Main;
    }
}
