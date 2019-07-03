using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageClient
{
    public partial class ImageBoxForm : Form
    {
        public ImageBoxForm(byte[] image)
        {
            InitializeComponent();

            using (var stream = new MemoryStream(image))
                ImageBox.Image = Image.FromStream(stream);
        }
    }
}
