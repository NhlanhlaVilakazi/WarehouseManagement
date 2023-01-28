namespace WarehouseManagent.Helpers
{
    public class UserFeedBack
    {
        public void ShowFeedbackAlert(bool success, string obj, string action)
        {
            if (success) MessageBox.Show($"{obj} successfully {action}!");
            else MessageBox.Show("An error occured while processing the rquest, please try again later..");
        }
    }
}
