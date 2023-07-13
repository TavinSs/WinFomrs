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
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    public partial class TelaCadastro : Form
    {
        Point mousePos;
        public TelaCadastro()
        {
            InitializeComponent();

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "NOME EX: Maria")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "NOME EX: Maria";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "IDADE EX: 13")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "IDADE EX: 13";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "ALTURA EX: 1.69")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "ALTURA EX: 1.69";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "PESO EX: 70.5")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.LightGray;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "PESO EX: 70.5";
                textBox4.ForeColor = Color.LightGray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "GÊNERO (F OU M)")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.LightGray;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "GÊNERO (F OU M)";
                textBox5.ForeColor = Color.LightGray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "NOME DO PAI")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.LightGray;

            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "NOME DO PAI";
                textBox6.ForeColor = Color.LightGray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "NOME DA MÃE")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.LightGray;

            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "NOME DA MÃE";
                textBox7.ForeColor = Color.LightGray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "USUÁRIO")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.LightGray;

            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "USUÁRIO";
                textBox8.ForeColor = Color.LightGray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "SENHA")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.LightGray;

            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "SENHA";
                textBox9.ForeColor = Color.LightGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;

            textBox1.Text = "NOME EX: Maria";
            textBox2.Text = "IDADE EX: 13";
            textBox3.Text = "ALTURA EX: 1.69";
            textBox4.Text = "PESO EX: 70.5";
            textBox5.Text = "GÊNERO (F OU M)";
            textBox6.Text = "NOME DO PAI";
            textBox7.Text = "NOME DA MÃE";
            textBox8.Text = "USUÁRIO";
            textBox9.Text = "SENHA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            Aluno aluno = new Aluno();
            aluno.Nome = textBox1.Text;
            aluno.Idade = (int.Parse(textBox2.Text));
            aluno.Altura = textBox3.Text;
            aluno.Peso = textBox4.Text;
            aluno.Genero = textBox5.Text;
            aluno.NomePai = textBox6.Text;
            aluno.NomeMae = textBox7.Text;

            string sqlAluno = $"INSERT INTO Aluno(Nome, Idade, Altura, Peso, Genero, NomePai, NomeMae)" + $"VALUES ('{aluno.Nome}', '{aluno.Idade}', '{aluno.Altura}', '{aluno.Peso}', '{aluno.Genero}', '{aluno.NomePai}', '{aluno.NomeMae}')";
            SqlCommand comamdoAluno = new SqlCommand(sqlAluno, db.conn);
            comamdoAluno.ExecuteNonQuery();

            MessageBox.Show("Aluno Cadastrado com Sucesso");

            db.Desconectar();

            db.Conectar();

            UsuarioBanco user = new UsuarioBanco();
            user.Usuario = textBox8.Text;
            user.Senha = textBox9.Text;

            string sqlUsuario = $"INSERT INTO Usuario(Login, Senha)" + $"VALUES ('{user.Usuario}', '{user.Senha}')";
            SqlCommand comamdoUsuario = new SqlCommand(sqlUsuario, db.conn);
            comamdoUsuario.ExecuteNonQuery();

            MessageBox.Show("Usuario cadastrado com Sucesso");

            db.Desconectar();

        }

        private void TelaCadastro_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                mousePos = new Point(e.X, e.Y);
            }
        }

        private void TelaCadastro_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // Calcula a diferença entre a posição atual do mouse e a posição anterior do mouse
                int deltaX = e.X - mousePos.X;
                int deltaY = e.Y - mousePos.Y;

                // Atualiza a posição da janela
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }
    }
}