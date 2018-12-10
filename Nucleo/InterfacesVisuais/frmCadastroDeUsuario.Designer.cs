namespace InterfacesVisuais
{
    partial class frmCadastroDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeUsuario));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flwLateralBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboClassificacao = new System.Windows.Forms.ComboBox();
            this.bsCboClassificacao = new System.Windows.Forms.BindingSource(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flwLateralBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCboClassificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 0;
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
            this.flwLateralBtn.TabIndex = 1;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(72, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Classificação:";
            // 
            // cboClassificacao
            // 
            this.cboClassificacao.DataSource = this.bsCboClassificacao;
            this.cboClassificacao.FormattingEnabled = true;
            this.cboClassificacao.Location = new System.Drawing.Point(104, 71);
            this.cboClassificacao.Name = "cboClassificacao";
            this.cboClassificacao.Size = new System.Drawing.Size(310, 21);
            this.cboClassificacao.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 120);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(104, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(310, 20);
            this.txtUser.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(9, 167);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(104, 165);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(310, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCadastroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 224);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cboClassificacao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.flwLateralBtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroDeUsuario";
            this.Text = "Cadastro de usuário";
            this.flwLateralBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCboClassificacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flwLateralBtn;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboClassificacao;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource bsCboClassificacao;
    }
}