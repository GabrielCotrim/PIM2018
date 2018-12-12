using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nucleo.Utilitarios
{
    public class HelperDataGrid
    {

        public DataGridView DataGrid { get; private set; }

        public HelperDataGrid(DataGridView dataGrid)
        {
            DataGrid = dataGrid;
            FormateDataGrid();
        }

        public void FormateDataGrid()
        {
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeColumns = true;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGrid.Margin = new Padding(0);
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGrid.ScrollBars = ScrollBars.Vertical;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public DataGridViewColumn CrieColuna(string headerText ,string nomeDaPropriedade)
        {
            var coluna = new DataGridViewTextBoxColumn();
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coluna.DataPropertyName = nomeDaPropriedade;
            coluna.HeaderText = headerText;
            coluna.Name = nomeDaPropriedade;
            DataGrid.Columns.Add(coluna);
            return coluna;
        }
    }
}
