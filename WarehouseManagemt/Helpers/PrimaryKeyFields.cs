namespace WarehouseManagent.Helpers
{
    public class PrimaryKeyFields
    {
        public void HideFields(DataGridView gridView, int total)
        {
            for(int index = 0; index < total; index++)
                gridView.Columns[index].Visible = false;
        }
    }
}
