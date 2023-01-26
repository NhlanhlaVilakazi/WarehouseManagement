namespace WarehouseManagent.Helpers
{
    public class PictureConvertor
    {
        public byte[] ImageToByte(Bitmap imgage)
        {
            ImageConverter converter = new();
            return (byte[])converter.ConvertTo(imgage, typeof(byte[]));
        }
    }
}
