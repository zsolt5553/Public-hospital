using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class ListOfDoctors : Form
    {
        public ListOfDoctors()
        {
            InitializeComponent();
            this.CenterToScreen();
            UpdateTable();
        }

        public void UpdateTable()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Firstname";
            dataGridView1.Columns[1].Name = "Lastname";
            dataGridView1.Columns[2].Name = "Speciality";
            dataGridView1.Rows.Add(1);

        }

      

        private void urlButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ListOfDoctors_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 39);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(99, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(244, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 420);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 364);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListOfDoctors
            // 
            this.ClientSize = new System.Drawing.Size(623, 437);
            this.Controls.Add(this.panel1);
            this.Name = "ListOfDoctors";
            this.Text = "List of doctors";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() => new NewDoctor().ShowDialog()).Start();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        
    }
}
