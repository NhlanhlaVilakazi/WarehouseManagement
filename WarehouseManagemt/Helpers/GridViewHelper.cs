namespace WarehouseManagent.Helpers
{
    public class GridViewHelper
    {
        public static object GetCellValue(DataGridViewCellEventArgs e, DataGridView dataGridView, string columnName)
        {
            return dataGridView.Rows[e.RowIndex].Cells[columnName].Value;
        }

        public static string GetColumn(DataGridViewCellEventArgs e, DataGridView dataGridView)
        {
            return dataGridView.Columns[e.ColumnIndex].HeaderText;
        }
    }
}
