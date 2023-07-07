using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class TelaAluno : Form
    {
        Point mousePos;
        public TelaAluno()
        {
            InitializeComponent();

        }

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            var aluno = db.BuscarAlunos();
            dataGridView1.DataSource = aluno;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
