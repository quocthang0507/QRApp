using QRCoder;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QRApp
{
	public partial class Form1 : Form
	{
		QRCodeGenerator qrGenerator;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			new Thread(() =>
		   {
			   qrGenerator = new QRCodeGenerator();
			   QRCodeData qrCodeData = qrGenerator.CreateQrCode(tbxContent.Text, QRCodeGenerator.ECCLevel.Q);
			   QRCode qrCode = new QRCode(qrCodeData);
			   Bitmap qrCodeImage = qrCode.GetGraphic(20);
			   pbx_Preview.Image = qrCodeImage;
		   }).Start();
		}
	}
}
