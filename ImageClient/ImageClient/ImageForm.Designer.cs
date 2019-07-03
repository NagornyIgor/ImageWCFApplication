namespace ImageClient
{
    partial class ImageForm
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
            this.UploadImage = new System.Windows.Forms.Button();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.ImageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetImagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UploadImage
            // 
            this.UploadImage.Location = new System.Drawing.Point(297, 326);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(75, 23);
            this.UploadImage.TabIndex = 0;
            this.UploadImage.Text = "Upload";
            this.UploadImage.UseVisualStyleBackColor = false;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // ImageListView
            // 
            this.ImageListView.BackColor = System.Drawing.SystemColors.Window;
            this.ImageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageName});
            this.ImageListView.GridLines = true;
            this.ImageListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ImageListView.Location = new System.Drawing.Point(12, 12);
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(360, 308);
            this.ImageListView.TabIndex = 1;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            this.ImageListView.View = System.Windows.Forms.View.Details;
            this.ImageListView.ItemActivate += new System.EventHandler(this.ImageListView_ItemActivate);
            // 
            // ImageName
            // 
            this.ImageName.Text = "Image names";
            this.ImageName.Width = 361;
            // 
            // GetImagesButton
            // 
            this.GetImagesButton.Location = new System.Drawing.Point(216, 326);
            this.GetImagesButton.Name = "GetImagesButton";
            this.GetImagesButton.Size = new System.Drawing.Size(75, 23);
            this.GetImagesButton.TabIndex = 2;
            this.GetImagesButton.Text = "Get images";
            this.GetImagesButton.UseVisualStyleBackColor = false;
            this.GetImagesButton.Click += new System.EventHandler(this.GetImagesButton_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.GetImagesButton);
            this.Controls.Add(this.ImageListView);
            this.Controls.Add(this.UploadImage);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.Button GetImagesButton;
        private System.Windows.Forms.ColumnHeader ImageName;
        private System.Windows.Forms.ListView ImageListView;
    }
}

