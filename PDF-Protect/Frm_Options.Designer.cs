namespace PDF_Protect
{
    partial class Frm_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Options));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpProtect = new System.Windows.Forms.GroupBox();
            this.btnProtect = new System.Windows.Forms.Button();
            this.grpUserRights = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkOptPrint = new System.Windows.Forms.CheckBox();
            this.chkOptFormsFill = new System.Windows.Forms.CheckBox();
            this.chkOptAssembleDocument = new System.Windows.Forms.CheckBox();
            this.chkOptAnnotations = new System.Windows.Forms.CheckBox();
            this.chkOptExtractContent = new System.Windows.Forms.CheckBox();
            this.grpPass = new System.Windows.Forms.GroupBox();
            this.chkDefineOpts = new System.Windows.Forms.CheckBox();
            this.txtExplainPasswords = new System.Windows.Forms.TextBox();
            this.txtOwnerPass = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.lblOwnerPass = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lblSrcPass = new System.Windows.Forms.Label();
            this.txtSrcPass = new System.Windows.Forms.TextBox();
            this.chkNeedOpenPwd = new System.Windows.Forms.CheckBox();
            this.lblWarnSrcDstIdentic = new System.Windows.Forms.Label();
            this.btnSelDst = new System.Windows.Forms.Button();
            this.btnSelSrc = new System.Windows.Forms.Button();
            this.lblDstFileName = new System.Windows.Forms.Label();
            this.lblDst = new System.Windows.Forms.Label();
            this.lblSrcFileName = new System.Windows.Forms.Label();
            this.lblSrc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diesesProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOptions.SuspendLayout();
            this.grpProtect.SuspendLayout();
            this.grpUserRights.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.grpProtect);
            this.grpOptions.Controls.Add(this.grpUserRights);
            this.grpOptions.Controls.Add(this.grpPass);
            this.grpOptions.Controls.Add(this.grpFiles);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOptions.Location = new System.Drawing.Point(0, 24);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(447, 640);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Schutzoptionen:";
            // 
            // grpProtect
            // 
            this.grpProtect.Controls.Add(this.btnProtect);
            this.grpProtect.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProtect.Location = new System.Drawing.Point(3, 570);
            this.grpProtect.Name = "grpProtect";
            this.grpProtect.Size = new System.Drawing.Size(441, 100);
            this.grpProtect.TabIndex = 3;
            this.grpProtect.TabStop = false;
            this.grpProtect.Text = "Schützen:";
            // 
            // btnProtect
            // 
            this.btnProtect.Location = new System.Drawing.Point(6, 19);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(133, 23);
            this.btnProtect.TabIndex = 0;
            this.btnProtect.Text = "Ausführen";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.btnProtect_Click);
            // 
            // grpUserRights
            // 
            this.grpUserRights.Controls.Add(this.textBox1);
            this.grpUserRights.Controls.Add(this.chkOptPrint);
            this.grpUserRights.Controls.Add(this.chkOptFormsFill);
            this.grpUserRights.Controls.Add(this.chkOptAssembleDocument);
            this.grpUserRights.Controls.Add(this.chkOptAnnotations);
            this.grpUserRights.Controls.Add(this.chkOptExtractContent);
            this.grpUserRights.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUserRights.Location = new System.Drawing.Point(3, 387);
            this.grpUserRights.Name = "grpUserRights";
            this.grpUserRights.Size = new System.Drawing.Size(441, 183);
            this.grpUserRights.TabIndex = 2;
            this.grpUserRights.TabStop = false;
            this.grpUserRights.Text = "Benutzerrechte:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(435, 38);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Folgende Rechteeinschränkungen werden angewendet, wenn das Dokument mit dem Benut" +
    "zerkennwort geöffnet wird.";
            // 
            // chkOptPrint
            // 
            this.chkOptPrint.AutoSize = true;
            this.chkOptPrint.Checked = true;
            this.chkOptPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOptPrint.Location = new System.Drawing.Point(6, 152);
            this.chkOptPrint.Name = "chkOptPrint";
            this.chkOptPrint.Size = new System.Drawing.Size(156, 17);
            this.chkOptPrint.TabIndex = 5;
            this.chkOptPrint.Text = "Erlaube Dokument drucken";
            this.chkOptPrint.UseVisualStyleBackColor = true;
            // 
            // chkOptFormsFill
            // 
            this.chkOptFormsFill.AutoSize = true;
            this.chkOptFormsFill.Checked = true;
            this.chkOptFormsFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOptFormsFill.Location = new System.Drawing.Point(6, 129);
            this.chkOptFormsFill.Name = "chkOptFormsFill";
            this.chkOptFormsFill.Size = new System.Drawing.Size(244, 17);
            this.chkOptFormsFill.TabIndex = 4;
            this.chkOptFormsFill.Text = "Erlaube Formulare ausfüllen / Inhalt verändern";
            this.chkOptFormsFill.UseVisualStyleBackColor = true;
            // 
            // chkOptAssembleDocument
            // 
            this.chkOptAssembleDocument.AutoSize = true;
            this.chkOptAssembleDocument.Location = new System.Drawing.Point(6, 106);
            this.chkOptAssembleDocument.Name = "chkOptAssembleDocument";
            this.chkOptAssembleDocument.Size = new System.Drawing.Size(212, 17);
            this.chkOptAssembleDocument.TabIndex = 3;
            this.chkOptAssembleDocument.Text = "Erlaube Dokumentenstruktur verändern";
            this.chkOptAssembleDocument.UseVisualStyleBackColor = true;
            // 
            // chkOptAnnotations
            // 
            this.chkOptAnnotations.AutoSize = true;
            this.chkOptAnnotations.Location = new System.Drawing.Point(6, 83);
            this.chkOptAnnotations.Name = "chkOptAnnotations";
            this.chkOptAnnotations.Size = new System.Drawing.Size(124, 17);
            this.chkOptAnnotations.TabIndex = 2;
            this.chkOptAnnotations.Text = "Erlaube Kommentare";
            this.chkOptAnnotations.UseVisualStyleBackColor = true;
            // 
            // chkOptExtractContent
            // 
            this.chkOptExtractContent.AutoSize = true;
            this.chkOptExtractContent.Location = new System.Drawing.Point(6, 60);
            this.chkOptExtractContent.Name = "chkOptExtractContent";
            this.chkOptExtractContent.Size = new System.Drawing.Size(263, 17);
            this.chkOptExtractContent.TabIndex = 1;
            this.chkOptExtractContent.Text = "Erlaube Inhalt extrahieren (Inhalte herauskopieren)";
            this.chkOptExtractContent.UseVisualStyleBackColor = true;
            this.chkOptExtractContent.CheckedChanged += new System.EventHandler(this.chkOptExtractContent_CheckedChanged);
            // 
            // grpPass
            // 
            this.grpPass.Controls.Add(this.chkDefineOpts);
            this.grpPass.Controls.Add(this.txtExplainPasswords);
            this.grpPass.Controls.Add(this.txtOwnerPass);
            this.grpPass.Controls.Add(this.txtUserPass);
            this.grpPass.Controls.Add(this.lblOwnerPass);
            this.grpPass.Controls.Add(this.lblUserPass);
            this.grpPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPass.Location = new System.Drawing.Point(3, 210);
            this.grpPass.Name = "grpPass";
            this.grpPass.Size = new System.Drawing.Size(441, 177);
            this.grpPass.TabIndex = 1;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Kennwörter:";
            // 
            // chkDefineOpts
            // 
            this.chkDefineOpts.AutoSize = true;
            this.chkDefineOpts.Checked = true;
            this.chkDefineOpts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefineOpts.Location = new System.Drawing.Point(9, 108);
            this.chkDefineOpts.Name = "chkDefineOpts";
            this.chkDefineOpts.Size = new System.Drawing.Size(200, 17);
            this.chkDefineOpts.TabIndex = 8;
            this.chkDefineOpts.Text = "Benutzerberechtigungen anpassen...";
            this.chkDefineOpts.UseVisualStyleBackColor = true;
            this.chkDefineOpts.CheckedChanged += new System.EventHandler(this.chkDefineOpts_CheckedChanged);
            // 
            // txtExplainPasswords
            // 
            this.txtExplainPasswords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplainPasswords.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtExplainPasswords.Location = new System.Drawing.Point(3, 16);
            this.txtExplainPasswords.Multiline = true;
            this.txtExplainPasswords.Name = "txtExplainPasswords";
            this.txtExplainPasswords.ReadOnly = true;
            this.txtExplainPasswords.Size = new System.Drawing.Size(435, 60);
            this.txtExplainPasswords.TabIndex = 7;
            this.txtExplainPasswords.Text = "Es können zwei Kennwörter vergeben werden:\r\n\r\nDas Nutzerkennwort ermöglicht eine " +
    "Einschränkung der Dokumentenrechte.\r\nDas Erstellerkennwort erlaubt uneingeschrän" +
    "kten Zugriff auf das Dokument.";
            // 
            // txtOwnerPass
            // 
            this.txtOwnerPass.Location = new System.Drawing.Point(109, 131);
            this.txtOwnerPass.Name = "txtOwnerPass";
            this.txtOwnerPass.Size = new System.Drawing.Size(323, 20);
            this.txtOwnerPass.TabIndex = 3;
            this.txtOwnerPass.UseSystemPasswordChar = true;
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(109, 82);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(323, 20);
            this.txtUserPass.TabIndex = 2;
            this.txtUserPass.UseSystemPasswordChar = true;
            // 
            // lblOwnerPass
            // 
            this.lblOwnerPass.AutoSize = true;
            this.lblOwnerPass.Location = new System.Drawing.Point(6, 135);
            this.lblOwnerPass.Name = "lblOwnerPass";
            this.lblOwnerPass.Size = new System.Drawing.Size(91, 13);
            this.lblOwnerPass.TabIndex = 1;
            this.lblOwnerPass.Text = "Erstellerkennwort:";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(6, 85);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(85, 13);
            this.lblUserPass.TabIndex = 0;
            this.lblUserPass.Text = "Nutzerkennwort:";
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lblSrcPass);
            this.grpFiles.Controls.Add(this.txtSrcPass);
            this.grpFiles.Controls.Add(this.chkNeedOpenPwd);
            this.grpFiles.Controls.Add(this.lblWarnSrcDstIdentic);
            this.grpFiles.Controls.Add(this.btnSelDst);
            this.grpFiles.Controls.Add(this.btnSelSrc);
            this.grpFiles.Controls.Add(this.lblDstFileName);
            this.grpFiles.Controls.Add(this.lblDst);
            this.grpFiles.Controls.Add(this.lblSrcFileName);
            this.grpFiles.Controls.Add(this.lblSrc);
            this.grpFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFiles.Location = new System.Drawing.Point(3, 16);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(441, 194);
            this.grpFiles.TabIndex = 0;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Dateien:";
            // 
            // lblSrcPass
            // 
            this.lblSrcPass.AutoSize = true;
            this.lblSrcPass.Location = new System.Drawing.Point(6, 88);
            this.lblSrcPass.Name = "lblSrcPass";
            this.lblSrcPass.Size = new System.Drawing.Size(78, 13);
            this.lblSrcPass.TabIndex = 9;
            this.lblSrcPass.Text = "Quellkennwort:";
            // 
            // txtSrcPass
            // 
            this.txtSrcPass.Location = new System.Drawing.Point(109, 85);
            this.txtSrcPass.Name = "txtSrcPass";
            this.txtSrcPass.Size = new System.Drawing.Size(323, 20);
            this.txtSrcPass.TabIndex = 9;
            this.txtSrcPass.UseSystemPasswordChar = true;
            // 
            // chkNeedOpenPwd
            // 
            this.chkNeedOpenPwd.AutoSize = true;
            this.chkNeedOpenPwd.Checked = true;
            this.chkNeedOpenPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNeedOpenPwd.Location = new System.Drawing.Point(13, 62);
            this.chkNeedOpenPwd.Name = "chkNeedOpenPwd";
            this.chkNeedOpenPwd.Size = new System.Drawing.Size(322, 17);
            this.chkNeedOpenPwd.TabIndex = 7;
            this.chkNeedOpenPwd.Text = "Zum Öffnen der Quelldatei ist ein Erstellerkennwort erforderlich:";
            this.chkNeedOpenPwd.UseVisualStyleBackColor = true;
            this.chkNeedOpenPwd.CheckedChanged += new System.EventHandler(this.chkNeedOpenPwd_CheckedChanged);
            // 
            // lblWarnSrcDstIdentic
            // 
            this.lblWarnSrcDstIdentic.AutoSize = true;
            this.lblWarnSrcDstIdentic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnSrcDstIdentic.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarnSrcDstIdentic.Location = new System.Drawing.Point(10, 146);
            this.lblWarnSrcDstIdentic.Name = "lblWarnSrcDstIdentic";
            this.lblWarnSrcDstIdentic.Size = new System.Drawing.Size(381, 16);
            this.lblWarnSrcDstIdentic.TabIndex = 6;
            this.lblWarnSrcDstIdentic.Text = "Achtung: Ausgewählte Quelldatei wird überschrieben...";
            this.lblWarnSrcDstIdentic.Visible = false;
            // 
            // btnSelDst
            // 
            this.btnSelDst.Location = new System.Drawing.Point(13, 165);
            this.btnSelDst.Name = "btnSelDst";
            this.btnSelDst.Size = new System.Drawing.Size(149, 23);
            this.btnSelDst.TabIndex = 5;
            this.btnSelDst.Text = "Andere Zieldatei bestimmen";
            this.btnSelDst.UseVisualStyleBackColor = true;
            this.btnSelDst.Click += new System.EventHandler(this.btnSelDst_Click);
            // 
            // btnSelSrc
            // 
            this.btnSelSrc.Location = new System.Drawing.Point(13, 32);
            this.btnSelSrc.Name = "btnSelSrc";
            this.btnSelSrc.Size = new System.Drawing.Size(149, 23);
            this.btnSelSrc.TabIndex = 4;
            this.btnSelSrc.Text = "Quelldatei auswählen";
            this.btnSelSrc.UseVisualStyleBackColor = true;
            this.btnSelSrc.Click += new System.EventHandler(this.btnSelSrc_Click);
            // 
            // lblDstFileName
            // 
            this.lblDstFileName.AutoSize = true;
            this.lblDstFileName.Location = new System.Drawing.Point(95, 122);
            this.lblDstFileName.Name = "lblDstFileName";
            this.lblDstFileName.Size = new System.Drawing.Size(0, 13);
            this.lblDstFileName.TabIndex = 3;
            // 
            // lblDst
            // 
            this.lblDst.AutoSize = true;
            this.lblDst.Location = new System.Drawing.Point(10, 122);
            this.lblDst.Name = "lblDst";
            this.lblDst.Size = new System.Drawing.Size(50, 13);
            this.lblDst.TabIndex = 2;
            this.lblDst.Text = "Zieldatei:";
            // 
            // lblSrcFileName
            // 
            this.lblSrcFileName.AutoSize = true;
            this.lblSrcFileName.Location = new System.Drawing.Point(94, 16);
            this.lblSrcFileName.Name = "lblSrcFileName";
            this.lblSrcFileName.Size = new System.Drawing.Size(0, 13);
            this.lblSrcFileName.TabIndex = 1;
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(10, 16);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(57, 13);
            this.lblSrc.TabIndex = 0;
            this.lblSrc.Text = "Quelldatei:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diesesProgrammToolStripMenuItem});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Über";
            // 
            // diesesProgrammToolStripMenuItem
            // 
            this.diesesProgrammToolStripMenuItem.Name = "diesesProgrammToolStripMenuItem";
            this.diesesProgrammToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.diesesProgrammToolStripMenuItem.Text = "Dieses Programm";
            this.diesesProgrammToolStripMenuItem.Click += new System.EventHandler(this.diesesProgrammToolStripMenuItem_Click);
            // 
            // Frm_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 693);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Options";
            this.Text = "PDF-Protect, v0.12 (20190130), D. Marx";
            this.Load += new System.EventHandler(this.Frm_Options_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpProtect.ResumeLayout(false);
            this.grpUserRights.ResumeLayout(false);
            this.grpUserRights.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.grpPass.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpUserRights;
        private System.Windows.Forms.GroupBox grpPass;
        private System.Windows.Forms.TextBox txtOwnerPass;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label lblOwnerPass;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Label lblDstFileName;
        private System.Windows.Forms.Label lblDst;
        private System.Windows.Forms.Label lblSrcFileName;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.CheckBox chkOptAnnotations;
        private System.Windows.Forms.CheckBox chkOptExtractContent;
        private System.Windows.Forms.CheckBox chkOptAssembleDocument;
        private System.Windows.Forms.Button btnSelSrc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkOptPrint;
        private System.Windows.Forms.CheckBox chkOptFormsFill;
        private System.Windows.Forms.Button btnSelDst;
        private System.Windows.Forms.TextBox txtExplainPasswords;
        private System.Windows.Forms.GroupBox grpProtect;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.CheckBox chkDefineOpts;
        private System.Windows.Forms.Label lblWarnSrcDstIdentic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diesesProgrammToolStripMenuItem;
        private System.Windows.Forms.Label lblSrcPass;
        private System.Windows.Forms.TextBox txtSrcPass;
        private System.Windows.Forms.CheckBox chkNeedOpenPwd;
    }
}