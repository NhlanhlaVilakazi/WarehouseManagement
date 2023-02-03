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

        public Bitmap? LoadSelectedImage(PictureBox pictureBox)
        {
            OpenFileDialog imageDialog = new();
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                bitMap = new Bitmap(imageDialog.FileName);
                pictureBox.Image = bitMap;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return bitMap;
        }
    }
}
