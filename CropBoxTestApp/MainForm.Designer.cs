namespace CropBox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseForImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveThumbnailImageButton = new System.Windows.Forms.Button();
            this.SaveCroppedImageButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cropBox1 = new System.Windows.Forms.CropBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrowseForImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 62);
            this.panel1.TabIndex = 2;
            // 
            // BrowseForImageButton
            // 
            this.BrowseForImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseForImageButton.Location = new System.Drawing.Point(28, 13);
            this.BrowseForImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseForImageButton.Name = "BrowseForImageButton";
            this.BrowseForImageButton.Size = new System.Drawing.Size(169, 28);
            this.BrowseForImageButton.TabIndex = 1;
            this.BrowseForImageButton.Text = "Browse for image";
            this.BrowseForImageButton.UseVisualStyleBackColor = true;
            this.BrowseForImageButton.Click += new System.EventHandler(this.BrowseForImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.Filter = "JPEG files|*.jpg";
            this.openFileDialog1.Title = "Please select image file";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveThumbnailImageButton);
            this.panel2.Controls.Add(this.SaveCroppedImageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 62);
            this.panel2.TabIndex = 3;
            // 
            // SaveThumbnailImageButton
            // 
            this.SaveThumbnailImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveThumbnailImageButton.Location = new System.Drawing.Point(219, 18);
            this.SaveThumbnailImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveThumbnailImageButton.Name = "SaveThumbnailImageButton";
            this.SaveThumbnailImageButton.Size = new System.Drawing.Size(169, 28);
            this.SaveThumbnailImageButton.TabIndex = 3;
            this.SaveThumbnailImageButton.Text = "Save thumbnail image";
            this.SaveThumbnailImageButton.UseVisualStyleBackColor = true;
            this.SaveThumbnailImageButton.Click += new System.EventHandler(this.SaveThumbnailImageButton_Click);
            // 
            // SaveCroppedImageButton
            // 
            this.SaveCroppedImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCroppedImageButton.Location = new System.Drawing.Point(28, 18);
            this.SaveCroppedImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveCroppedImageButton.Name = "SaveCroppedImageButton";
            this.SaveCroppedImageButton.Size = new System.Drawing.Size(169, 28);
            this.SaveCroppedImageButton.TabIndex = 2;
            this.SaveCroppedImageButton.Text = "Save cropped image";
            this.SaveCroppedImageButton.UseVisualStyleBackColor = true;
            this.SaveCroppedImageButton.Click += new System.EventHandler(this.SaveCroppedImageButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.Filter = "JPEG files|*.jpg";
            this.saveFileDialog1.Title = "Please enter file name to save the file";
            // 
            // cropBox1
            // 
            this.cropBox1.BackColor = System.Drawing.Color.White;
            this.cropBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cropBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cropBox1.Location = new System.Drawing.Point(0, 62);
            this.cropBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cropBox1.Name = "cropBox1";
            this.cropBox1.OverlayAlpha = 150;
            this.cropBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cropBox1.Selection = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cropBox1.SelectionBorderDashPattern = null;
            this.cropBox1.SelectionInitialMode = System.Windows.Forms.CropBox.CropBoxSelectionInitialMode.Square;
            this.cropBox1.Size = new System.Drawing.Size(783, 430);
            this.cropBox1.TabIndex = 0;
            this.cropBox1.SetInitialSelection += new System.Windows.Forms.CropBox.SetInitialSelectionDelegate(this.CropBox1_SetInitialSelection);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 554);
            this.Controls.Add(this.cropBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CropBox";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CropBox cropBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseForImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveThumbnailImageButton;
        private System.Windows.Forms.Button SaveCroppedImageButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

