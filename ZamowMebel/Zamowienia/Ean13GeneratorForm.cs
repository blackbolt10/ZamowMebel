using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarcodeLib;
using BusinessRefinery.Barcode;

namespace ZamowMebel.Zamowienia
{
    public partial class Ean13GeneratorForm : Form
    {
        public Ean13GeneratorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generuj();
            generuj2();
        }


        private void generuj()
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 300,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
            };

            Image img = barcode.Encode(TYPE.EAN13, textBox1.Text);

            pictureBox1.Image = img;
        }


        private void generuj2()
        {
            QRCode barcode = new QRCode();
            barcode.Code = "EAN13";
            barcode.Resolution = 104;
            barcode.Rotate = Rotate.Rotate180;
            barcode.Format = ImageFormat.Gif;

            Image img = barcode.drawBarcodeOnBitmap();
            //barcode.drawBarcode2ImageFile("c:/qr-code-csharp.gif")

            pictureBox1.Image = img;
        }
    }
}
