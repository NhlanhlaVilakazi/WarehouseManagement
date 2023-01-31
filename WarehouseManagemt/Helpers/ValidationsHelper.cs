using Microsoft.IdentityModel.Tokens;

namespace WarehouseManagent.Helpers
{
    public class ValidationsHelper
    {
        public void HandleIntegerInputs(TextBox textBox, Label label)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label.Text = "Please input a number";
                label.Visible = true;
            }
            else
                label.Visible = false;
        }

        public bool IsTextboxNotNull(TextBox textBox, Label label)
        { 
            bool isValid = false;
            if (string.IsNullOrEmpty(textBox.Text))  
                label.Visible = true;
            else
            {
                isValid = true;
                label.Visible = false;
            }
            return isValid;
        }

        public bool IsDropdownValueSelected(ComboBox comboBox, Label label)
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(comboBox.Text))
                label.Visible = true;
            else
            {
                isValid = true;
                label.Visible = false;
            }
            return isValid;
        }

        public void BlockStringInput(KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar);
        }
    }
}
