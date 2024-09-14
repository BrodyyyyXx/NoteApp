using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        private OutputClass outputClass;
        private DSR dSR = new DSR();
        private SaveJson saveJson = new SaveJson();
        private bool isDataSaved = false;

        public Form1()
        {
            InitializeComponent();
            outputClass = new OutputClass();
            dataGridView1.DataSource = outputClass.GetDataTable();

            // Загрузка данных при запуске программы
            LoadData();

            // Подписываемся на событие закрытия формы для сохранения данных
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 100)
                MessageBox.Show("Строка слишком большая!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newnbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Пожалуйста, заполните оба текстовых поля.");
                return;
            }

            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            outputClass.AddRow(text1, text2);

            textBox1.Clear();
            textBox2.Clear();

            dataGridView1.DataSource = outputClass.GetDataTable();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveData(); // Сохраняем данные при нажатии на кнопку Save
            isDataSaved = true; // Устанавливаем флаг в true после успешного сохранения
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            dSR.DeleteSelectedRow(dataGridView1, outputClass);
        }

        // Метод для сохранения данных в JSON
        private void SaveData()
        {
            try
            {
                string filePath = "notes.json"; // Указываем путь к файлу JSON

                // Сохраняем данные из DataTable в JSON
                saveJson.SaveToJson(outputClass.GetDataTable(), filePath);

                // Показываем сообщение только если данные были сохранены
                if (isDataSaved)
                {
                    MessageBox.Show("Данные сохранены в JSON файл.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message);
            }
        }

        // Метод для загрузки данных из JSON файла при запуске программы
        private void LoadData()
        {
            try
            {
                string filePath = "notes.json"; // Указываем путь к файлу JSON

                if (File.Exists(filePath))
                {
                    // Загружаем данные из JSON
                    DataTable dt = saveJson.LoadFromJson(filePath);
                    outputClass.GetDataTable().Merge(dt); // Объединяем данные
                    dataGridView1.DataSource = outputClass.GetDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        // Метод, вызываемый при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved)
            {
                SaveData(); // Сохраняем данные перед закрытием программы, если они не были сохранены
            }
        }
    }
}
