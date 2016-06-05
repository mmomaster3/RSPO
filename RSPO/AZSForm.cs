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
        MainForm MF;
        DateTime BeginWork = DateTime.Now;
        EmployeesDBDataSet.EmployeesTableRow colum;

        private static bool sellAi95, sellAi92, sellGaz, sellDisel;
        bool admin = false;

        public AZSForm(MainForm MF)
        {
            InitializeComponent();

            this.MF = MF;
            MF.Hide();

            sellAi95 = true;
            sellAi92 = true;
            sellGaz = true;
            sellDisel = true;

            MaterialTabSelector.TAB_HEADER_PADDING = 180;
            this.MaximumSize = new Size(841, 600);
            this.MinimumSize = new Size(841, 600);
            this.MaximizeBox = false;

            AGaugeRange LowRange = new AGaugeRange(Color.Lime, 0, 350, 75, 80);
            AGaugeRange HighRange = new AGaugeRange(Color.Red, 350, 400, 70, 80);

            var CC = tabPage1.Controls;
            Random r = new Random();
            foreach (var control in CC)
            {
                if (control is AGauge)
                {
                    (control as AGauge).GaugeRanges.Add(LowRange);
                    (control as AGauge).GaugeRanges.Add(HighRange);

                    (control as AGauge).Value = r.Next(20, 400);
                }
            }


        }

        public AZSForm(MainForm MF, bool admin) : this(MF)
        {
            this.admin = admin;
            timerPistols.Stop();
            TimerButton.Image = Properties.Resources.play_button;

            var CC = tabPage1.Controls;
            if (admin)
            {
                foreach (var control in CC)
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
                FioStatusLabel.Text = "GODMOD";
                pistolTable1BindingNavigator.Visible = true;
            }
        }

        public AZSForm(MainForm MF, EmployeesDBDataSet.EmployeesTableRow colum) : this(MF)
        {
            this.colum = colum;
            timerPistols.Start();
            FioStatusLabel.Text = "Работник: " + this.colum.FirstName + " " + this.colum.LastName + " " + this.colum.MiddleName;
            pistolTable1BindingNavigator.Visible = false;
        }

        private void AZSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!admin)
            {
                DateTime EndWork = DateTime.Now;
                TimeSpan raz = EndWork - BeginWork;
                this.colum.WorkTime = (int)raz.TotalMinutes;

                decimal totalM = 0;
                foreach (var tabelItem in pistolTable1TableAdapter.GetData())
                {
                    totalM += tabelItem.TotalM;
                }

                this.colum.Money = totalM;
                employeesTableTableAdapter1.Update(this.colum);
            }
            timerPistols.Stop();
            this.MF.Show();
        }

        private void timerPistols_Tick(object sender, EventArgs e)
        {

            if (sellAi92 == false && sellAi95 == false && sellDisel == false && sellGaz == false)
            {
                timerPistols.Stop();
                if (!admin)
                {
                    var result = MessageBox.Show(@"Если не начнешь продавать бензин, то лишишься работы!
Заправить все колонки?", "БОСС вами не доволен", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Вы уволены!", "БОСС");
                        Application.Exit();
                    }
                    else
                    {
                        aGaugeAi95.Value = aGaugeAi95.MaxValue;
                        sellAi95 = true;
                        aGaugeAi92.Value = aGaugeAi92.MaxValue;
                        sellAi92 = true;
                        aGaugeDisel.Value = aGaugeDisel.MaxValue;
                        sellDisel = true;
                        aGaugeGaz.Value = aGaugeGaz.MaxValue;
                        sellGaz = true;
                        MessageBox.Show("Молодец, так и продолжай работать!", "БОСС вами доволен");
                    }
                }
            }

            if (aGaugeAi95.Value < 5 && sellAi95)
            {
                timerPistols.Stop();
                var result = MessageBox.Show("Бензин АИ-95 закончился надо заказывать. Подтвердить покупку?", "АИ-95", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show(":(");
                    sellAi95 = false;
                }
                else
                {
                    aGaugeAi95.Value = aGaugeAi95.MaxValue;
                    MessageBox.Show("Отлично! Бак полон!");
                    sellAi95 = true;
                }
                timerPistols.Start();
            }

            if (aGaugeAi92.Value < 5 && sellAi92)
            {
                timerPistols.Stop();
                var result = MessageBox.Show("Бензин АИ-92 закончился надо заказывать. Подтвердить покупку?", "АИ-92", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show(":(");
                    sellAi92 = false;
                }
                else
                {
                    aGaugeAi92.Value = aGaugeAi92.MaxValue;
                    MessageBox.Show("Отлично! Бак полон!");
                    sellAi92 = true;
                }
                timerPistols.Start();
            }

            if (aGaugeDisel.Value < 5 && sellDisel)
            {
                timerPistols.Stop();
                var result = MessageBox.Show("Дизель закончился надо заказывать. Подтвердить покупку?", "Дизель", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show(":(");
                    sellDisel = false;
                }
                else
                {
                    aGaugeDisel.Value = aGaugeDisel.MaxValue;
                    MessageBox.Show("Отлично! Бак полон!");
                    sellDisel = true;
                }
                timerPistols.Start();
            }

            if (aGaugeGaz.Value < 5 && sellGaz)
            {
                timerPistols.Stop();
                var result = MessageBox.Show("ГАЗ закончился надо заказывать. Подтвердить покупку?", "Газ", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show(":(");
                    sellGaz = false;
                }
                else
                {
                    aGaugeGaz.Value = aGaugeGaz.MaxValue;
                    MessageBox.Show("Отлично! Бак полон!");
                    sellGaz = true;
                }
                timerPistols.Start();
            }


            Random r = new Random();
            int Ai95 = sellAi95 == true ? r.Next(0, 40) : 0;
            int Ai92 = sellAi92 == true ? r.Next(0, 40) : 0;
            int Disel = sellDisel == true ? r.Next(0, 40) : 0;
            int Gaz = sellGaz == true ? r.Next(0, 40) : 0;
            byte dispenser = (byte)r.Next(1, 6);

            aGaugeAi95.Value -= Ai95;
            aGaugeAi92.Value -= Ai92;
            aGaugeDisel.Value -= Disel;
            aGaugeGaz.Value -= Gaz;

            pistolTable1TableAdapter.Insert(DateTime.Now, Ai95, Ai92, Disel, Gaz, (Ai95 + Ai92 + Disel + Gaz), (Ai95 * int.Parse(Ai95Box.Text) + Ai92 * int.Parse(Ai92Box.Text) + Disel * int.Parse(DiselBox.Text) + Gaz * int.Parse(GazBox.Text)), dispenser);
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
            DeleteAll();
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
            DeleteAll();
        }

        private void DeleteAll()
        {
            if (pistolTable1TableAdapter.GetData().Any())
                foreach (var field in pistolTable1TableAdapter.GetData())
                {
                    pistolTable1BindingSource.RemoveCurrent();
                }
            pistolTable1TableAdapter.Update(this.employeesDBDataSet.PistolTable1);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            pistolTable1BindingSource.RemoveCurrent();
            pistolTable1TableAdapter.Update(employeesDBDataSet.PistolTable1);
        }
    }
}
