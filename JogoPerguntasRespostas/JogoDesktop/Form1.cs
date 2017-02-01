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

namespace JogoDesktop
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }else{

                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0556356W10-1\\ALUNO01;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using(SqlCommand comando = new SqlCommand("insert into tb_jogador(nome) values(@NOME)",conexao))
                    {
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        conexao.Open();

                        if(comando.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            player.SoundLocation = "c:\\vm\\teste\\som.wav";
                            player.Play();

                        }
                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }
                    }
                }
                //fim do código para inserir o jogador na tabela
            }
        }
    }
}
