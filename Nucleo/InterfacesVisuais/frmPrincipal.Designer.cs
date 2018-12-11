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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjetos = new System.Windows.Forms.Label();
            this.cboProjetos = new System.Windows.Forms.ComboBox();
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.btnCadastrarProjeto = new System.Windows.Forms.Button();
            this.flpEsquerda.SuspendLayout();
            this.tlpTopoInterno.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.flpEsquerda.Size = new System.Drawing.Size(115, 639);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Tarefando";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProjetos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboProjetos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrarProjeto, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblProjetos
            // 
            this.lblProjetos.AutoSize = true;
            this.lblProjetos.Font = new System.Drawing.Font("Segoe UI Symbol", 19F);
            this.lblProjetos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProjetos.Location = new System.Drawing.Point(889, 0);
            this.lblProjetos.Margin = new System.Windows.Forms.Padding(0);
            this.lblProjetos.Name = "lblProjetos";
            this.lblProjetos.Size = new System.Drawing.Size(109, 36);
            this.lblProjetos.TabIndex = 1;
            this.lblProjetos.Text = "Projetos";
            this.lblProjetos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProjetos
            // 
            this.cboProjetos.DataSource = this.bsProjetos;
            this.cboProjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProjetos.FormattingEnabled = true;
            this.cboProjetos.Location = new System.Drawing.Point(892, 39);
            this.cboProjetos.Name = "cboProjetos";
            this.cboProjetos.Size = new System.Drawing.Size(104, 21);
            this.cboProjetos.TabIndex = 2;
            // 
            // btnCadastrarProjeto
            // 
            this.btnCadastrarProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrarProjeto.Enabled = false;
            this.btnCadastrarProjeto.Location = new System.Drawing.Point(1002, 3);
            this.btnCadastrarProjeto.Name = "btnCadastrarProjeto";
            this.btnCadastrarProjeto.Size = new System.Drawing.Size(105, 30);
            this.btnCadastrarProjeto.TabIndex = 3;
            this.btnCadastrarProjeto.Text = "Cadastrar Projeto";
            this.btnCadastrarProjeto.UseVisualStyleBackColor = true;
            this.btnCadastrarProjeto.Click += new System.EventHandler(this.btnCadastrarProjeto_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flpEsquerda);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpEsquerda.ResumeLayout(false);
            this.tlpTopoInterno.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpEsquerda;
        private System.Windows.Forms.TableLayoutPanel tlpTopoInterno;
        private System.Windows.Forms.Button btnCriarTarefas;
        private System.Windows.Forms.Button btnVerTarefas;
        private System.Windows.Forms.Button btnMinhaVisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProjetos;
        private System.Windows.Forms.ComboBox cboProjetos;
        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.Button btnCadastrarProjeto;
    }
}