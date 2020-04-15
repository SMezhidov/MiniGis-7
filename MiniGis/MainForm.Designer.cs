namespace MiniGis
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MyMap = new MiniGis.Core.Map();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSelect = new System.Windows.Forms.ToolStripButton();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolSetting = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyMap
            // 
            this.MyMap.ActiveTool = MiniGis.Core.MapToolType.Select;
            this.MyMap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MyMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyMap.Location = new System.Drawing.Point(0, 0);
            this.MyMap.MapScale = 1D;
            this.MyMap.Margin = new System.Windows.Forms.Padding(4);
            this.MyMap.Name = "MyMap";
            this.MyMap.Size = new System.Drawing.Size(1217, 611);
            this.MyMap.TabIndex = 0;
            this.MyMap.Load += new System.EventHandler(this.MyMap_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSelect,
            this.toolPan,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1217, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSelect
            // 
            this.toolSelect.Checked = true;
            this.toolSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelect.Enabled = false;
            this.toolSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolSelect.Image")));
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(24, 24);
            this.toolSelect.Text = "Select";
            this.toolSelect.ToolTipText = "toolSelect\r\n";
            this.toolSelect.Click += new System.EventHandler(this.toolSelect_Click);
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = ((System.Drawing.Image)(resources.GetObject("toolPan.Image")));
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(24, 24);
            this.toolPan.Text = "Pan";
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomIn.Image")));
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(24, 24);
            this.toolZoomIn.Text = "Zoom in";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(24, 24);
            this.toolZoomOut.Text = "Zoom out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolSetting
            // 
            this.toolSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolSetting.Image")));
            this.toolSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSetting.Name = "toolSetting";
            this.toolSetting.Size = new System.Drawing.Size(24, 24);
            this.toolSetting.Text = "Setting";
            this.toolSetting.Click += new System.EventHandler(this.toolSetting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MyMap);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MiniGis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Map MyMap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSelect;
        private System.Windows.Forms.ToolStripButton toolPan;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton toolSetting;
    }
}

