using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munch
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }


        private void addTableButton_Click(object sender, EventArgs e)
        {
            AddTable addTable = new AddTable();
            addTable.Show();
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            RemoveTable removeTable = new RemoveTable();
            removeTable.Show();
        }

        private void modifyTableButton_Click(object sender, EventArgs e)
        {
            ModifyTable modifyTable = new ModifyTable();
            modifyTable.Show();
        }

        private void ViewTablesButton_Click(object sender, EventArgs e)
        {
            ViewTables viewTables = new ViewTables();
            viewTables.Show();
        }

        private void searchTableButton_Click(object sender, EventArgs e)
        {
            SearchTable searchTable = new SearchTable();
            searchTable.Show();
        }
    }
}
