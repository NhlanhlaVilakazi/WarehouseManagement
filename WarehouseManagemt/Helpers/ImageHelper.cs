namespace WarehouseManagent.Helpers
{
    public class ImageHelper
    {
        private Bitmap? bitMap;
        private ImageConverter converter;
        public ImageHelper()
        {
            converter = new();
        }
        public byte[] ImageToByte(Image? image)
        {
            
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        public Image BytesToImage(byte[] byteImage)
        {
            return (Image)converter.ConvertFrom(byteImage);
        }

        public static bool IsValidImage(string fileName)
        {
            string[] imageExtensions = { "png", "jpg", "jpeg", "gif, ico" };
            string extension = fileName.Substring(fileName.LastIndexOf(".") + 1);
            return imageExtensions.Any(x => x.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

        public Bitmap? LoadSelectedImage(PictureBox pictureBox, Label pictureErrorMsg)
        {
            OpenFileDialog imageDialog = new();
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                if (IsValidImage(imageDialog.FileName))
                {
                    pictureErrorMsg.Visible = false;
                    bitMap = new Bitmap(imageDialog.FileName);
                    pictureBox.Image = bitMap;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureErrorMsg.Text = "Supported image types [png, jpg, jpeg, gif, ico]";
                    pictureErrorMsg.Visible = true;
                }
            }
            return bitMap;
        }
    }
}
