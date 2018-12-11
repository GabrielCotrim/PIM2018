namespace InterfacesVisuais
{
    partial class frmCadastroProjeto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.flwLateralBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCadastroSecundarios = new System.Windows.Forms.TabControl();
            this.tbUsuario = new System.Windows.Forms.TabPage();
            this.tbCategoria = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.flwLateralBtn.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbCadastroSecundarios.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            this.tbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 14);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(310, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // flwLateralBtn
            // 
            this.flwLateralBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flwLateralBtn.Controls.Add(this.btnCadastrar);
            this.flwLateralBtn.Controls.Add(this.btnEditar);
            this.flwLateralBtn.Controls.Add(this.btnDeletar);
            this.flwLateralBtn.Controls.Add(this.btnFechar);
            this.flwLateralBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.flwLateralBtn.Location = new System.Drawing.Point(521, 0);
            this.flwLateralBtn.Name = "flwLateralBtn";
            this.flwLateralBtn.Size = new System.Drawing.Size(124, 224);
            this.flwLateralBtn.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 41);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(3, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 41);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(3, 97);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(117, 41);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, 144);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 41);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbCadastroSecundarios);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 159);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // tbCadastroSecundarios
            // 
            this.tbCadastroSecundarios.Controls.Add(this.tbUsuario);
            this.tbCadastroSecundarios.Controls.Add(this.tbCategoria);
            this.tbCadastroSecundarios.Location = new System.Drawing.Point(3, 3);
            this.tbCadastroSecundarios.Name = "tbCadastroSecundarios";
            this.tbCadastroSecundarios.SelectedIndex = 0;
            this.tbCadastroSecundarios.Size = new System.Drawing.Size(515, 147);
            this.tbCadastroSecundarios.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.lblClassificacao);
            this.tbUsuario.Controls.Add(this.txtClassificacao);
            this.tbUsuario.Controls.Add(this.label1);
            this.tbUsuario.Controls.Add(this.txtNome);
            this.tbUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(507, 121);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Cadastro Usuário";
            this.tbUsuario.UseVisualStyleBackColor = true;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Controls.Add(this.lblDescricaoCategoria);
            this.tbCategoria.Controls.Add(this.txtDescricaoCategoria);
            this.tbCategoria.Location = new System.Drawing.Point(4, 22);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategoria.Size = new System.Drawing.Size(507, 121);
            this.tbCategoria.TabIndex = 1;
            this.tbCategoria.Text = "Cadastro Categorias";
            this.tbCategoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(3, 70);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(72, 13);
            this.lblClassificacao.TabIndex = 8;
            this.lblClassificacao.Text = "Classificação:";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(98, 70);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.ReadOnly = true;
            this.txtClassificacao.Size = new System.Drawing.Size(310, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // lblDescricaoCategoria
            // 
            this.lblDescricaoCategoria.AutoSize = true;
            this.lblDescricaoCategoria.Location = new System.Drawing.Point(10, 35);
            this.lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            this.lblDescricaoCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoCategoria.TabIndex = 6;
            this.lblDescricaoCategoria.Text = "Descrição:";
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(105, 33);
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(310, 20);
            this.txtDescricaoCategoria.TabIndex = 5;
            // 
            // frmCadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 224);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flwLateralBtn);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastroProjeto";
            this.flwLateralBtn.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbCadastroSecundarios.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbUsuario.PerformLayout();
            this.tbCategoria.ResumeLayout(false);
            this.tbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.FlowLayoutPanel flwLateralBtn;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tbCadastroSecundarios;
        private System.Windows.Forms.TabPage tbUsuario;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tbCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
    }
}