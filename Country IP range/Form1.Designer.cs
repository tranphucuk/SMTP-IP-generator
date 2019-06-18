namespace Country_IP_range
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtratabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraHome = new DevExpress.XtraTab.XtraTabPage();
            this.sbPause = new DevExpress.XtraEditors.SimpleButton();
            this.mmIPRange = new DevExpress.XtraEditors.MemoEdit();
            this.lblTotalIpRanges = new DevExpress.XtraEditors.LabelControl();
            this.leSaveOptions = new DevExpress.XtraEditors.LookUpEdit();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbClear = new DevExpress.XtraEditors.SimpleButton();
            this.sbStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.leCountries = new DevExpress.XtraEditors.LookUpEdit();
            this.xtraSplit = new DevExpress.XtraTab.XtraTabPage();
            this.sbPauseSplit = new DevExpress.XtraEditors.SimpleButton();
            this.sbCheckDup = new DevExpress.XtraEditors.SimpleButton();
            this.sbSaveFile = new DevExpress.XtraEditors.SimpleButton();
            this.lblCountIP = new DevExpress.XtraEditors.LabelControl();
            this.pgbPercentSplit = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblTotalImport = new DevExpress.XtraEditors.LabelControl();
            this.lblFilePath = new DevExpress.XtraEditors.LabelControl();
            this.leSplitOptions = new DevExpress.XtraEditors.LookUpEdit();
            this.mmSplitRanges = new DevExpress.XtraEditors.MemoEdit();
            this.sbSplit = new DevExpress.XtraEditors.SimpleButton();
            this.sbLoad = new DevExpress.XtraEditors.SimpleButton();
            this.xtraAbout = new DevExpress.XtraTab.XtraTabPage();
            this.tmrChangeWord = new System.Windows.Forms.Timer(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtratabControl)).BeginInit();
            this.xtratabControl.SuspendLayout();
            this.xtraHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmIPRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSaveOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCountries.Properties)).BeginInit();
            this.xtraSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbPercentSplit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSplitOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmSplitRanges.Properties)).BeginInit();
            this.xtraAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Green";
            // 
            // xtratabControl
            // 
            this.xtratabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtratabControl.Location = new System.Drawing.Point(0, 0);
            this.xtratabControl.Name = "xtratabControl";
            this.xtratabControl.SelectedTabPage = this.xtraHome;
            this.xtratabControl.Size = new System.Drawing.Size(359, 408);
            this.xtratabControl.TabIndex = 5;
            this.xtratabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraHome,
            this.xtraSplit,
            this.xtraAbout});
            // 
            // xtraHome
            // 
            this.xtraHome.Controls.Add(this.labelControl2);
            this.xtraHome.Controls.Add(this.sbPause);
            this.xtraHome.Controls.Add(this.mmIPRange);
            this.xtraHome.Controls.Add(this.lblTotalIpRanges);
            this.xtraHome.Controls.Add(this.leSaveOptions);
            this.xtraHome.Controls.Add(this.sbSave);
            this.xtraHome.Controls.Add(this.sbClear);
            this.xtraHome.Controls.Add(this.sbStart);
            this.xtraHome.Controls.Add(this.labelControl1);
            this.xtraHome.Controls.Add(this.leCountries);
            this.xtraHome.ImageOptions.Image = global::Country_IP_range.Properties.Resources.home_10x10;
            this.xtraHome.Name = "xtraHome";
            this.xtraHome.Size = new System.Drawing.Size(353, 377);
            this.xtraHome.Text = "Home";
            // 
            // sbPause
            // 
            this.sbPause.AllowFocus = false;
            this.sbPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbPause.ImageOptions.Image")));
            this.sbPause.Location = new System.Drawing.Point(314, 17);
            this.sbPause.Name = "sbPause";
            this.sbPause.Size = new System.Drawing.Size(28, 28);
            this.sbPause.TabIndex = 47;
            this.sbPause.Click += new System.EventHandler(this.sbPause_Click);
            // 
            // mmIPRange
            // 
            this.mmIPRange.Location = new System.Drawing.Point(10, 51);
            this.mmIPRange.Name = "mmIPRange";
            this.mmIPRange.Properties.ReadOnly = true;
            this.mmIPRange.Size = new System.Drawing.Size(332, 249);
            this.mmIPRange.TabIndex = 46;
            // 
            // lblTotalIpRanges
            // 
            this.lblTotalIpRanges.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIpRanges.Appearance.Options.UseFont = true;
            this.lblTotalIpRanges.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalIpRanges.Location = new System.Drawing.Point(12, 337);
            this.lblTotalIpRanges.Name = "lblTotalIpRanges";
            this.lblTotalIpRanges.Size = new System.Drawing.Size(158, 28);
            this.lblTotalIpRanges.TabIndex = 45;
            this.lblTotalIpRanges.Text = "Total: ...";
            // 
            // leSaveOptions
            // 
            this.leSaveOptions.Location = new System.Drawing.Point(9, 308);
            this.leSaveOptions.Name = "leSaveOptions";
            this.leSaveOptions.Properties.AllowFocused = false;
            this.leSaveOptions.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leSaveOptions.Properties.Appearance.Options.UseFont = true;
            this.leSaveOptions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSaveOptions.Properties.DropDownRows = 2;
            this.leSaveOptions.Size = new System.Drawing.Size(104, 24);
            this.leSaveOptions.TabIndex = 44;
            // 
            // sbSave
            // 
            this.sbSave.AllowFocus = false;
            this.sbSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSave.Appearance.Options.UseFont = true;
            this.sbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbSave.ImageOptions.Image")));
            this.sbSave.Location = new System.Drawing.Point(119, 306);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(107, 28);
            this.sbSave.TabIndex = 43;
            this.sbSave.Text = "Save";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // sbClear
            // 
            this.sbClear.AllowFocus = false;
            this.sbClear.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbClear.Appearance.Options.UseFont = true;
            this.sbClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbClear.ImageOptions.Image")));
            this.sbClear.Location = new System.Drawing.Point(232, 306);
            this.sbClear.Name = "sbClear";
            this.sbClear.Size = new System.Drawing.Size(112, 28);
            this.sbClear.TabIndex = 41;
            this.sbClear.Text = "Clear";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // sbStart
            // 
            this.sbStart.AllowFocus = false;
            this.sbStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbStart.Appearance.Options.UseFont = true;
            this.sbStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbStart.ImageOptions.Image")));
            this.sbStart.Location = new System.Drawing.Point(215, 17);
            this.sbStart.Name = "sbStart";
            this.sbStart.Size = new System.Drawing.Size(95, 28);
            this.sbStart.TabIndex = 42;
            this.sbStart.Text = "Start";
            this.sbStart.Click += new System.EventHandler(this.sbStart_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 18);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Country";
            // 
            // leCountries
            // 
            this.leCountries.Location = new System.Drawing.Point(66, 19);
            this.leCountries.Name = "leCountries";
            this.leCountries.Properties.AllowFocused = false;
            this.leCountries.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leCountries.Properties.Appearance.Options.UseFont = true;
            this.leCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCountries.Properties.DropDownRows = 12;
            this.leCountries.Size = new System.Drawing.Size(143, 24);
            this.leCountries.TabIndex = 39;
            // 
            // xtraSplit
            // 
            this.xtraSplit.Controls.Add(this.sbPauseSplit);
            this.xtraSplit.Controls.Add(this.sbCheckDup);
            this.xtraSplit.Controls.Add(this.sbSaveFile);
            this.xtraSplit.Controls.Add(this.lblCountIP);
            this.xtraSplit.Controls.Add(this.pgbPercentSplit);
            this.xtraSplit.Controls.Add(this.lblTotalImport);
            this.xtraSplit.Controls.Add(this.lblFilePath);
            this.xtraSplit.Controls.Add(this.leSplitOptions);
            this.xtraSplit.Controls.Add(this.mmSplitRanges);
            this.xtraSplit.Controls.Add(this.sbSplit);
            this.xtraSplit.Controls.Add(this.sbLoad);
            this.xtraSplit.ImageOptions.Image = global::Country_IP_range.Properties.Resources.spli10x10;
            this.xtraSplit.Name = "xtraSplit";
            this.xtraSplit.Size = new System.Drawing.Size(353, 377);
            this.xtraSplit.Text = "Split";
            // 
            // sbPauseSplit
            // 
            this.sbPauseSplit.AllowFocus = false;
            this.sbPauseSplit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPauseSplit.Appearance.Options.UseFont = true;
            this.sbPauseSplit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbPauseSplit.ImageOptions.Image")));
            this.sbPauseSplit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.sbPauseSplit.Location = new System.Drawing.Point(205, 303);
            this.sbPauseSplit.Name = "sbPauseSplit";
            this.sbPauseSplit.Size = new System.Drawing.Size(25, 28);
            this.sbPauseSplit.TabIndex = 9;
            this.sbPauseSplit.Click += new System.EventHandler(this.sbPauseSplit_Click);
            // 
            // sbCheckDup
            // 
            this.sbCheckDup.AllowFocus = false;
            this.sbCheckDup.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCheckDup.Appearance.Options.UseFont = true;
            this.sbCheckDup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCheckDup.ImageOptions.Image")));
            this.sbCheckDup.Location = new System.Drawing.Point(237, 303);
            this.sbCheckDup.Name = "sbCheckDup";
            this.sbCheckDup.Size = new System.Drawing.Size(106, 28);
            this.sbCheckDup.TabIndex = 8;
            this.sbCheckDup.Text = "Check";
            this.sbCheckDup.Click += new System.EventHandler(this.sbCheckDup_Click);
            // 
            // sbSaveFile
            // 
            this.sbSaveFile.AllowFocus = false;
            this.sbSaveFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSaveFile.Appearance.Options.UseFont = true;
            this.sbSaveFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbSaveFile.ImageOptions.Image")));
            this.sbSaveFile.Location = new System.Drawing.Point(237, 336);
            this.sbSaveFile.Name = "sbSaveFile";
            this.sbSaveFile.Size = new System.Drawing.Size(106, 28);
            this.sbSaveFile.TabIndex = 7;
            this.sbSaveFile.Text = "Save";
            this.sbSaveFile.Click += new System.EventHandler(this.sbSaveFile_Click);
            // 
            // lblCountIP
            // 
            this.lblCountIP.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountIP.Appearance.Options.UseFont = true;
            this.lblCountIP.Appearance.Options.UseTextOptions = true;
            this.lblCountIP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblCountIP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCountIP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCountIP.Location = new System.Drawing.Point(323, 18);
            this.lblCountIP.Name = "lblCountIP";
            this.lblCountIP.Size = new System.Drawing.Size(20, 24);
            this.lblCountIP.TabIndex = 6;
            this.lblCountIP.Text = "0";
            this.lblCountIP.Visible = false;
            // 
            // pgbPercentSplit
            // 
            this.pgbPercentSplit.Location = new System.Drawing.Point(9, 344);
            this.pgbPercentSplit.Name = "pgbPercentSplit";
            this.pgbPercentSplit.Properties.AllowFocused = false;
            this.pgbPercentSplit.Properties.ShowTitle = true;
            this.pgbPercentSplit.Size = new System.Drawing.Size(221, 18);
            this.pgbPercentSplit.TabIndex = 5;
            // 
            // lblTotalImport
            // 
            this.lblTotalImport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImport.Appearance.Options.UseFont = true;
            this.lblTotalImport.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalImport.Location = new System.Drawing.Point(9, 45);
            this.lblTotalImport.Name = "lblTotalImport";
            this.lblTotalImport.Size = new System.Drawing.Size(251, 27);
            this.lblTotalImport.TabIndex = 4;
            this.lblTotalImport.Text = "Status: ...";
            // 
            // lblFilePath
            // 
            this.lblFilePath.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Appearance.Options.UseFont = true;
            this.lblFilePath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFilePath.Location = new System.Drawing.Point(101, 16);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(231, 28);
            this.lblFilePath.TabIndex = 3;
            // 
            // leSplitOptions
            // 
            this.leSplitOptions.Location = new System.Drawing.Point(8, 303);
            this.leSplitOptions.Name = "leSplitOptions";
            this.leSplitOptions.Properties.AllowFocused = false;
            this.leSplitOptions.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leSplitOptions.Properties.Appearance.Options.UseFont = true;
            this.leSplitOptions.Properties.AutoHeight = false;
            this.leSplitOptions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSplitOptions.Properties.DropDownRows = 3;
            this.leSplitOptions.Size = new System.Drawing.Size(71, 24);
            this.leSplitOptions.TabIndex = 2;
            // 
            // mmSplitRanges
            // 
            this.mmSplitRanges.Location = new System.Drawing.Point(8, 78);
            this.mmSplitRanges.Name = "mmSplitRanges";
            this.mmSplitRanges.Properties.ReadOnly = true;
            this.mmSplitRanges.Size = new System.Drawing.Size(335, 218);
            this.mmSplitRanges.TabIndex = 1;
            // 
            // sbSplit
            // 
            this.sbSplit.AllowFocus = false;
            this.sbSplit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSplit.Appearance.Options.UseFont = true;
            this.sbSplit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbSplit.ImageOptions.Image")));
            this.sbSplit.Location = new System.Drawing.Point(85, 303);
            this.sbSplit.Name = "sbSplit";
            this.sbSplit.Size = new System.Drawing.Size(115, 28);
            this.sbSplit.TabIndex = 0;
            this.sbSplit.Text = "Split";
            this.sbSplit.Click += new System.EventHandler(this.sbSplit_Click);
            // 
            // sbLoad
            // 
            this.sbLoad.AllowFocus = false;
            this.sbLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLoad.Appearance.Options.UseFont = true;
            this.sbLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbLoad.ImageOptions.Image")));
            this.sbLoad.Location = new System.Drawing.Point(8, 16);
            this.sbLoad.Name = "sbLoad";
            this.sbLoad.Size = new System.Drawing.Size(84, 28);
            this.sbLoad.TabIndex = 0;
            this.sbLoad.Text = "Import";
            this.sbLoad.Click += new System.EventHandler(this.sbLoad_Click);
            // 
            // xtraAbout
            // 
            this.xtraAbout.Controls.Add(this.labelControl5);
            this.xtraAbout.Controls.Add(this.labelControl4);
            this.xtraAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraAbout.ImageOptions.Image")));
            this.xtraAbout.Name = "xtraAbout";
            this.xtraAbout.Size = new System.Drawing.Size(353, 377);
            this.xtraAbout.Text = "About";
            // 
            // tmrChangeWord
            // 
            this.tmrChangeWord.Interval = 1000;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(204, 340);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 23);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Author: tranphucggg";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(83, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(157, 38);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "ICQ: 700589020";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(83, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(157, 38);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Skype: tranphucggg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 408);
            this.Controls.Add(this.xtratabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP IP Range Generator";
            ((System.ComponentModel.ISupportInitialize)(this.xtratabControl)).EndInit();
            this.xtratabControl.ResumeLayout(false);
            this.xtraHome.ResumeLayout(false);
            this.xtraHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmIPRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSaveOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCountries.Properties)).EndInit();
            this.xtraSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgbPercentSplit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSplitOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmSplitRanges.Properties)).EndInit();
            this.xtraAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTab.XtraTabControl xtratabControl;
        private DevExpress.XtraTab.XtraTabPage xtraHome;
        private DevExpress.XtraTab.XtraTabPage xtraSplit;
        private DevExpress.XtraTab.XtraTabPage xtraAbout;
        private DevExpress.XtraEditors.MemoEdit mmIPRange;
        private DevExpress.XtraEditors.LabelControl lblTotalIpRanges;
        private DevExpress.XtraEditors.LookUpEdit leSaveOptions;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbClear;
        private DevExpress.XtraEditors.SimpleButton sbStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit leCountries;
        private DevExpress.XtraEditors.SimpleButton sbPause;
        private DevExpress.XtraEditors.LabelControl lblTotalImport;
        private DevExpress.XtraEditors.LabelControl lblFilePath;
        private DevExpress.XtraEditors.LookUpEdit leSplitOptions;
        private DevExpress.XtraEditors.MemoEdit mmSplitRanges;
        private DevExpress.XtraEditors.SimpleButton sbSplit;
        private DevExpress.XtraEditors.SimpleButton sbLoad;
        private DevExpress.XtraEditors.ProgressBarControl pgbPercentSplit;
        private DevExpress.XtraEditors.LabelControl lblCountIP;
        private DevExpress.XtraEditors.SimpleButton sbSaveFile;
        private System.Windows.Forms.Timer tmrChangeWord;
        private DevExpress.XtraEditors.SimpleButton sbCheckDup;
        private DevExpress.XtraEditors.SimpleButton sbPauseSplit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

