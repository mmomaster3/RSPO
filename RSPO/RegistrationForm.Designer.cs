namespace RSPO
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.ConfirmRegButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PassRegBox = new System.Windows.Forms.TextBox();
            this.employeesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new RSPO.EmployeesDBDataSet();
            this.LoginRegBox = new System.Windows.Forms.TextBox();
            this.PasswordRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoginRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FIOLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FirstNameRegBox = new System.Windows.Forms.TextBox();
            this.LastNameRegBox = new System.Windows.Forms.TextBox();
            this.MiddleNameRegBox = new System.Windows.Forms.TextBox();
            this.ShiftRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PhotoRegButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PictureRegBox = new System.Windows.Forms.PictureBox();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.employeesTableTableAdapter = new RSPO.EmployeesDBDataSetTableAdapters.EmployeesTableTableAdapter();
            this.tableAdapterManager = new RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRegBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmRegButton
            // 
            this.ConfirmRegButton.AutoSize = true;
            this.ConfirmRegButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmRegButton.Depth = 0;
            this.ConfirmRegButton.Location = new System.Drawing.Point(468, 351);
            this.ConfirmRegButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmRegButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmRegButton.Name = "ConfirmRegButton";
            this.ConfirmRegButton.Primary = false;
            this.ConfirmRegButton.Size = new System.Drawing.Size(170, 36);
            this.ConfirmRegButton.TabIndex = 0;
            this.ConfirmRegButton.Text = "Зарегистрироваться";
            this.ConfirmRegButton.UseVisualStyleBackColor = true;
            this.ConfirmRegButton.Click += new System.EventHandler(this.ConfirmRegButton_Click);
            // 
            // PassRegBox
            // 
            this.PassRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Password", true));
            this.PassRegBox.Location = new System.Drawing.Point(100, 173);
            this.PassRegBox.MaxLength = 10;
            this.PassRegBox.Name = "PassRegBox";
            this.PassRegBox.PasswordChar = '*';
            this.PassRegBox.Size = new System.Drawing.Size(100, 20);
            this.PassRegBox.TabIndex = 8;
            // 
            // employeesTableBindingSource
            // 
            this.employeesTableBindingSource.DataMember = "EmployeesTable";
            this.employeesTableBindingSource.DataSource = this.employeesDBDataSet;
            // 
            // employeesDBDataSet
            // 
            this.employeesDBDataSet.DataSetName = "EmployeesDBDataSet";
            this.employeesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginRegBox
            // 
            this.LoginRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Login", true));
            this.LoginRegBox.Location = new System.Drawing.Point(100, 133);
            this.LoginRegBox.MaxLength = 10;
            this.LoginRegBox.Name = "LoginRegBox";
            this.LoginRegBox.Size = new System.Drawing.Size(100, 20);
            this.LoginRegBox.TabIndex = 7;
            // 
            // PasswordRegLabel
            // 
            this.PasswordRegLabel.AutoSize = true;
            this.PasswordRegLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordRegLabel.Depth = 0;
            this.PasswordRegLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PasswordRegLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordRegLabel.Location = new System.Drawing.Point(21, 172);
            this.PasswordRegLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordRegLabel.Name = "PasswordRegLabel";
            this.PasswordRegLabel.Size = new System.Drawing.Size(62, 19);
            this.PasswordRegLabel.TabIndex = 6;
            this.PasswordRegLabel.Text = "Пароль";
            // 
            // LoginRegLabel
            // 
            this.LoginRegLabel.AutoSize = true;
            this.LoginRegLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LoginRegLabel.Depth = 0;
            this.LoginRegLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LoginRegLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginRegLabel.Location = new System.Drawing.Point(21, 132);
            this.LoginRegLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginRegLabel.Name = "LoginRegLabel";
            this.LoginRegLabel.Size = new System.Drawing.Size(53, 19);
            this.LoginRegLabel.TabIndex = 5;
            this.LoginRegLabel.Text = "Логин";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FIOLabel.Depth = 0;
            this.FIOLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FIOLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FIOLabel.Location = new System.Drawing.Point(21, 92);
            this.FIOLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(42, 19);
            this.FIOLabel.TabIndex = 9;
            this.FIOLabel.Text = "ФИО";
            // 
            // FirstNameRegBox
            // 
            this.FirstNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "FirstName", true));
            this.FirstNameRegBox.Location = new System.Drawing.Point(100, 93);
            this.FirstNameRegBox.MaxLength = 40;
            this.FirstNameRegBox.Name = "FirstNameRegBox";
            this.FirstNameRegBox.Size = new System.Drawing.Size(154, 20);
            this.FirstNameRegBox.TabIndex = 10;
            // 
            // LastNameRegBox
            // 
            this.LastNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "LastName", true));
            this.LastNameRegBox.Location = new System.Drawing.Point(288, 93);
            this.LastNameRegBox.MaxLength = 40;
            this.LastNameRegBox.Name = "LastNameRegBox";
            this.LastNameRegBox.Size = new System.Drawing.Size(154, 20);
            this.LastNameRegBox.TabIndex = 11;
            // 
            // MiddleNameRegBox
            // 
            this.MiddleNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "MiddleName", true));
            this.MiddleNameRegBox.Location = new System.Drawing.Point(477, 93);
            this.MiddleNameRegBox.MaxLength = 40;
            this.MiddleNameRegBox.Name = "MiddleNameRegBox";
            this.MiddleNameRegBox.Size = new System.Drawing.Size(154, 20);
            this.MiddleNameRegBox.TabIndex = 12;
            // 
            // ShiftRegLabel
            // 
            this.ShiftRegLabel.AutoSize = true;
            this.ShiftRegLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ShiftRegLabel.Depth = 0;
            this.ShiftRegLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ShiftRegLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShiftRegLabel.Location = new System.Drawing.Point(21, 212);
            this.ShiftRegLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShiftRegLabel.Name = "ShiftRegLabel";
            this.ShiftRegLabel.Size = new System.Drawing.Size(55, 19);
            this.ShiftRegLabel.TabIndex = 13;
            this.ShiftRegLabel.Text = "Смена";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 252);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Фото";
            // 
            // PhotoRegButton
            // 
            this.PhotoRegButton.Depth = 0;
            this.PhotoRegButton.Location = new System.Drawing.Point(100, 252);
            this.PhotoRegButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhotoRegButton.Name = "PhotoRegButton";
            this.PhotoRegButton.Primary = true;
            this.PhotoRegButton.Size = new System.Drawing.Size(75, 23);
            this.PhotoRegButton.TabIndex = 16;
            this.PhotoRegButton.Text = "Обзор...";
            this.PhotoRegButton.UseVisualStyleBackColor = true;
            this.PhotoRegButton.Click += new System.EventHandler(this.PhotoRegButton_Click);
            // 
            // PictureRegBox
            // 
            this.PictureRegBox.BackColor = System.Drawing.SystemColors.Window;
            this.PictureRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesTableBindingSource, "Photo", true));
            this.PictureRegBox.Location = new System.Drawing.Point(240, 132);
            this.PictureRegBox.MaximumSize = new System.Drawing.Size(398, 210);
            this.PictureRegBox.Name = "PictureRegBox";
            this.PictureRegBox.Size = new System.Drawing.Size(398, 210);
            this.PictureRegBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRegBox.TabIndex = 17;
            this.PictureRegBox.TabStop = false;
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Shift", true));
            this.shiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.shiftComboBox.Location = new System.Drawing.Point(100, 213);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(41, 21);
            this.shiftComboBox.TabIndex = 19;
            // 
            // employeesTableTableAdapter
            // 
            this.employeesTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableTableAdapter = this.employeesTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.ConfirmRegButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.PictureRegBox);
            this.Controls.Add(this.PhotoRegButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ShiftRegLabel);
            this.Controls.Add(this.MiddleNameRegBox);
            this.Controls.Add(this.LastNameRegBox);
            this.Controls.Add(this.FirstNameRegBox);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.PassRegBox);
            this.Controls.Add(this.LoginRegBox);
            this.Controls.Add(this.PasswordRegLabel);
            this.Controls.Add(this.LoginRegLabel);
            this.Controls.Add(this.ConfirmRegButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Присоединяйся к нам!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRegBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ConfirmRegButton;
        private System.Windows.Forms.TextBox PassRegBox;
        private System.Windows.Forms.TextBox LoginRegBox;
        private MaterialSkin.Controls.MaterialLabel PasswordRegLabel;
        private MaterialSkin.Controls.MaterialLabel LoginRegLabel;
        private MaterialSkin.Controls.MaterialLabel FIOLabel;
        private System.Windows.Forms.TextBox FirstNameRegBox;
        private System.Windows.Forms.TextBox LastNameRegBox;
        private System.Windows.Forms.TextBox MiddleNameRegBox;
        private MaterialSkin.Controls.MaterialLabel ShiftRegLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton PhotoRegButton;
        private System.Windows.Forms.PictureBox PictureRegBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private EmployeesDBDataSet employeesDBDataSet;
        private System.Windows.Forms.BindingSource employeesTableBindingSource;
        private EmployeesDBDataSetTableAdapters.EmployeesTableTableAdapter employeesTableTableAdapter;
        private EmployeesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox shiftComboBox;
    }
}