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
    public partial class AZSForm : MaterialForm
    {
        MainForm MF2;

        public AZSForm(MainForm MF, string login, bool admin)
        {
            InitializeComponent();

            MaterialTabSelector.TAB_HEADER_PADDING = 26;
            this.MaximumSize = new Size(841, 600);
            this.MinimumSize = new Size(841, 600);

            MF2 = MF;
            MF.Hide();

            this.MaximizeBox = false;

            AGaugeRange LowRange = new AGaugeRange(Color.Lime, 0, 350, 75, 80);
            AGaugeRange HighRange = new AGaugeRange(Color.Red, 350, 400, 70, 80);

            var CC = this.Controls;
            Random r = new Random();
            foreach (var control in CC)
            {
                if (control is AGauge)
                {
                    (control as AGauge).GaugeRanges.Add(LowRange);
                    (control as AGauge).GaugeRanges.Add(HighRange);

                    (control as AGauge).Value = r.Next(20, 400);

                }
                if (admin)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Enabled = true;
                    }

                    if (control is Button)
                    {
                        (control as Button).Visible = true;
                    }
                }
            }

            FioStatusLabel.Text = admin == false ? "Работник: " + login : "GODMOD";
            if (admin)
            {
                pistolTable1BindingNavigator.Visible = true;

            }
            timerPistols.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            aGaugeAi95.Value = trackBar1.Value;
        }

        private void AZSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerPistols.Stop();
            MF2.Show();
        }

        private static bool sellAi95 = true;
        private static bool sellAi92 = true;
        private static bool sellGaz = true;
        private static bool sellDisel = true;

        private void timerPistols_Tick(object sender, EventArgs e)
        {
            if (aGaugeAi95.Value < 5 && sellAi95)
            {
                timerPistols.Stop();
                var result = MessageBox.Show("Бензин АИ-95 закончился надо заказывать. Подтвердить покупку?", "АИ-95", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show(":(");
                    sellAi95 = false;
                }
                timerPistols.Start();
            }

            Random r = new Random();
            int Ai95 = r.Next(0, 40);
            int Ai92 = r.Next(0, 40);
            int Disel = r.Next(0, 40);
            int Gaz = r.Next(0, 40);
            aGaugeAi95.Value -= Ai95;
            aGaugeAi92.Value -= Ai92;
            aGaugeDisel.Value -= Disel;
            aGaugeGaz.Value -= Gaz;

            pistolTable1TableAdapter.Insert(DateTime.Now, Ai95, Ai92, Disel, Gaz, (Ai95 + Ai92 + Disel + Gaz), (Ai95 * int.Parse(Ai95Box.Text) + Ai92 * int.Parse(Ai92Box.Text) + Disel * int.Parse(DiselBox.Text) + Gaz * int.Parse(GazBox.Text)));
            pistolTable1TableAdapter.Fill(this.employeesDBDataSet.PistolTable1);

            pistolTable1BindingSource.MoveLast();
        }

        private void pistolTable1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistolTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDBDataSet);

        }

        private void AZSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDBDataSet.PistolTable1". При необходимости она может быть перемещена или удалена.
            this.pistolTable1TableAdapter.Fill(this.employeesDBDataSet.PistolTable1);
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (!timerPistols.Enabled)
            {
                TimerButton.Image = Properties.Resources.stop;
                timerPistols.Start();
            }
            else
            {
                TimerButton.Image = Properties.Resources.play_button;
                timerPistols.Stop();
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            foreach (var field in pistolTable1TableAdapter.GetData())
            {
                pistolTable1BindingSource.RemoveCurrent();
            }
            pistolTable1TableAdapter.Update(this.employeesDBDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            pistolTable1BindingSource.RemoveCurrent();
            pistolTable1TableAdapter.Update(employeesDBDataSet.PistolTable1);//try
            this.pistolTable1TableAdapter.Fill(this.employeesDBDataSet.PistolTable1);
        }
    }
}
