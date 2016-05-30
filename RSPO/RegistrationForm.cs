using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RSPO
{
    public partial class RegistrationForm : MaterialForm
    {
        MainForm MF2;
        public RegistrationForm(MainForm MF)
        {
            InitializeComponent();
            MF2 = MF;
            MF.Hide();


        }

        private void RegistrationForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            MF2.Show();
        }

        private void ConfirmRegButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeesTableBindingSource.EndEdit();
                employeesTableTableAdapter.Update(employeesDBDataSet);
                Close();

                MessageBox.Show("Ваши данные успешно внесены в БД", "Успех!", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void PhotoRegButton_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.InitialDirectory = @"D:\ONEKID\Pictures\";
            openFileDialogPhoto.Filter = "Изображения (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Все файлы (*.*)|*.*";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureRegBox.Image = Image.FromFile(openFileDialogPhoto.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка Открытия окна файлов: " + ex.Message);
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.EmployeesTable". При необходимости она может быть перемещена или удалена.
            this.employeesTableTableAdapter.Fill(this.employeesDBDataSet.EmployeesTable);
            employeesTableBindingSource.AddNew();
        }
    }
}
