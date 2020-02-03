namespace QRApp
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTransfer = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pbxPreview = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.tbxContent_First = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbxContent_After = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDecode = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.savePicture = new System.Windows.Forms.SaveFileDialog();
			this.openPicture = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 519F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTransfer);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.pbxPreview);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnGenerate);
			this.groupBox1.Controls.Add(this.tbxContent_First);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 493);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "QR Code Generator";
			// 
			// btnTransfer
			// 
			this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTransfer.Location = new System.Drawing.Point(269, 145);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Size = new System.Drawing.Size(75, 23);
			this.btnTransfer.TabIndex = 4;
			this.btnTransfer.Text = ">>";
			this.btnTransfer.UseVisualStyleBackColor = true;
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSave.Location = new System.Drawing.Point(188, 145);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save as...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pbxPreview
			// 
			this.pbxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxPreview.BackColor = System.Drawing.Color.White;
			this.pbxPreview.Location = new System.Drawing.Point(83, 178);
			this.pbxPreview.Name = "pbxPreview";
			this.pbxPreview.Size = new System.Drawing.Size(300, 300);
			this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxPreview.TabIndex = 4;
			this.pbxPreview.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Preview:";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGenerate.Location = new System.Drawing.Point(107, 145);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// tbxContent_First
			// 
			this.tbxContent_First.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxContent_First.Location = new System.Drawing.Point(83, 39);
			this.tbxContent_First.Multiline = true;
			this.tbxContent_First.Name = "tbxContent_First";
			this.tbxContent_First.Size = new System.Drawing.Size(300, 100);
			this.tbxContent_First.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Content:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbxContent_After);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnDecode);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.pbxImage);
			this.groupBox2.Controls.Add(this.btnBrowse);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(469, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(451, 493);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "QR Code Reader";
			// 
			// tbxContent_After
			// 
			this.tbxContent_After.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxContent_After.Location = new System.Drawing.Point(85, 363);
			this.tbxContent_After.Multiline = true;
			this.tbxContent_After.Name = "tbxContent_After";
			this.tbxContent_After.ReadOnly = true;
			this.tbxContent_After.Size = new System.Drawing.Size(300, 100);
			this.tbxContent_After.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 363);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Content:";
			// 
			// btnDecode
			// 
			this.btnDecode.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDecode.Location = new System.Drawing.Point(220, 28);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.Size = new System.Drawing.Size(75, 23);
			this.btnDecode.TabIndex = 6;
			this.btnDecode.Text = "Decode";
			this.btnDecode.UseVisualStyleBackColor = true;
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Image:";
			// 
			// pbxImage
			// 
			this.pbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxImage.BackColor = System.Drawing.Color.White;
			this.pbxImage.Location = new System.Drawing.Point(85, 57);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(300, 300);
			this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxImage.TabIndex = 5;
			this.pbxImage.TabStop = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBrowse.Location = new System.Drawing.Point(139, 28);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 5;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// savePicture
			// 
			this.savePicture.FileName = "qrImage";
			this.savePicture.Filter = "JPEG Files|*.jpg|PNG Files|*.png|BMP Files|*.bmp";
			this.savePicture.FilterIndex = 2;
			this.savePicture.RestoreDirectory = true;
			this.savePicture.Title = "Save this QR code";
			// 
			// openPicture
			// 
			this.openPicture.Filter = "JPEG Files|*.jpg|PNG Files|*.png|BMP Files|*.bmp";
			this.openPicture.FilterIndex = 2;
			this.openPicture.RestoreDirectory = true;
			this.openPicture.Title = "Select a QR Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 519);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.Name = "Form1";
			this.Text = "QR Code Generator and Reader";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbxContent_First;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.PictureBox pbxPreview;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.SaveFileDialog savePicture;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.OpenFileDialog openPicture;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbxImage;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.TextBox tbxContent_After;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnTransfer;
	}
}

