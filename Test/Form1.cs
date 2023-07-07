namespace Test
{
    public partial class Form1 : Form
    {
        Point mousePos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioBanco usuario = new UsuarioBanco();
            usuario.Usuario = textBox1.Text;
            usuario.Senha = textBox2.Text;



            var retorno = db.BuscarUsuario(usuario.Usuario, usuario.Senha);

            if (!retorno)
            {
                MessageBox.Show("Senha incorreta!");
            }
            if (retorno)
            {
                MessageBox.Show("Bem-Vindo");

                TelaAluno Telaaluno = new TelaAluno();
                Telaaluno.Show();
                this.Hide();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            if (textBox2.Text == "SENHA")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "SENHA";
                textBox2.ForeColor = Color.LightGray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenha redefinirSenha = new EsqueceuSenha();
            redefinirSenha.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
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