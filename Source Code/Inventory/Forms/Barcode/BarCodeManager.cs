using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Text;
using Inventory.Utils.Barcode;
using Inventory.DataModels.Barcode;
using Inventory.DataModels;
using Inventory.Utils;
using Toolkit;


namespace Inventory.Forms
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class BarCodeManager: System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btGenerate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtBarcodeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBarcodeImage;
		private System.Windows.Forms.CheckBox ckbShowID;
        private Button btnClose;
        private Button btnPrint;
        private Button btnSave;
        private DevExpress.XtraEditors.MemoEdit meDesc;
        private CheckBox ckbViewState;
        private Bitmap bmp = null;

        //Barcode Model
        private BarcodeModel model = new BarcodeModel();
        private DevExpress.XtraEditors.DateEdit datCreationDate;
        private Label label5;
        private Label label4;
        private CheckBox ckbShowLabel;

        /// <summary>
        /// Get/set BarcodeModel 
        /// </summary>
        public BarcodeModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BarCodeManager()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbShowLabel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datCreationDate = new DevExpress.XtraEditors.DateEdit();
            this.meDesc = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbViewState = new System.Windows.Forms.CheckBox();
            this.ckbShowID = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBarcodeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBarcodeImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datCreationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDesc.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(488, 28);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(84, 27);
            this.btGenerate.TabIndex = 9;
            this.btGenerate.Text = "Generate";
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbShowLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datCreationDate);
            this.groupBox1.Controls.Add(this.meDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ckbViewState);
            this.groupBox1.Controls.Add(this.ckbShowID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtBarcodeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode Parameters";
            // 
            // ckbShowLabel
            // 
            this.ckbShowLabel.Checked = true;
            this.ckbShowLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowLabel.Location = new System.Drawing.Point(163, 240);
            this.ckbShowLabel.Name = "ckbShowLabel";
            this.ckbShowLabel.Size = new System.Drawing.Size(128, 28);
            this.ckbShowLabel.TabIndex = 7;
            this.ckbShowLabel.Text = "Show Barcode Label";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Creation Date :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datCreationDate
            // 
            this.datCreationDate.EditValue = new System.DateTime(2007, 6, 4, 0, 0, 0, 0);
            this.datCreationDate.Location = new System.Drawing.Point(92, 182);
            this.datCreationDate.Name = "datCreationDate";
            this.datCreationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datCreationDate.Size = new System.Drawing.Size(131, 23);
            this.datCreationDate.TabIndex = 5;
            // 
            // meDesc
            // 
            this.meDesc.Location = new System.Drawing.Point(92, 95);
            this.meDesc.Name = "meDesc";
            this.meDesc.Size = new System.Drawing.Size(336, 78);
            this.meDesc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Description :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbViewState
            // 
            this.ckbViewState.Checked = true;
            this.ckbViewState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbViewState.Location = new System.Drawing.Point(339, 240);
            this.ckbViewState.Name = "ckbViewState";
            this.ckbViewState.Size = new System.Drawing.Size(90, 28);
            this.ckbViewState.TabIndex = 8;
            this.ckbViewState.Text = "View Status";
            this.ckbViewState.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbShowID
            // 
            this.ckbShowID.Checked = true;
            this.ckbShowID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowID.Location = new System.Drawing.Point(13, 240);
            this.ckbShowID.Name = "ckbShowID";
            this.ckbShowID.Size = new System.Drawing.Size(116, 28);
            this.ckbShowID.TabIndex = 6;
            this.ckbShowID.Text = "Show Barcode ID";
            this.ckbShowID.CheckedChanged += new System.EventHandler(this.chkBoxShowBarcode_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(322, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Barcode Size :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Location = new System.Drawing.Point(404, 65);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(24, 22);
            this.txtSize.TabIndex = 3;
            this.txtSize.Text = "30";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(93, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(336, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtBarcodeID
            // 
            this.txtBarcodeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcodeID.Location = new System.Drawing.Point(93, 65);
            this.txtBarcodeID.Name = "txtBarcodeID";
            this.txtBarcodeID.Size = new System.Drawing.Size(176, 22);
            this.txtBarcodeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Label :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Barcode ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBarcodeImage);
            this.groupBox2.Location = new System.Drawing.Point(8, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Barcode Image";
            // 
            // picBarcodeImage
            // 
            this.picBarcodeImage.Location = new System.Drawing.Point(16, 28);
            this.picBarcodeImage.Name = "picBarcodeImage";
            this.picBarcodeImage.Size = new System.Drawing.Size(536, 120);
            this.picBarcodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBarcodeImage.TabIndex = 1;
            this.picBarcodeImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(488, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(488, 248);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 28);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print Barcode";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BarCodeManager
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.ClientSize = new System.Drawing.Size(584, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarCodeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barcode Manager";
            this.Load += new System.EventHandler(this.BarCodeManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datCreationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDesc.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcodeImage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void btGenerate_Click(object sender, System.EventArgs e)
		{
			GenerateBarCode();
            this.btnSave.Enabled = true;
            this.txtBarcodeID.Text = this.model.BarcodeId;
		}

		private void GenerateBarCode()
		{
            BarcodeGenerator objBarCodeGen = new BarcodeGenerator();

            ReadToDataModel();
			//int barSize=System.Convert.ToInt32(txtSize.Text);

            this.model.BarcodeInfo = objBarCodeGen.GetCode39Bytes(this.model);
            
            //Create Memory Stream of BarCode
            MemoryStream msMemStream = new MemoryStream(this.model.BarcodeInfo);
            bmp = new Bitmap(msMemStream);
            picBarcodeImage.Image = new Bitmap(msMemStream);
		}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Create an instance of PrintDocument
            System.Drawing.Printing.PrintDocument objPrintDoc = new System.Drawing.Printing.PrintDocument();

            // Set the printer name
            //printdoc.PrinterSettings.PrinterName = this.ddlPrinters.Text;

            // Handle printing
            objPrintDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printdoc_PrintPage);

            // Print
            PrintDialog dlg = new PrintDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                objPrintDoc.PrinterSettings = dlg.PrinterSettings;
                objPrintDoc.Print();
            }
        }

        private void printdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Image image = Image.FromStream(this.PrintStream);
            Image image = (Image)picBarcodeImage.Image;
            System.Drawing.Printing.PrintDocument objPrintDoc = (System.Drawing.Printing.PrintDocument)sender;
            int iPageWidth = objPrintDoc.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            int iPageHeight = objPrintDoc.PrinterSettings.DefaultPageSettings.PaperSize.Height;
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            int currentX = 0;
            int currentY = 0;
            //if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            //{
            //    width = e.MarginBounds.Width;
            //    height = image.Height * e.MarginBounds.Width / image.Width;
            //}
            //else
            //{
            //    height = e.MarginBounds.Height;
            //    width = image.Width * e.MarginBounds.Height / image.Height;
            //}
            Rectangle destrect = new Rectangle(x, y, iPageWidth, iPageHeight);
            
            while ((currentY < iPageHeight))
            {
                //Rectangle destrect = new Rectangle(currentX, currentY, width, height);
//                e.Graphics.DrawImage(image, destrect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
                e.Graphics.DrawImage(image, destrect, currentX, currentY, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
                currentX += image.Width;
                currentY += image.Height;
                if (currentX > iPageWidth)
                {
                    currentX = 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;            
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        private void ReadToDataModel()
        {
            model.BarcodeId = this.txtBarcodeID.Text;
            if (string.IsNullOrEmpty(model.BarcodeId))
            {
                model.BarcodeId = Utils.Barcode.BarcodeGenerator.GenerateAutoBarcodeID();
            }
            model.CreationDate = DateUtils.ParseDate(this.datCreationDate.Text);
            model.ViewStatus = this.ckbViewState.Checked;
            model.ViewBarcodeID = ckbShowID.Checked;
            model.ViewBarcodeLabel = ckbShowLabel.Checked;
            model.Label = this.txtTitle.Text;
            model.Size = Convert.ToInt32(this.txtSize.Text);
            model.Description = this.meDesc.Text;
            
        }

        private bool Validate()
        {
            //TODO:Add more code to validate
            if (txtTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Field Label empty");
                txtTitle.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Label FROM BarcodeMaster WHERE Label = '" + txtTitle.Text.Trim() + "' AND ID <> '" + this.DataModel.BarcodeId + "'"))
            {
                MessageBox.Show("This Label is already available, please select another one");
                txtTitle.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }

        private void chkBoxShowBarcode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void BindData(BarcodeModel objModel,string strAction)
        {
            if (objModel == null)
            {
                model = new BarcodeModel();
            }
            else
            {
                model = objModel;
            }
            this.txtBarcodeID.ReadOnly = true;
            switch (strAction)
            {
                case "ADD":
                    this.Text = "Add Barcode";
                    this.btGenerate.Visible = true;
                    this.btnSave.Enabled = false;
                    break;
                case "EDIT":
                    this.Text = "Edit Barcode";
                    this.btGenerate.Visible = false;
                    this.btnSave.Enabled = true; ;
                    break;
            }
            if (!string.IsNullOrEmpty(model.BarcodeId))
            {
                this.txtBarcodeID.Text = model.BarcodeId;

                this.txtTitle.Text = model.Label;
                this.meDesc.Text = model.Description;
                this.datCreationDate.Text = model.CreationDate.ToShortDateString();
                this.txtSize.Text = model.Size.ToString();
                this.ckbViewState.Checked = model.ViewStatus;
                this.ckbShowID.Checked = model.ViewBarcodeID;
                this.ckbShowLabel.Checked = model.ViewBarcodeLabel;
            
            
                BarcodeGenerator objBarCodeGen = new BarcodeGenerator();
                this.model.BarcodeInfo = objBarCodeGen.GetCode39Bytes(model);

                //Create Memory Stream of BarCode
                MemoryStream msMemStream = new MemoryStream(this.model.BarcodeInfo);
                bmp = new Bitmap(msMemStream);
                picBarcodeImage.Image = new Bitmap(msMemStream);
            }
        }

        private void BarCodeManager_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }
    }
}
