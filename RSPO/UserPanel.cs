using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace RSPO
{
    public partial class UserPanel : MaterialForm
    {
        MainForm MF2;
        public UserPanel(MainForm MF)
        {
            InitializeComponent();

            MF2 = MF;
            MF.Hide();

            this.MaximizeBox = false;
        }

        private void employeesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDBDataSet);

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.EmployeesTable". При необходимости она может быть перемещена или удалена.
            this.employeesTableTableAdapter.Fill(this.employeesDBDataSet.EmployeesTable);

        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            MF2.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            employeesTableBindingSource.RemoveCurrent();
            employeesTableTableAdapter.Update(employeesDBDataSet);
            this.employeesTableTableAdapter.Fill(employeesDBDataSet.EmployeesTable);
        }
    }
}
