namespace WarehouseManagent.Helpers
{
    public class UserFeedBack
    {
        public DialogResult ShowFeedbackAlert(bool success, string obj, string action)
        {
            if (success) 
               return MessageBox.Show($"{obj} successfully {action}!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else 
                return MessageBox.Show("An error occured while processing the rquest, please try again later..");
        }
    }
}
