namespace WindowsFormsClient
{
    partial class DoctorUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorUpdate));
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.speciality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.phonenr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.streetnr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.password);
            this.panel5.Controls.Add(this.username);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label11);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.speciality);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.description);
            this.panel4.Controls.Add(this.phonenr);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label10);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // speciality
            // 
            resources.ApplyResources(this.speciality, "speciality");
            this.speciality.Name = "speciality";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // description
            // 
            resources.ApplyResources(this.description, "description");
            this.description.Name = "description";
            this.description.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // phonenr
            // 
            resources.ApplyResources(this.phonenr, "phonenr");
            this.phonenr.Name = "phonenr";
            this.phonenr.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.streetnr);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.street);
            this.panel3.Controls.Add(this.zip);
            this.panel3.Controls.Add(this.city);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // streetnr
            // 
            resources.ApplyResources(this.streetnr, "streetnr");
            this.streetnr.Name = "streetnr";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // street
            // 
            resources.ApplyResources(this.street, "street");
            this.street.Name = "street";
            // 
            // zip
            // 
            resources.ApplyResources(this.zip, "zip");
            this.zip.Name = "zip";
            this.zip.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.Name = "city";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.firstname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lastname
            // 
            resources.ApplyResources(this.lastname, "lastname");
            this.lastname.Name = "lastname";
            // 
            // firstname
            // 
            resources.ApplyResources(this.firstname, "firstname");
            this.firstname.Name = "firstname";
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DoctorUpdate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(201)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorUpdate";
            this.Load += new System.EventHandler(this.NewDoctor_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox speciality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox phonenr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox streetnr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}