using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade07
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender,EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender,EventArgs e)
        {
            if (Banco.CriarUsuario(txtLogin.Text, txtSenha.Text))
            {
                MessageBox.Show($"Usuário {txtLogin.Text} criado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Erro ao criar usuário {txtLogin.Text}! Login já existente.");
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Usuario u = Banco.RealizarLogin(txtLogin.Text, txtSenha.Text);
            if (u == null)
            {
                MessageBox.Show("Erro ao realizar login. Usuário ou senha não conferem!");
            }
            else
            {
                FormCarro formCarro = new FormCarro(u);
                formCarro.Show();
                this.Hide();
            }
        }
    }
}
