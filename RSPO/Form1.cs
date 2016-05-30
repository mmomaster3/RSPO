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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            MaximumSize = new Size(Size.Width, Size.Height);
            MinimumSize = new Size(Size.Width, Size.Height);

            //MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            new RegistrationForm(this).ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            bool flag = false;
            bool admin = false;
            foreach (var item in employeesTableTableAdapter.GetData())
            {
                if ("admin" == LoginBox.Text && "admin" == PassBox.Text)
                {
                    new UserPanel(this).ShowDialog();
                    new AZSForm(this, "", admin = true).ShowDialog();
                    flag = true;
                    break;

                }
                if (item.Login == LoginBox.Text && item.Password == PassBox.Text)
                {
                    new AZSForm(this, item.FirstName + " " + item.LastName + " " + item.MiddleName, admin).ShowDialog();
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }
    }
}
