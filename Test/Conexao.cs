using System.Data.SqlClient;

namespace Test
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=FAMILIAOGH\\SQLEXPRESS;Initial Catalog=JovemProgramador;Data Source=FAMILIAOGH\\SQLEXPRESS");


        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }
        public bool BuscarUsuario(string usuario, string senha)
        {
            string sql = $"select * from Usuario where Login = '{usuario}' and Senha = '{senha}' ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return false;
        }

        public bool BuscaUsuario(string usuario)
        {
            string sql = $"select * from Usuario where Login = '{usuario}'";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return false;
        }

        public List<Aluno> BuscarAlunos()
        {
            string sql = "SELECT * FROM Aluno";
            SqlCommand comando = new SqlCommand(sql, conn);
            List<Aluno> aluno = new List<Aluno>();
            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    var idadeDb = reader.GetInt32(reader.GetOrdinal("Idade"));
                    var pesoDb = reader.GetString(reader.GetOrdinal("Peso"));
                    var alturaDb = reader.GetString(reader.GetOrdinal("Altura"));
                    var generoDb = reader.GetString(reader.GetOrdinal("Genero"));
                    var nomeMaeDb = reader.GetString(reader.GetOrdinal("NomeMae"));
                    var nomePaiDb = reader.GetString(reader.GetOrdinal("NomePai"));
                   
                    aluno.Add(new Aluno()
                    {
                        Nome = nomeDb,
                        Idade = idadeDb,
                        Peso = pesoDb,
                        Altura = alturaDb,
                        Genero = generoDb,
                        NomeMae = nomeMaeDb,
                        NomePai = nomePaiDb,

                    });
                }
                return aluno;
            }
        }
    }
}
