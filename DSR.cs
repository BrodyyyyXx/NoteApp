using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    internal class DSR
    {
        public void DeleteSelectedRow(DataGridView dataGridView, OutputClass outputClass)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                if(rowIndex >= 0 && rowIndex < outputClass.GetDataTable().Rows.Count)
                {
                    outputClass.GetDataTable().Rows[rowIndex].Delete();

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = outputClass.GetDataTable();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                }
            }
        }
    }
}
