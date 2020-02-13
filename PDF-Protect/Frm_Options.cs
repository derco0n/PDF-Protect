using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDF_Protect
{
    public partial class Frm_Options : Form
    {
        public Frm_Options()
        {
            InitializeComponent();
        }

        private const string FileFilter = "PDF-Datei(*.pdf)|*.pdf";

        private String SrcFile, DstFile;

        #region Eventhandlers

        private void HandleInnerErrorOccured(object sender, String msg)
        {
            MessageBox.Show(msg, "Fehler:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleSuccess(object sender, String msg)
        {
            MessageBox.Show(msg, "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
        
        #endregion

        private void chkDefineOpts_CheckedChanged(object sender, EventArgs e)
        {
            this.grpUserRights.Visible = this.chkDefineOpts.Checked;
            this.grpUserRights.Enabled = this.chkDefineOpts.Checked;
        }

        private void chkOptExtractContent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSelSrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog of1 = new OpenFileDialog();
            of1.Filter = FileFilter;
            if (this.SrcFile!= null && this.SrcFile != "")
            {
                of1.FileName = this.SrcFile;
            }

            of1.ShowDialog();

            if (File.Exists(of1.FileName))
            {
                FileInfo finfo = new FileInfo(of1.FileName);

                //String newFilename = finfo.FullName.Substring(0, finfo.FullName.IndexOf(finfo.Extension)) + "_protected" + finfo.Extension;

                this.setSrcFile(finfo.FullName);
                //this.SrcFile = finfo.FullName;
                this.setDstFile(finfo.FullName);
                //this.setDstFile(newFilename);
                //this.DstFile = newFilename;

                //this.protectPDF(of1.FileName, newFilename, "openpass", "userpass", "ownerpass");
            }
            of1.Dispose();
        }

        private void setSrcFile(String filename)
        {
            this.SrcFile = filename;
            this.lblSrcFileName.Text = filename;
        }

        /// <summary>
        /// Setzte die Quelldatei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelDst_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf1 = new SaveFileDialog();
            sf1.Filter = FileFilter;
            if (this.DstFile!=null && this.SrcFile != "")
            {
                sf1.FileName = this.DstFile;
            }
            sf1.ShowDialog();
            this.setDstFile(sf1.FileName);
        }

        private void Frm_Options_Load(object sender, EventArgs e)
        {
            //Disable User-Right-Details on Start
            this.chkDefineOpts.Checked = false; //Will raise event oncheckchanged

            //Disable Source-Password on Start
            this.chkNeedOpenPwd.Checked = false; //Will raise event oncheckchanged
        }

        private void btnProtect_Click(object sender, EventArgs e)
        {

            //Etwas Fehlerbehandlung....
            if (this.SrcFile==null || this.SrcFile.Equals(""))
            {
                MessageBox.Show("Es wurde keine Quelldatei angeben...", "Quelldatei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.DstFile == null || this.DstFile.Equals(""))
            {
                MessageBox.Show("Es wurde keine Zieldatei angeben...", "Zieldatei fehlt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!File.Exists(this.SrcFile))
            {
                MessageBox.Show("Die angegebene Quelldatei ("+this.SrcFile+") existiert nicht oder der Zugriff wurde verweigert.", "Quelldatei nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.txtOwnerPass.Text==null || this.txtOwnerPass.Text.Equals(""))
            {
                MessageBox.Show("Es wurde kein Besitzerkennwort angegeben:\r\n\r\nBitte mindestens ein Besitzerpasswort angeben...", "Fehlendes Kennwort", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {

                //Passwortschutz aktivieren
                C_PDF_Protector PDF_Protector = new C_PDF_Protector();

                //Handle ErrorEvent(s) from PDF-Protector
                PDF_Protector.OnErrorOccured += this.HandleInnerErrorOccured;

                //Handle SuccessEvent(s) from PDF-Protector
                PDF_Protector.OnSuccess += this.HandleSuccess;



                PDF_Protector.Opt_AllowAssembleDocument = chkOptAssembleDocument.Checked;
                PDF_Protector.Opt_AllowComments = chkOptAnnotations.Checked;
                PDF_Protector.Opt_AllowEditFillForms = chkOptFormsFill.Checked;
                PDF_Protector.Opt_AllowExtract = chkOptExtractContent.Checked;
                PDF_Protector.Opt_AllowPrintDocument = chkOptPrint.Checked;

                String openpassword = "";
                if (this.chkNeedOpenPwd.Checked)
                {
                    openpassword = this.txtSrcPass.Text;
                }

                try
                {
                    PDF_Protector.protectPDF(this.SrcFile/*Quelldatei*/, this.DstFile/*Zieldatei*/, openpassword/*Optionales Kennwort zum Öffnen der Quelldatei*/, this.txtUserPass.Text/*Benutzerkennwort für Zieldatei*/, this.txtOwnerPass.Text/*Besitzerkennwort für Zieldatei*/);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Setzen des Kennwortschutzes:\r\n" + ex.ToString() + "\r\n\r\n" + ex.StackTrace, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void diesesProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dieses Programm dient dem Passwortschutz von PDF-Dateien.\r\nEntwicklung: D. Marx (https://github.com/derco0n/)");
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkNeedOpenPwd_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSrcPass.Visible = this.chkNeedOpenPwd.Checked;
            this.lblSrcPass.Visible = this.chkNeedOpenPwd.Checked;
            this.txtSrcPass.Enabled = this.chkNeedOpenPwd.Checked;
            this.lblSrcPass.Enabled = this.chkNeedOpenPwd.Checked;
        }

        /// <summary>
        /// Setzt die Zieldatei
        /// </summary>
        /// <param name="filename"></param>
        private void setDstFile(String filename)
        {
            this.DstFile = filename;
            this.lblDstFileName.Text = filename;

            //Wenn Quell- und Zieldatei identisch sind: Warnung ausgeben.
            if (this.SrcFile.Equals(this.DstFile))
            {
                this.lblWarnSrcDstIdentic.Visible = true;
            }
            else
            {
                this.lblWarnSrcDstIdentic.Visible = false;
            }
        }
    }
}
