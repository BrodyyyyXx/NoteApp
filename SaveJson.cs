using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace NoteApp
{
    public class SaveJson
    {
        public void SaveToJson(DataTable dataTable, string filePath)
        {
            var rowsList = dataTable.AsEnumerable().Select(row => dataTable.Columns.Cast<DataColumn>().ToDictionary(
                column => column.ColumnName,
                column => row[column])
            ).ToList();

            string json = JsonConvert.SerializeObject(rowsList, Formatting.Indented);

            File.WriteAllText(filePath, json);
        }

        public DataTable LoadFromJson(string filePath)
        {
            if(!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            string json = File.ReadAllText(filePath);

            var rowsList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);

            DataTable dt = new DataTable();
            if(rowsList.Count > 0)
            {
                foreach (var column in rowsList[0].Keys)
                {
                    dt.Columns.Add(column);
                }

                foreach (var row in rowsList)
                {
                    var dataRow = dt.NewRow();
                    foreach(var column in row.Keys)
                    {
                        dataRow[column] = row[column];
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;

        }

    }
}
