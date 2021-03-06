﻿using Nucleo.Enumeradores;
using Nucleo.Negocio;
using Nucleo.Processos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfacesVisuais
{
    public partial class frmLogin : Form
    {
        private ProcessoCadastroDeUsuario _processo = new ProcessoCadastroDeUsuario();
        private Usuario _usuario = new Usuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnShown(EventArgs e)
        {
            var logins = _processo.ObtenhaTodos().Where(u=>!u.Classificacao.Equals(EnumeradorClassificacaoUsuario.PROJETO)).Select(u => u.Login);
            bsUsuarios.DataSource = logins.Select(u => u);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Insira a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var ehSenhaValida = ((Login) cboUser.SelectedItem).EhSenhaValida(txtSenha.Text);

            if (!ehSenhaValida)
            {
                MessageBox.Show("Senha Incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(this.IsDisposed)
                    this.DialogResult = DialogResult.Cancel;
                return;
            }

            _usuario = _processo.ObtenhaUsuario((Login)cboUser.SelectedItem);

            SessaoUsuario.Instancia.Usuario = _usuario;

            this.DialogResult = DialogResult.OK;
        }
    }
}
