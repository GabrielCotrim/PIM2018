namespace InterfacesVisuais
{
    partial class frmPrincipal
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
            this.flpEsquerda = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpTopoInterno = new System.Windows.Forms.TableLayoutPanel();
            this.btnCriarTarefas = new System.Windows.Forms.Button();
            this.btnVerTarefas = new System.Windows.Forms.Button();
            this.btnMinhaVisao = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrarProjeto = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAjusteTamanho = new System.Windows.Forms.Panel();
            this.flpEsquerda.SuspendLayout();
            this.tlpTopoInterno.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEsquerda
            // 
            this.flpEsquerda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpEsquerda.Controls.Add(this.tlpTopoInterno);
            this.flpEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpEsquerda.Location = new System.Drawing.Point(0, 0);
            this.flpEsquerda.Name = "flpEsquerda";
            this.flpEsquerda.Size = new System.Drawing.Size(115, 636);
            this.flpEsquerda.TabIndex = 2;
            // 
            // tlpTopoInterno
            // 
            this.tlpTopoInterno.ColumnCount = 1;
            this.tlpTopoInterno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopoInterno.Controls.Add(this.btnCriarTarefas, 0, 2);
            this.tlpTopoInterno.Controls.Add(this.btnVerTarefas, 0, 1);
            this.tlpTopoInterno.Controls.Add(this.btnMinhaVisao, 0, 0);
            this.tlpTopoInterno.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopoInterno.Location = new System.Drawing.Point(3, 3);
            this.tlpTopoInterno.Name = "tlpTopoInterno";
            this.tlpTopoInterno.RowCount = 3;
            this.tlpTopoInterno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopoInterno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopoInterno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopoInterno.Size = new System.Drawing.Size(112, 172);
            this.tlpTopoInterno.TabIndex = 2;
            // 
            // btnCriarTarefas
            // 
            this.btnCriarTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCriarTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTarefas.Location = new System.Drawing.Point(0, 114);
            this.btnCriarTarefas.Margin = new System.Windows.Forms.Padding(0);
            this.btnCriarTarefas.Name = "btnCriarTarefas";
            this.btnCriarTarefas.Size = new System.Drawing.Size(112, 58);
            this.btnCriarTarefas.TabIndex = 2;
            this.btnCriarTarefas.Text = "Criar Tarefas";
            this.btnCriarTarefas.UseVisualStyleBackColor = true;
            // 
            // btnVerTarefas
            // 
            this.btnVerTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTarefas.Location = new System.Drawing.Point(0, 57);
            this.btnVerTarefas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerTarefas.Name = "btnVerTarefas";
            this.btnVerTarefas.Size = new System.Drawing.Size(112, 57);
            this.btnVerTarefas.TabIndex = 2;
            this.btnVerTarefas.Text = "Ver Tarefas";
            this.btnVerTarefas.UseVisualStyleBackColor = true;
            this.btnVerTarefas.Click += new System.EventHandler(this.btnVerTarefas_Click);
            // 
            // btnMinhaVisao
            // 
            this.btnMinhaVisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinhaVisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhaVisao.Location = new System.Drawing.Point(0, 0);
            this.btnMinhaVisao.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinhaVisao.Name = "btnMinhaVisao";
            this.btnMinhaVisao.Size = new System.Drawing.Size(112, 57);
            this.btnMinhaVisao.TabIndex = 2;
            this.btnMinhaVisao.Text = "Minhas Tarefas";
            this.btnMinhaVisao.UseVisualStyleBackColor = true;
            this.btnMinhaVisao.Click += new System.EventHandler(this.btnMinhaVisao_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrarProjeto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrarUsuarios, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(10, 3);
            this.lblNome.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(119, 37);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "HelpDev";
            // 
            // btnCadastrarProjeto
            // 
            this.btnCadastrarProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrarProjeto.Enabled = false;
            this.btnCadastrarProjeto.Location = new System.Drawing.Point(1015, 3);
            this.btnCadastrarProjeto.Name = "btnCadastrarProjeto";
            this.btnCadastrarProjeto.Size = new System.Drawing.Size(92, 54);
            this.btnCadastrarProjeto.TabIndex = 3;
            this.btnCadastrarProjeto.Text = "Cadastrar Projeto";
            this.btnCadastrarProjeto.UseVisualStyleBackColor = true;
            this.btnCadastrarProjeto.Click += new System.EventHandler(this.btnCadastrarProjeto_Click);
            // 
            // btnCadastrarUsuarios
            // 
            this.btnCadastrarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrarUsuarios.Enabled = false;
            this.btnCadastrarUsuarios.Location = new System.Drawing.Point(901, 3);
            this.btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            this.btnCadastrarUsuarios.Size = new System.Drawing.Size(108, 54);
            this.btnCadastrarUsuarios.TabIndex = 5;
            this.btnCadastrarUsuarios.Text = "Cadastrar Usuários";
            this.btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuarios.Click += new System.EventHandler(this.btnCadastrarUsuarios_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblNomeProjeto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(792, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(103, 54);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Segoe UI Symbol", 17F);
            this.lblNomeProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeProjeto.Location = new System.Drawing.Point(5, 0);
            this.lblNomeProjeto.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(97, 30);
            this.lblNomeProjeto.TabIndex = 0;
            this.lblNomeProjeto.Text = "Projetos";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // pnlAjusteTamanho
            // 
            this.pnlAjusteTamanho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAjusteTamanho.Location = new System.Drawing.Point(115, 60);
            this.pnlAjusteTamanho.Name = "pnlAjusteTamanho";
            this.pnlAjusteTamanho.Size = new System.Drawing.Size(1110, 576);
            this.pnlAjusteTamanho.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 636);
            this.Controls.Add(this.pnlAjusteTamanho);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpEsquerda);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpEsquerda.ResumeLayout(false);
            this.tlpTopoInterno.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpEsquerda;
        private System.Windows.Forms.TableLayoutPanel tlpTopoInterno;
        private System.Windows.Forms.Button btnCriarTarefas;
        private System.Windows.Forms.Button btnVerTarefas;
        private System.Windows.Forms.Button btnMinhaVisao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrarProjeto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlAjusteTamanho;
    }
}