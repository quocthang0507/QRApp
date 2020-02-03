using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ZXing;

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
				var reader = new BarcodeReader();
				var result = reader.Decode(new Bitmap(pbxImage.Image));
				if (result != null)
				{
					tbxContent_After.Text = result.Text;
				}
			}
		}

		private void btnTransfer_Click(object sender, EventArgs e)
		{
			if (pbxPreview.Image != null)
				pbxImage.Image = pbxPreview.Image;
		}
	}
}
