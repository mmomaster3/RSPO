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
        public AZSForm(MaterialForm MF)
        {
            InitializeComponent();

            AGaugeRange LowRange = new AGaugeRange(Color.Lime, 0, 350, 75, 80);
            AGaugeRange HighRange = new AGaugeRange(Color.Red, 350, 400, 70, 80);

            var CC = this.Controls;

            foreach (var control in CC)
            {
                if (control is AGauge)
                {
                    (control as AGauge).GaugeRanges.Add(LowRange);
                    (control as AGauge).GaugeRanges.Add(HighRange);
                }
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;
        }
    }
}
