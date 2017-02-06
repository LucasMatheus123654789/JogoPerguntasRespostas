using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_jogador_banco;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();

            id_jogador_banco = id_jogador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if(rdbResposta2.Checked == true)
            {
                MessageBox.Show("ACERTOUUU");
                //Cadastrar no banco de dados a pergunta e a resposta

                using (SqlConnection conexao = new SqlConnection("Server=AME0556346W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta,resposta_correta) values(@pergunta,@resposta_correta)", conexao))
                    {
                        comando.Parameters.AddWithValue("pergunta", lblPergunta.Text);
                        comando.Parameters.AddWithValue("resposta_correta", rdbResposta2.Text);
                        comando.Parameters.AddWithValue("", id_jogador_banco);
                        conexao.Open();
                        comando.ExecuteNonQuery();

                        int id_jogador = (int)comando.ExecuteScalar();

                        MessageBox.Show("o id inserido foi: " + id_jogador);



                    }

                }
            }
            else
            {
                MessageBox.Show("ERROUU");
                    }

        }

        private void rdbResposta2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
