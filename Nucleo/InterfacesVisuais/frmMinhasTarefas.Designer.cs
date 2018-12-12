namespace InterfacesVisuais
{
    partial class frmMinhasTarefas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAtribuidos = new System.Windows.Forms.Label();
            this.lblResolvidos = new System.Windows.Forms.Label();
            this.dgvAtribuidos = new System.Windows.Forms.DataGridView();
            this.dgvResolvidos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtribuidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolvidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvResolvidos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAtribuidos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResolvidos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAtribuidos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAtribuidos
            // 
            this.lblAtribuidos.AutoSize = true;
            this.lblAtribuidos.Font = new System.Drawing.Font("Segoe UI Symbol", 18F);
            this.lblAtribuidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtribuidos.Location = new System.Drawing.Point(3, 0);
            this.lblAtribuidos.Name = "lblAtribuidos";
            this.lblAtribuidos.Size = new System.Drawing.Size(124, 30);
            this.lblAtribuidos.TabIndex = 0;
            this.lblAtribuidos.Text = "Atribuídos";
            // 
            // lblResolvidos
            // 
            this.lblResolvidos.AutoSize = true;
            this.lblResolvidos.Font = new System.Drawing.Font("Segoe UI Symbol", 18F);
            this.lblResolvidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResolvidos.Location = new System.Drawing.Point(3, 256);
            this.lblResolvidos.Name = "lblResolvidos";
            this.lblResolvidos.Size = new System.Drawing.Size(128, 30);
            this.lblResolvidos.TabIndex = 1;
            this.lblResolvidos.Text = "Resolvidos";
            // 
            // dgvAtribuidos
            // 
            this.dgvAtribuidos.AllowUserToAddRows = false;
            this.dgvAtribuidos.AllowUserToDeleteRows = false;
            this.dgvAtribuidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtribuidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtribuidos.Location = new System.Drawing.Point(3, 33);
            this.dgvAtribuidos.Name = "dgvAtribuidos";
            this.dgvAtribuidos.ReadOnly = true;
            this.dgvAtribuidos.Size = new System.Drawing.Size(808, 220);
            this.dgvAtribuidos.TabIndex = 2;
            // 
            // dgvResolvidos
            // 
            this.dgvResolvidos.AllowUserToAddRows = false;
            this.dgvResolvidos.AllowUserToDeleteRows = false;
            this.dgvResolvidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResolvidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResolvidos.Location = new System.Drawing.Point(3, 289);
            this.dgvResolvidos.Name = "dgvResolvidos";
            this.dgvResolvidos.ReadOnly = true;
            this.dgvResolvidos.Size = new System.Drawing.Size(808, 223);
            this.dgvResolvidos.TabIndex = 3;
            // 
            // frmMinhasTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMinhasTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtribuidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResolvidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAtribuidos;
        private System.Windows.Forms.DataGridView dgvResolvidos;
        private System.Windows.Forms.Label lblResolvidos;
        private System.Windows.Forms.DataGridView dgvAtribuidos;
    }
}