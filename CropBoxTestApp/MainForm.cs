using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CropBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseForImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                cropBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void SaveCroppedImageButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "CroppedImage.jpg";

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Image croppedImage = cropBox1.GetCroppedImage();
                croppedImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);

                Process.Start(saveFileDialog1.FileName);
            }
        }

        private void SaveThumbnailImageButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "CroppedImageThumbnail.jpg";

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Image croppedImage = cropBox1.GetCroppedImageThumbnail();
                croppedImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);

                Process.Start(saveFileDialog1.FileName);
            }
        }

        private void CropBox1_SetInitialSelection(object sender, CropBoxInitialSelectionEventArgs args)
        {
            if (cropBox1.SelectionInitialMode != System.Windows.Forms.CropBox.CropBoxSelectionInitialMode.Custom)
                return;

            Rectangle selection = new Rectangle((int)(0.1 * args.Image.Width),
                                                (int)(0.1 * args.Image.Height),
                                                (int)(0.4 * args.Image.Width),
                                                (int)(0.3 * args.Image.Height));

            args.Selection = selection;
        }
    }
}
