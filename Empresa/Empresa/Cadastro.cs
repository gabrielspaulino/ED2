using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Empresa
{
    class Cadastro
    {
        string con = @"Data Source=PC-GABRIEL\SQLEXPRESS;Initial Catalog=TP08_ED2;Integrated Security=True";
        SqlConnection conexao;
        SqlCommand comando;
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        public List<Usuario> Usuarios
        {
            get { return usuarios; }
        }

        public List<Ambiente> Ambientes
        {
            get { return ambientes; }
        }

        public Cadastro()
        {
            usuarios = new List<Usuario>();
            ambientes = new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            if (pesquisarUsuario(usuario) == null)
            {
                usuarios.Add(usuario);
            }
        }

        public bool removerUsuario(Usuario usuario)
        {
            Usuario remover = pesquisarUsuario(usuario);
            if (remover.Ambientes.Count == 0 && remover != null)
            {
                usuarios.Remove(remover);
                string query = "DELETE FROM tb_usuario WHERE cod_usuario = @id";
                comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@id", remover.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Id == usuario.Id)
                {
                    return u;
                }
            }
            return null;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            if (pesquisarAmbiente(ambiente) == null)
            {
                ambientes.Add(ambiente);
            }
        }

        public bool removerAmbiente(Ambiente ambiente)
        {
            Ambiente remover = pesquisarAmbiente(ambiente);
            if (remover != null)
            {
                ambientes.Remove(remover);
                string query = "DELETE FROM tb_ambiente WHERE cod_ambiente = @id";
                comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@id", remover.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente a in ambientes)
            {
                if (a.Id == ambiente.Id)
                {
                    return a;
                }
            }
            return null;
        }

        public void upload()
        {
            string query;
            try
            {
                conectar();
                foreach (Usuario u in usuarios)
                {
                    query = "INSERT INTO tb_usuario (cod_usuario, nome_usuario) VALUES (@id, @nome)";
                    comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", u.Id);
                    comando.Parameters.AddWithValue("@nome", u.Nome);
                    comando.ExecuteNonQuery();
                }
                foreach (Ambiente a in ambientes)
                {
                    query = "INSERT INTO tb_ambiente (cod_ambiente, nome_ambiente) VALUES (@id, @nome)";
                    comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", a.Id);
                    comando.Parameters.AddWithValue("@nome", a.Nome);
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados\n" + e.Message);
            }
            conexao.Close();
        }

        public void download()
        {
            try
            {
                conectar();
                comando = new SqlCommand("SELECT * FROM tb_usuario", conexao);
                Console.WriteLine("Conectado ao banco de dados");
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string idUsuario = reader["cod_usuario"].ToString();
                    string nomeUsuario = reader["nome_usuario"].ToString();
                    adicionarUsuario(new Usuario(Convert.ToInt32(idUsuario), nomeUsuario));
                }
                reader.Close();
                comando = new SqlCommand("SELECT * FROM tb_ambiente", conexao);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string idAmbiente = reader["cod_ambiente"].ToString();
                    string nomeAmbiente = reader["nome_ambiente"].ToString();
                    adicionarAmbiente(new Ambiente(Convert.ToInt32(idAmbiente), nomeAmbiente));
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados\n" + e.Message);
            }
        }

        public SqlConnection conectar()
        {
            conexao = new SqlConnection(con);
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
    }
}