namespace InterfacesVisuais
{
    partial class frmVisualizarTarefa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGravidade = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblAtribuido = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboRelator = new System.Windows.Forms.ComboBox();
            this.bsRelator = new System.Windows.Forms.BindingSource(this.components);
            this.cboPrioridade = new System.Windows.Forms.ComboBox();
            this.bsPrioridade = new System.Windows.Forms.BindingSource(this.components);
            this.cboAtribuido = new System.Windows.Forms.ComboBox();
            this.bsAtribuido = new System.Windows.Forms.BindingSource(this.components);
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.cboGravidade = new System.Windows.Forms.ComboBox();
            this.bsGravidade = new System.Windows.Forms.BindingSource(this.components);
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.bsCategoria = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnOlhar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVisualizar = new System.Windows.Forms.Label();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRelator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtribuido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGravidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.08118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.22017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31382F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGravidade, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrioridade, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAtribuido, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(144, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gravidade";
            // 
            // lblGravidade
            // 
            this.lblGravidade.AutoSize = true;
            this.lblGravidade.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblGravidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGravidade.Location = new System.Drawing.Point(681, 0);
            this.lblGravidade.Name = "lblGravidade";
            this.lblGravidade.Size = new System.Drawing.Size(102, 37);
            this.lblGravidade.TabIndex = 4;
            this.lblGravidade.Text = "Relator";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblPrioridade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrioridade.Location = new System.Drawing.Point(534, 0);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(140, 37);
            this.lblPrioridade.TabIndex = 3;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // lblAtribuido
            // 
            this.lblAtribuido.AutoSize = true;
            this.lblAtribuido.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblAtribuido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtribuido.Location = new System.Drawing.Point(394, 0);
            this.lblAtribuido.Name = "lblAtribuido";
            this.lblAtribuido.Size = new System.Drawing.Size(129, 38);
            this.lblAtribuido.TabIndex = 2;
            this.lblAtribuido.Text = "Atribuido à";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstado.Location = new System.Drawing.Point(291, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 37);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategoria.Location = new System.Drawing.Point(3, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(133, 37);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41855F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.08118F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.22017F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31382F));
            this.tableLayoutPanel2.Controls.Add(this.cboRelator, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboPrioridade, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboAtribuido, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboEstado, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboGravidade, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboCategoria, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(813, 28);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cboRelator
            // 
            this.cboRelator.DataSource = this.bsRelator;
            this.cboRelator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRelator.FormattingEnabled = true;
            this.cboRelator.Location = new System.Drawing.Point(681, 3);
            this.cboRelator.Name = "cboRelator";
            this.cboRelator.Size = new System.Drawing.Size(129, 21);
            this.cboRelator.TabIndex = 5;
            // 
            // cboPrioridade
            // 
            this.cboPrioridade.DataSource = this.bsPrioridade;
            this.cboPrioridade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPrioridade.FormattingEnabled = true;
            this.cboPrioridade.Location = new System.Drawing.Point(534, 3);
            this.cboPrioridade.Name = "cboPrioridade";
            this.cboPrioridade.Size = new System.Drawing.Size(141, 21);
            this.cboPrioridade.TabIndex = 4;
            // 
            // cboAtribuido
            // 
            this.cboAtribuido.DataSource = this.bsAtribuido;
            this.cboAtribuido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboAtribuido.FormattingEnabled = true;
            this.cboAtribuido.Location = new System.Drawing.Point(394, 3);
            this.cboAtribuido.Name = "cboAtribuido";
            this.cboAtribuido.Size = new System.Drawing.Size(134, 21);
            this.cboAtribuido.TabIndex = 3;
            // 
            // cboEstado
            // 
            this.cboEstado.DataSource = this.bsEstado;
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(291, 3);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(97, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // cboGravidade
            // 
            this.cboGravidade.DataSource = this.bsGravidade;
            this.cboGravidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGravidade.FormattingEnabled = true;
            this.cboGravidade.Location = new System.Drawing.Point(144, 3);
            this.cboGravidade.Name = "cboGravidade";
            this.cboGravidade.Size = new System.Drawing.Size(141, 21);
            this.cboGravidade.TabIndex = 1;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataSource = this.bsCategoria;
            this.cboCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(3, 3);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(135, 21);
            this.cboCategoria.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFiltrar);
            this.flowLayoutPanel1.Controls.Add(this.btnOlhar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(733, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 410);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(3, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 38);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnOlhar
            // 
            this.btnOlhar.Location = new System.Drawing.Point(3, 47);
            this.btnOlhar.Name = "btnOlhar";
            this.btnOlhar.Size = new System.Drawing.Size(75, 38);
            this.btnOlhar.TabIndex = 0;
            this.btnOlhar.Text = "Visualizar";
            this.btnOlhar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgvTarefas, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.12121F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(733, 410);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblVisualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblVisualizar
            // 
            this.lblVisualizar.AutoSize = true;
            this.lblVisualizar.Font = new System.Drawing.Font("Segoe UI Symbol", 20F);
            this.lblVisualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVisualizar.Location = new System.Drawing.Point(297, 1);
            this.lblVisualizar.Name = "lblVisualizar";
            this.lblVisualizar.Size = new System.Drawing.Size(254, 37);
            this.lblVisualizar.TabIndex = 1;
            this.lblVisualizar.Text = "Visualizando tarefas";
            this.lblVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.Location = new System.Drawing.Point(3, 75);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(727, 332);
            this.dgvTarefas.TabIndex = 1;
            // 
            // frmVisualizarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 476);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVisualizarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRelator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtribuido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGravidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGravidade;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblAtribuido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboRelator;
        private System.Windows.Forms.ComboBox cboPrioridade;
        private System.Windows.Forms.ComboBox cboAtribuido;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboGravidade;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOlhar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisualizar;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.BindingSource bsRelator;
        private System.Windows.Forms.BindingSource bsPrioridade;
        private System.Windows.Forms.BindingSource bsAtribuido;
        private System.Windows.Forms.BindingSource bsEstado;
        private System.Windows.Forms.BindingSource bsGravidade;
        private System.Windows.Forms.BindingSource bsCategoria;
        private System.Windows.Forms.Button btnFiltrar;
    }
}