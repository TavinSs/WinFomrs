namespace Test
{
    partial class EsqueceuSenha
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 131, 149);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 426);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 213);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "SYSTEM EDUCATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(283, 72);
            label2.Name = "label2";
            label2.Size = new Size(212, 30);
            label2.TabIndex = 1;
            label2.Text = "REDEFINIR SENHA";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(62, 62, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(304, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "USUÁRIO";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            textBox1.Validated += textBox1_Validated;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(62, 62, 62);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(304, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 20);
            textBox2.TabIndex = 3;
            textBox2.Text = "NOVA SENHA";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_excluir_50__1_;
            pictureBox1.Location = new Point(435, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_minimizar_50__1_;
            pictureBox2.Location = new Point(399, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 69, 69);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(626, 378);
            button1.Name = "button1";
            button1.Size = new Size(106, 36);
            button1.TabIndex = 6;
            button1.Text = "REDEFINIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 69, 69);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(533, 378);
            button2.Name = "button2";
            button2.Size = new Size(87, 36);
            button2.TabIndex = 7;
            button2.Text = "VOLTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 60, 60);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(267, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 55);
            panel2.TabIndex = 8;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(304, 144);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 9;
            label3.Text = "USUÁRIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(304, 243);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 10;
            label4.Text = "NOVA SENHA";
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(744, 426);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EsqueceuSenha";
            Opacity = 0.97D;
            Text = "EsqueceuSenha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Label label3;
        private Label label4;
    }
}