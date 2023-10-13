
namespace FolderMonitor
{
    partial class index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.LVFile = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModifyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.txtMin = new DevExpress.XtraEditors.TextEdit();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartMonitor = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.picFolder2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.picFolder1 = new DevExpress.XtraEditors.PictureEdit();
            this.labMonitorPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.txtMonitorPath = new System.Windows.Forms.ComboBox();
            this.txtBackCopyPath = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(936, 596);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.LVFile);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Location = new System.Drawing.Point(14, 187);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(905, 403);
            this.panelControl3.TabIndex = 2;
            // 
            // LVFile
            // 
            this.LVFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colModifyDate,
            this.colType,
            this.colSize});
            this.LVFile.HideSelection = false;
            this.LVFile.Location = new System.Drawing.Point(15, 31);
            this.LVFile.Name = "LVFile";
            this.LVFile.Size = new System.Drawing.Size(873, 359);
            this.LVFile.TabIndex = 1;
            this.LVFile.UseCompatibleStateImageBehavior = false;
            this.LVFile.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "文件名称";
            this.colFile.Width = 113;
            // 
            // colModifyDate
            // 
            this.colModifyDate.Text = "修改日期";
            this.colModifyDate.Width = 135;
            // 
            // colType
            // 
            this.colType.Text = "类型";
            this.colType.Width = 112;
            // 
            // colSize
            // 
            this.colSize.Text = "大小";
            this.colSize.Width = 190;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(417, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 20);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "监控结果";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Appearance.Options.UseForeColor = true;
            this.panelControl2.Controls.Add(this.txtBackCopyPath);
            this.panelControl2.Controls.Add(this.txtMonitorPath);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.btnStop);
            this.panelControl2.Controls.Add(this.txtMin);
            this.panelControl2.Controls.Add(this.btnQuit);
            this.panelControl2.Controls.Add(this.btnStartMonitor);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.pictureEdit4);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.picFolder2);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.picFolder1);
            this.panelControl2.Controls.Add(this.labMonitorPath);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Location = new System.Drawing.Point(14, 16);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(905, 154);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(415, 129);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(154, 16);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "不填写时间默认是全部文件删除";
            // 
            // btnStop
            // 
            this.btnStop.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.Appearance.Options.UseBackColor = true;
            this.btnStop.Location = new System.Drawing.Point(691, 111);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 29);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "停止监控";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtMin
            // 
            this.txtMin.EditValue = "3";
            this.txtMin.Location = new System.Drawing.Point(358, 106);
            this.txtMin.Name = "txtMin";
            this.txtMin.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMin.Properties.Appearance.Options.UseFont = true;
            this.txtMin.Size = new System.Drawing.Size(55, 26);
            this.txtMin.TabIndex = 14;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMin_KeyPress_1);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(786, 111);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 29);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "退出";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStartMonitor.Appearance.Options.UseBackColor = true;
            this.btnStartMonitor.Location = new System.Drawing.Point(596, 111);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(88, 29);
            this.btnStartMonitor.TabIndex = 11;
            this.btnStartMonitor.Text = "开始监控";
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(415, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(165, 20);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "分钟之外的文件自动删除";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(331, 107);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(25, 25);
            this.pictureEdit4.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(261, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 20);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "监控条件";
            // 
            // picFolder2
            // 
            this.picFolder2.EditValue = ((object)(resources.GetObject("picFolder2.EditValue")));
            this.picFolder2.Location = new System.Drawing.Point(848, 69);
            this.picFolder2.Name = "picFolder2";
            this.picFolder2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picFolder2.Properties.Appearance.Options.UseBackColor = true;
            this.picFolder2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFolder2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picFolder2.Size = new System.Drawing.Size(25, 25);
            this.picFolder2.TabIndex = 7;
            this.picFolder2.Click += new System.EventHandler(this.picFolder2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(214, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 20);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "备份文件夹路径";
            // 
            // picFolder1
            // 
            this.picFolder1.EditValue = ((object)(resources.GetObject("picFolder1.EditValue")));
            this.picFolder1.Location = new System.Drawing.Point(848, 27);
            this.picFolder1.Name = "picFolder1";
            this.picFolder1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picFolder1.Properties.Appearance.Options.UseBackColor = true;
            this.picFolder1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFolder1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picFolder1.Size = new System.Drawing.Size(25, 25);
            this.picFolder1.TabIndex = 4;
            this.picFolder1.Click += new System.EventHandler(this.picFolder1_Click);
            // 
            // labMonitorPath
            // 
            this.labMonitorPath.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonitorPath.Appearance.Options.UseFont = true;
            this.labMonitorPath.Location = new System.Drawing.Point(214, 28);
            this.labMonitorPath.Name = "labMonitorPath";
            this.labMonitorPath.Size = new System.Drawing.Size(105, 20);
            this.labMonitorPath.TabIndex = 2;
            this.labMonitorPath.Text = "监控文件夹路径";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "文件监控工具";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(38, 44);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // MonitorTimer
            // 
            this.MonitorTimer.Interval = 3000;
            this.MonitorTimer.Tick += new System.EventHandler(this.MonitorTimer_Tick);
            // 
            // txtMonitorPath
            // 
            this.txtMonitorPath.FormattingEnabled = true;
            this.txtMonitorPath.Location = new System.Drawing.Point(330, 28);
            this.txtMonitorPath.Name = "txtMonitorPath";
            this.txtMonitorPath.Size = new System.Drawing.Size(518, 26);
            this.txtMonitorPath.TabIndex = 13;
            // 
            // txtBackCopyPath
            // 
            this.txtBackCopyPath.FormattingEnabled = true;
            this.txtBackCopyPath.Location = new System.Drawing.Point(331, 69);
            this.txtBackCopyPath.Name = "txtBackCopyPath";
            this.txtBackCopyPath.Size = new System.Drawing.Size(517, 26);
            this.txtBackCopyPath.TabIndex = 17;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(961, 620);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "监控文件工具";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit picFolder2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit picFolder1;
        private DevExpress.XtraEditors.LabelControl labMonitorPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnStartMonitor;
        private System.Windows.Forms.ListView LVFile;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colModifyDate;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Timer MonitorTimer;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.TextEdit txtMin;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox txtBackCopyPath;
        private System.Windows.Forms.ComboBox txtMonitorPath;
    }
}

