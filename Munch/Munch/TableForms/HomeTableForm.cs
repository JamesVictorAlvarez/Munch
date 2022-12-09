using Munch.TableForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munch.Table
{
    public partial class HomeTableForm : Form
    {
        public HomeTableForm()
        {
            InitializeComponent();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            AddTableForm addTableForm = new AddTableForm();
            addTableForm.Show();
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            RemoveTableForm removeTableForm = new RemoveTableForm();
            removeTableForm.Show();
        }

        private void modifyTableButton_Click(object sender, EventArgs e)
        {
            ModifyTableForm modifyTableForm = new ModifyTableForm();
            modifyTableForm.Show();
        }
    }
}
