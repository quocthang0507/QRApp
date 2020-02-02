using Bytescout.BarCodeReader;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace QRApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(tbxContent_First.Text, QRCodeGenerator.ECCLevel.Q);
			QRCode qrCode = new QRCode(qrCodeData);
			Bitmap qrCodeImage = qrCode.GetGraphic(20);
			pbxPreview.Image = qrCodeImage;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (pbxPreview.Image != null)
			{
				DialogResult result = savePicture.ShowDialog();
				if (result == DialogResult.OK)
				{
					string path = savePicture.FileName;
					switch (savePicture.FilterIndex)
					{
						case 1:
							pbxPreview.Image.Save(path, ImageFormat.Jpeg);
							break;
						case 2:
							pbxPreview.Image.Save(path, ImageFormat.Png);
							break;
						case 3:
							pbxPreview.Image.Save(path, ImageFormat.Bmp);
							break;
						default:
							pbxPreview.Image.Save(path);
							break;
					}
				}
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			DialogResult result = openPicture.ShowDialog();
			if (result == DialogResult.OK)
			{
				string path = openPicture.FileName;
				pbxImage.ImageLocation = path;
			}
		}

		private void btnDecode_Click(object sender, EventArgs e)
		{
			if (pbxImage.Image != null)
			{
				Reader reader = new Reader();
				reader.RegistrationName = "demo";
				reader.RegistrationKey = "demo";
				reader.BarcodeTypesToFind.QRCode = true;
				FoundBarcode[] barcodes = reader.ReadFrom((Bitmap)pbxImage.Image);
				tbxContent_After.Text = barcodes[0].Value;
			}
		}

		private void btnTransfer_Click(object sender, EventArgs e)
		{
			if (pbxPreview.Image != null)
				pbxImage.Image = pbxPreview.Image;
		}
	}
}
