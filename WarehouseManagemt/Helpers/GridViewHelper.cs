namespace WarehouseManagent.Helpers
{
    public class GridViewHelper
    {
        public object GetCellValue(DataGridViewCellEventArgs e, DataGridView dataGridView, string columnName)
        {
            return dataGridView.Rows[e.RowIndex].Cells[columnName].Value;
        }
    }
}
