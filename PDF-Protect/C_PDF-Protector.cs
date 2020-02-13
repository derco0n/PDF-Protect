using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDF_Protect;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Security;
using PdfSharp.Pdf.IO;
using System.IO;

namespace PDF_Protect
{
    class C_PDF_Protector
    {
        private Dictionary<String, Boolean> UserOptions = new Dictionary<string, bool>();

        public delegate void EventHandler(object sender, String msg);
        public event EventHandler OnErrorOccured;
        public event EventHandler OnSuccess;

        private void IntializeUserOptions()
        {
            this.UserOptions.Add("AllowExtract", false);
            this.UserOptions.Add("AllowComments", false);
            this.UserOptions.Add("AllowAssembleDocument", false);
            this.UserOptions.Add("AllowEditFillForms", true);
            this.UserOptions.Add("AllowPrintDocument", true);
        }

        #region Properties

        /// <summary>
        /// Property-UserOption: Inhalte extrahieren
        /// </summary>
        public Boolean Opt_AllowExtract
        {
            get
            {
                return this.UserOptions["AllowExtract"];
            }
            set
            {
                this.UserOptions["AllowExtract"] = value;
            }
        }

        /// <summary>
        /// Property-UserOption: Kommentare
        /// </summary>
        public Boolean Opt_AllowComments
        {
            get
            {
                return this.UserOptions["AllowComments"];
            }
            set
            {
                this.UserOptions["AllowComments"] = value;
            }
        }

        /// <summary>
        /// Property-UserOption: Kommentare
        /// </summary>
        public Boolean Opt_AllowAssembleDocument
        {
            get
            {
                return this.UserOptions["AllowAssembleDocument"];
            }
            set
            {
                this.UserOptions["AllowAssembleDocument"] = value;
            }
        }

        /// <summary>
        /// Property-UserOption: Kommentare
        /// </summary>
        public Boolean Opt_AllowEditFillForms
        {
            get
            {
                return this.UserOptions["AllowEditFillForms"];
            }
            set
            {
                this.UserOptions["AllowEditFillForms"] = value;
            }
        }


        /// <summary>
        /// Property-UserOption: Kommentare
        /// </summary>
        public Boolean Opt_AllowPrintDocument
        {
            get
            {
                return this.UserOptions["AllowPrintDocument"];
            }
            set
            {
                this.UserOptions["AllowPrintDocument"] = value;
            }
        }

        #endregion


        #region constructor
        /// <summary>
        /// Konstruktor
        /// </summary>
        public C_PDF_Protector()
        {
            this.IntializeUserOptions();
        }
        #endregion


        #region Methods
        /// <summary>
        /// Protects a PDF with a password
        /// </summary>
        /// <param name="filenameSource">Sourcefile</param>
        /// <param name="filenameDest">Destinationfile</param>
        /// <param name="openPass">Password needed to open Sourcefile</param>
        /// <param name="userPass">Password for Useraccess in Destinationfile</param>
        /// <param name="ownerPass">Password for Owneraccess in Destinationfile</param>
        public void protectPDF(String filenameSource, String filenameDest, String openPass, String userPass, String ownerPass)
        {

            String openfilename = "";

            if (filenameSource.Equals(filenameDest))
            {//Zieldatei gleich Quelldatei
                openfilename = filenameSource;
            }
            else
            {//Unterschiedliche Ziel und Quelldatei
                // Get a fresh copy of the sample PDF file   - overwrite file if exists
                File.Copy(filenameSource, filenameDest, true);
                openfilename = filenameDest;                
            }


            PdfDocument document = null;
            try
            {
                // Open an existing document. Providing an unrequired password is ignored.
                document = PdfReader.Open(openfilename, openPass);
            }
            catch (Exception ex)
            {
                if (this.OnErrorOccured != null)
                {
                    this.OnErrorOccured(this, "Fehler beim Öffnen der Quelldatei (" + openfilename + "):\r\nIst diese bereits Kennwortgeschützt und das zum Öffnen erforderliche Kennwort nicht oder inkorrekt angegeben?");
                }
                return;
            }


            PdfSecuritySettings securitySettings = document.SecuritySettings;

            // Setting one of the passwords automatically sets the security level to 
            // PdfDocumentSecurityLevel.Encrypted128Bit.
            securitySettings.UserPassword = userPass;
            securitySettings.OwnerPassword = ownerPass;

            // Don't use 40 bit encryption unless needed for compatibility
            //securitySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;

            // Restrict some user rights.
            securitySettings.PermitAccessibilityExtractContent = this.UserOptions["AllowExtract"];
            securitySettings.PermitAnnotations = this.UserOptions["AllowComments"];
            securitySettings.PermitAssembleDocument = this.UserOptions["AllowAssembleDocument"];
            securitySettings.PermitExtractContent = this.UserOptions["AllowExtract"];
            securitySettings.PermitFormsFill = this.UserOptions["AllowEditFillForms"];
            securitySettings.PermitFullQualityPrint = false;
            securitySettings.PermitModifyDocument = this.UserOptions["AllowEditFillForms"];
            securitySettings.PermitPrint = this.UserOptions["AllowPrintDocument"];
            /*
            securitySettings.PermitAccessibilityExtractContent = false;
            securitySettings.PermitAnnotations = false;
            securitySettings.PermitAssembleDocument = false;
            securitySettings.PermitExtractContent = false;
            securitySettings.PermitFormsFill = true;
            securitySettings.PermitFullQualityPrint = false;
            securitySettings.PermitModifyDocument = true;
            securitySettings.PermitPrint = false;
            */

            // Save the document...
            document.Save(filenameDest);
            document.Close();

            if (this.OnSuccess != null)
            {                
                this.OnSuccess(this, "Die Datei \"" + openfilename + "\" wurde erfolgreich mit einem Kennwortschutz versehen.");
            }
            // ...and start a viewer.
            // Process.Start(filenameDest);

        }
        #endregion
    }
}
