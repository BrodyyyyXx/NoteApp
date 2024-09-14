namespace NoteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            savebutton = new Button();
            deletebutton = new Button();
            newnbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 2;
            label2.Text = "Note:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 118);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 523);
            textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(408, 521);
            dataGridView1.TabIndex = 4;
            // 
            // savebutton
            // 
            savebutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            savebutton.Location = new Point(538, 536);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(194, 40);
            savebutton.TabIndex = 6;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deletebutton.Location = new Point(436, 601);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(194, 40);
            deletebutton.TabIndex = 7;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // newnbutton
            // 
            newnbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newnbutton.Location = new Point(650, 601);
            newnbutton.Name = "newnbutton";
            newnbutton.Size = new Size(194, 40);
            newnbutton.TabIndex = 8;
            newnbutton.Text = "New Note";
            newnbutton.UseVisualStyleBackColor = true;
            newnbutton.Click += newnbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(882, 653);
            Controls.Add(newnbutton);
            Controls.Add(deletebutton);
            Controls.Add(savebutton);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button savebutton;
        private Button deletebutton;
        private Button newnbutton;
    }
}
