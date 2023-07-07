namespace Test
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
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 180);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "SYSTEM EDUCATION";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(62, 62, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(297, 142);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = "USUÁRIO";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(60, 60, 60);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(297, 269);
            button1.Name = "button1";
            button1.Size = new Size(408, 40);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 53, 176);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 360);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(296, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 7;
            label2.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_excluir_50__1_;
            pictureBox1.Location = new Point(826, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_minimizar_50__1_;
            pictureBox2.Location = new Point(793, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(62, 62, 62);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(297, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 20);
            textBox2.TabIndex = 2;
            textBox2.Text = "SENHA";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(60, 60, 60);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(889, 214);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 4;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(882, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 10;
            label3.Text = "SIGN UP";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(851, 167);
            label4.Name = "label4";
            label4.Size = new Size(182, 21);
            label4.TabIndex = 11;
            label4.Text = "Cadastrar novo aluno";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Silver;
            linkLabel1.Location = new Point(296, 312);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 17);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Equeçeu senha?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 60, 60);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 53);
            panel2.TabIndex = 13;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(296, 116);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 14;
            label5.Text = "USUÁRIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(296, 180);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 15;
            label6.Text = "SENHA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(1115, 360);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escolinha Muito Loka";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
    }
}