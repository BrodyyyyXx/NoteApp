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

            // �������� ������ ��� ������� ���������
            LoadData();

            // ������������� �� ������� �������� ����� ��� ���������� ������
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 100)
                MessageBox.Show("������ ������� �������!!!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void newnbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("����������, ��������� ��� ��������� ����.");
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
            SaveData(); // ��������� ������ ��� ������� �� ������ Save
            isDataSaved = true; // ������������� ���� � true ����� ��������� ����������
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            dSR.DeleteSelectedRow(dataGridView1, outputClass);
        }

        // ����� ��� ���������� ������ � JSON
        private void SaveData()
        {
            try
            {
                string filePath = "notes.json"; // ��������� ���� � ����� JSON

                // ��������� ������ �� DataTable � JSON
                saveJson.SaveToJson(outputClass.GetDataTable(), filePath);

                // ���������� ��������� ������ ���� ������ ���� ���������
                if (isDataSaved)
                {
                    MessageBox.Show("������ ��������� � JSON ����.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������ ��� ���������� ������: " + ex.Message);
            }
        }

        // ����� ��� �������� ������ �� JSON ����� ��� ������� ���������
        private void LoadData()
        {
            try
            {
                string filePath = "notes.json"; // ��������� ���� � ����� JSON

                if (File.Exists(filePath))
                {
                    // ��������� ������ �� JSON
                    DataTable dt = saveJson.LoadFromJson(filePath);
                    outputClass.GetDataTable().Merge(dt); // ���������� ������
                    dataGridView1.DataSource = outputClass.GetDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �������� ������: " + ex.Message);
            }
        }

        // �����, ���������� ��� �������� �����
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved)
            {
                SaveData(); // ��������� ������ ����� ��������� ���������, ���� ��� �� ���� ���������
            }
        }
    }
}
