using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Test
{
    public partial class EsqueceuSenha : Form
    {
        Point mousePos;
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUÁRIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUÁRIO";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "NOVA SENHA")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "NOVA SENHA";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioBanco usuario = new UsuarioBanco();
            usuario.Usuario = textBox1.Text;

            var retorno = db.BuscaUsuario(usuario.Usuario);
            db.Desconectar();

            if (!retorno)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            if (retorno)
            {
                db.Conectar();
                UsuarioBanco user = new UsuarioBanco();
                user.Usuario = textBox1.Text;
                user.Senha = textBox2.Text;

                string sqlUsuario = $"UPDATE Usuario SET Senha = '{user.Senha}' WHERE Login = '{user.Usuario}'";
                SqlCommand comamdoUsuario = new SqlCommand(sqlUsuario, db.conn);
                comamdoUsuario.ExecuteReader();

                MessageBox.Show("Senha Redefinida");

                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePos = new Point(e.X, e.Y);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int deltaX = e.X - mousePos.X;
                int deltaY = e.Y - mousePos.Y;


                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }
    }
}
