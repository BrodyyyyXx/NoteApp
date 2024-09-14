using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class OutputClass
    {
        // Поле для хранения DataTable
        private DataTable dt;

        // Конструктор класса
        public OutputClass()
        {
            // Инициализация DataTable
            dt = new DataTable();
            dt.Columns.Add("Title");
            dt.Columns.Add("Note");
        }

        // Метод для добавления строки в DataTable
        public void AddRow(string Title, string Note)
        {
            dt.Rows.Add(Title, Note);
        }

        // Метод для получения DataTable
        public DataTable GetDataTable()
        {
            return dt;
        }
    }
}
