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
            this.components = new System.ComponentModel.Container();
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
            this.cboClassificacao = new System.Windows.Forms.ComboBox();
            this.bsClassificacao = new System.Windows.Forms.BindingSource(this.components);
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.bsCategorias = new System.Windows.Forms.BindingSource(this.components);
            this.flwLateralBtn.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbCadastroSecundarios.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClassificacao)).BeginInit();
            this.tbCategoria.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorias)).BeginInit();
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
            this.flwLateralBtn.Size = new System.Drawing.Size(124, 327);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 262);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // tbCadastroSecundarios
            // 
            this.tbCadastroSecundarios.Controls.Add(this.tbUsuario);
            this.tbCadastroSecundarios.Controls.Add(this.tbCategoria);
            this.tbCadastroSecundarios.Location = new System.Drawing.Point(3, 3);
            this.tbCadastroSecundarios.Name = "tbCadastroSecundarios";
            this.tbCadastroSecundarios.SelectedIndex = 0;
            this.tbCadastroSecundarios.Size = new System.Drawing.Size(518, 259);
            this.tbCadastroSecundarios.TabIndex = 0;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.cboClassificacao);
            this.tbUsuario.Controls.Add(this.lblClassificacao);
            this.tbUsuario.Controls.Add(this.label1);
            this.tbUsuario.Controls.Add(this.txtNome);
            this.tbUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(510, 233);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Cadastro Usuário";
            this.tbUsuario.UseVisualStyleBackColor = true;
            // 
            // cboClassificacao
            // 
            this.cboClassificacao.DataSource = this.bsClassificacao;
            this.cboClassificacao.FormattingEnabled = true;
            this.cboClassificacao.Location = new System.Drawing.Point(98, 67);
            this.cboClassificacao.Name = "cboClassificacao";
            this.cboClassificacao.Size = new System.Drawing.Size(310, 21);
            this.cboClassificacao.TabIndex = 9;
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
            // tbCategoria
            // 
            this.tbCategoria.Controls.Add(this.btnAdicionar);
            this.tbCategoria.Controls.Add(this.panel1);
            this.tbCategoria.Controls.Add(this.lblDescricaoCategoria);
            this.tbCategoria.Controls.Add(this.txtDescricaoCategoria);
            this.tbCategoria.Location = new System.Drawing.Point(4, 22);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategoria.Size = new System.Drawing.Size(510, 233);
            this.tbCategoria.TabIndex = 1;
            this.tbCategoria.Text = "Cadastro Categorias";
            this.tbCategoria.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCategorias);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 178);
            this.panel1.TabIndex = 7;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoGenerateColumns = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.DataSource = this.bsCategorias;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(511, 178);
            this.dgvCategorias.TabIndex = 0;
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
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(429, 31);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 327);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flwLateralBtn);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastroProjeto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroProjeto_FormClosed);
            this.flwLateralBtn.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbCadastroSecundarios.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClassificacao)).EndInit();
            this.tbCategoria.ResumeLayout(false);
            this.tbCategoria.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorias)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tbCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.ComboBox cboClassificacao;
        private System.Windows.Forms.BindingSource bsClassificacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.BindingSource bsCategorias;
    }
}