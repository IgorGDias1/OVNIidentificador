using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIidentificador
{
    public partial class Painel : Form
    {
        // Objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDados();
            // Popular o CMB:
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        // Método para atualizar os dados:
        public void AtualizarDados()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
            // Ativar os botões de acordo com o estado da nave:
            btnLigar.Enabled = !ovni.Situacao;
            btnDesligar.Enabled = ovni.Situacao;
            // Habilitar/desabilitar botões de acordo com a situação:
            btnAbduzir.Enabled = false;
            btnDesabduzir.Enabled = false;
            btnRetornarOrigem.Enabled = false;
            cmbPlanetas.Enabled = false;
            btnMudar.Enabled = false;
        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Limite máximo de tripulantes atingido!");
            }
            AtualizarDados();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            ovni.Ligar();
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            ovni.Desligar();
            AtualizarDados();
        }

        private void btnRemoverTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.RemoverTripulante() == false)
            {
                MessageBox.Show("É necessário pelo menos 1 tripulante na nave");
            }
            AtualizarDados();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir() == false)
            {
                MessageBox.Show("Limite máximo de abduzidos atingido!");
            }
            AtualizarDados();
        }

        private void btnDesabduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir() == false)
            {
                MessageBox.Show("Ninguém foi abduzido ainda!");
            }
            AtualizarDados();
        }

        private void btnRetornarOrigem_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem() == false)
            {
                MessageBox.Show("A nave já está no planeta de origem");
            }
            AtualizarDados();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            string novoPlaneta = cmbPlanetas.Text;
            ovni.MudarPlaneta(novoPlaneta);
            AtualizarDados();
        }
    }
}
