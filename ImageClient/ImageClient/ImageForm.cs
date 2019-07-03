using ImageService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace ImageClient
{
    public partial class ImageForm : Form
    {
        private static readonly ImageHandlerServiceClient _imageHandler = new ImageHandlerServiceClient();

        public ImageForm()
        {
            InitializeComponent();
            FillListView();
        }
        
        private void UploadImage_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog() { Title = "Select image", Filter = ConfigurationManager.AppSettings["ImageFilterValue"] };

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            using (var file = new FileStream(fileDialog.FileName, FileMode.Open))
            {
                var imageContent = new byte[file.Length];
                file.Read(imageContent, 0, imageContent.Length);
                SaveImage(fileDialog.SafeFileName, imageContent);
            }
        }

        private void GetImagesButton_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void ImageListView_ItemActivate(object sender, EventArgs e)
        {
            var item = ImageListView.SelectedItems[0].Text;
            var image = _imageHandler.GetImage(item);

            if (image != null)
                new ImageBoxForm(image).Show();
            else
                MessageBox.Show("Image not found", "Error");
        }

        private void FillListView()
        {
            var images = GetImages();

            if (images != null)
            {
                if (ImageListView.Items.Count > 0)
                    ImageListView.Items.Clear();

                ImageListView.Items.AddRange(images.Select(i => new ListViewItem(i)).ToArray());
            }
        }

        private IEnumerable<string> GetImages()
        {
            try
            {
                var images = _imageHandler.GetImageNames();

                if (!UploadImage.Enabled)
                    UploadImage.Enabled = true;

                return images;
            }
            catch (EndpointNotFoundException ex)
            {
                UploadImage.Enabled = false;
                MessageBox.Show("Server is down!", "Error");
                return null;
            }
            catch (Exception ex)
            {
                UploadImage.Enabled = false;
                MessageBox.Show("Something went wrong!", "Error");
                return null;
            }
        }

        private void SaveImage(string name, byte[] imageContent)
        {
            try
            {
                _imageHandler.SaveImage(new FileModel { Name = name, Content = imageContent });
                ImageListView.Items.Add(new ListViewItem(name));
            }
            catch(FaultException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
