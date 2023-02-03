namespace WarehouseManagent.Helpers
{
    public class ValidationsHelper
    {
        public static void HandleIntegerInputs(TextBox textBox, Label label)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label.Text = "Please input a number";
                label.Visible = true;
            }
            else
                label.Visible = false;
        }

        public static bool IsImageSelected(PictureBox pictureBox, Label label)
        {
            bool isValid = false;
            if (pictureBox.Image is null)
                label.Visible = true;
            else
            {
                isValid = true;
                label.Visible = false;
            }
            return isValid;
        }

        public static bool IsValueProvided(string value, Label label)
        { 
            bool isValid = false;
            if (string.IsNullOrEmpty(value))  
                label.Visible = true;
            else
            {
                isValid = true;
                label.Visible = false;
            }
            return isValid;
        }

        public static void BlockStringInput(KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
        }

    }
}
