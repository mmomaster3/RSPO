namespace RSPO
{
    partial class AZSForm
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel17 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange9 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange10 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeLabel aGaugeLabel18 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel19 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel20 = new System.Windows.Forms.AGaugeLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AZSForm));
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.aGauge3 = new System.Windows.Forms.AGauge();
            this.aGauge4 = new System.Windows.Forms.AGauge();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel17.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel17.Name = "GaugeLabel1";
            aGaugeLabel17.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel17.Text = "Gauge";
            this.aGauge1.GaugeLabels.Add(aGaugeLabel17);
            aGaugeRange9.Color = System.Drawing.Color.Red;
            aGaugeRange9.EndValue = 400F;
            aGaugeRange9.InnerRadius = 70;
            aGaugeRange9.InRange = false;
            aGaugeRange9.Name = "GaugeRange1";
            aGaugeRange9.OuterRadius = 80;
            aGaugeRange9.StartValue = 350F;
            aGaugeRange10.Color = System.Drawing.Color.Lime;
            aGaugeRange10.EndValue = 350F;
            aGaugeRange10.InnerRadius = 75;
            aGaugeRange10.InRange = false;
            aGaugeRange10.Name = "GaugeRange2";
            aGaugeRange10.OuterRadius = 80;
            aGaugeRange10.StartValue = 0F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange9);
            this.aGauge1.GaugeRanges.Add(aGaugeRange10);
            this.aGauge1.Location = new System.Drawing.Point(0, 64);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Indigo;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.DimGray;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.DimGray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel18.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel18.Name = "GaugeLabel1";
            aGaugeLabel18.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel18.Text = "Gauge";
            this.aGauge2.GaugeLabels.Add(aGaugeLabel18);
            this.aGauge2.Location = new System.Drawing.Point(211, 64);
            this.aGauge2.MaxValue = 400F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Indigo;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.DimGray;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.DimGray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(205, 180);
            this.aGauge2.TabIndex = 1;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel19.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel19.Name = "GaugeLabel1";
            aGaugeLabel19.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel19.Text = "Gauge";
            this.aGauge3.GaugeLabels.Add(aGaugeLabel19);
            this.aGauge3.Location = new System.Drawing.Point(422, 64);
            this.aGauge3.MaxValue = 400F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.Indigo;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.DimGray;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 50F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.DimGray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorTicks = 9;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 0;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(205, 180);
            this.aGauge3.TabIndex = 2;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 80;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 270;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel20.Color = System.Drawing.SystemColors.MenuHighlight;
            aGaugeLabel20.Name = "GaugeLabel1";
            aGaugeLabel20.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel20.Text = "Gauge";
            this.aGauge4.GaugeLabels.Add(aGaugeLabel20);
            this.aGauge4.Location = new System.Drawing.Point(633, 64);
            this.aGauge4.MaxValue = 400F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.Indigo;
            this.aGauge4.NeedleRadius = 80;
            this.aGauge4.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.DimGray;
            this.aGauge4.ScaleLinesInterInnerRadius = 73;
            this.aGauge4.ScaleLinesInterOuterRadius = 80;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 70;
            this.aGauge4.ScaleLinesMajorOuterRadius = 80;
            this.aGauge4.ScaleLinesMajorStepValue = 50F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.DimGray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 75;
            this.aGauge4.ScaleLinesMinorOuterRadius = 80;
            this.aGauge4.ScaleLinesMinorTicks = 9;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 95;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 0;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Size = new System.Drawing.Size(205, 180);
            this.aGauge4.TabIndex = 3;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 250);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(205, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(200, 18);
            this.materialTabControl1.Location = new System.Drawing.Point(5, 301);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(823, 180);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(815, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аи-92";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialCheckBox3);
            this.tabPage2.Controls.Add(this.materialCheckBox2);
            this.tabPage2.Controls.Add(this.materialCheckBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 154);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Аи-80";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(824, 38);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(6, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(704, 103);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = resources.GetString("materialRaisedButton1.Text");
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(16, 12);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(150, 30);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(16, 42);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(150, 30);
            this.materialCheckBox2.TabIndex = 1;
            this.materialCheckBox2.Text = "materialCheckBox2";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.AutoSize = true;
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox3.Location = new System.Drawing.Point(16, 72);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(150, 30);
            this.materialCheckBox3.TabIndex = 2;
            this.materialCheckBox3.Text = "materialCheckBox3";
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(815, 154);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ГАЗ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AZSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 484);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.aGauge4);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Name = "AZSForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.AGauge aGauge3;
        private System.Windows.Forms.AGauge aGauge4;
        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}