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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.ConfirmRegButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.employeesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new RSPO.EmployeesDBDataSet();
            this.PasswordRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoginRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FIOLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ShiftRegLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PhotoRegButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.employeesTableTableAdapter = new RSPO.EmployeesDBDataSetTableAdapters.EmployeesTableTableAdapter();
            this.tableAdapterManager = new RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager();
            this.FirstNameRegBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LastNameRegBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MiddleNameRegBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginRegBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PassRegBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PictureRegBox = new System.Windows.Forms.PictureBox();
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
            this.PhotoRegButton.TabIndex = 7;
            this.PhotoRegButton.Text = "Обзор...";
            this.PhotoRegButton.UseVisualStyleBackColor = true;
            this.PhotoRegButton.Click += new System.EventHandler(this.PhotoRegButton_Click);
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
            this.shiftComboBox.TabIndex = 6;
            // 
            // employeesTableTableAdapter
            // 
            this.employeesTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableTableAdapter = this.employeesTableTableAdapter;
            this.tableAdapterManager.PistolTable1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FirstNameRegBox
            // 
            this.FirstNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "FirstName", true));
            this.FirstNameRegBox.Depth = 0;
            this.FirstNameRegBox.Hint = "First Name";
            this.FirstNameRegBox.Location = new System.Drawing.Point(100, 90);
            this.FirstNameRegBox.MaxLength = 32767;
            this.FirstNameRegBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstNameRegBox.Name = "FirstNameRegBox";
            this.FirstNameRegBox.PasswordChar = '\0';
            this.FirstNameRegBox.SelectedText = "";
            this.FirstNameRegBox.SelectionLength = 0;
            this.FirstNameRegBox.SelectionStart = 0;
            this.FirstNameRegBox.Size = new System.Drawing.Size(154, 23);
            this.FirstNameRegBox.TabIndex = 1;
            this.FirstNameRegBox.TabStop = false;
            this.FirstNameRegBox.UseSystemPasswordChar = false;
            // 
            // LastNameRegBox
            // 
            this.LastNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "LastName", true));
            this.LastNameRegBox.Depth = 0;
            this.LastNameRegBox.Hint = "Last Name";
            this.LastNameRegBox.Location = new System.Drawing.Point(288, 90);
            this.LastNameRegBox.MaxLength = 32767;
            this.LastNameRegBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastNameRegBox.Name = "LastNameRegBox";
            this.LastNameRegBox.PasswordChar = '\0';
            this.LastNameRegBox.SelectedText = "";
            this.LastNameRegBox.SelectionLength = 0;
            this.LastNameRegBox.SelectionStart = 0;
            this.LastNameRegBox.Size = new System.Drawing.Size(154, 23);
            this.LastNameRegBox.TabIndex = 2;
            this.LastNameRegBox.TabStop = false;
            this.LastNameRegBox.UseSystemPasswordChar = false;
            // 
            // MiddleNameRegBox
            // 
            this.MiddleNameRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "MiddleName", true));
            this.MiddleNameRegBox.Depth = 0;
            this.MiddleNameRegBox.Hint = "Middle Name";
            this.MiddleNameRegBox.Location = new System.Drawing.Point(477, 90);
            this.MiddleNameRegBox.MaxLength = 32767;
            this.MiddleNameRegBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MiddleNameRegBox.Name = "MiddleNameRegBox";
            this.MiddleNameRegBox.PasswordChar = '\0';
            this.MiddleNameRegBox.SelectedText = "";
            this.MiddleNameRegBox.SelectionLength = 0;
            this.MiddleNameRegBox.SelectionStart = 0;
            this.MiddleNameRegBox.Size = new System.Drawing.Size(154, 23);
            this.MiddleNameRegBox.TabIndex = 3;
            this.MiddleNameRegBox.TabStop = false;
            this.MiddleNameRegBox.UseSystemPasswordChar = false;
            // 
            // LoginRegBox
            // 
            this.LoginRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Login", true));
            this.LoginRegBox.Depth = 0;
            this.LoginRegBox.Hint = "Login";
            this.LoginRegBox.Location = new System.Drawing.Point(100, 132);
            this.LoginRegBox.MaxLength = 32767;
            this.LoginRegBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginRegBox.Name = "LoginRegBox";
            this.LoginRegBox.PasswordChar = '\0';
            this.LoginRegBox.SelectedText = "";
            this.LoginRegBox.SelectionLength = 0;
            this.LoginRegBox.SelectionStart = 0;
            this.LoginRegBox.Size = new System.Drawing.Size(100, 23);
            this.LoginRegBox.TabIndex = 4;
            this.LoginRegBox.TabStop = false;
            this.LoginRegBox.UseSystemPasswordChar = false;
            // 
            // PassRegBox
            // 
            this.PassRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Password", true));
            this.PassRegBox.Depth = 0;
            this.PassRegBox.Hint = "Password";
            this.PassRegBox.Location = new System.Drawing.Point(100, 170);
            this.PassRegBox.MaxLength = 32767;
            this.PassRegBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassRegBox.Name = "PassRegBox";
            this.PassRegBox.PasswordChar = '\0';
            this.PassRegBox.SelectedText = "";
            this.PassRegBox.SelectionLength = 0;
            this.PassRegBox.SelectionStart = 0;
            this.PassRegBox.Size = new System.Drawing.Size(100, 23);
            this.PassRegBox.TabIndex = 5;
            this.PassRegBox.TabStop = false;
            this.PassRegBox.UseSystemPasswordChar = true;
            // 
            // PictureRegBox
            // 
            this.PictureRegBox.BackColor = System.Drawing.SystemColors.Window;
            this.PictureRegBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesTableBindingSource, "Photo", true));
            this.PictureRegBox.Location = new System.Drawing.Point(240, 132);
            this.PictureRegBox.MaximumSize = new System.Drawing.Size(398, 210);
            this.PictureRegBox.Name = "PictureRegBox";
            this.PictureRegBox.Size = new System.Drawing.Size(398, 210);
            this.PictureRegBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureRegBox.TabIndex = 17;
            this.PictureRegBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.ConfirmRegButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.PassRegBox);
            this.Controls.Add(this.LoginRegBox);
            this.Controls.Add(this.MiddleNameRegBox);
            this.Controls.Add(this.LastNameRegBox);
            this.Controls.Add(this.FirstNameRegBox);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.PictureRegBox);
            this.Controls.Add(this.PhotoRegButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ShiftRegLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.PasswordRegLabel);
            this.Controls.Add(this.LoginRegLabel);
            this.Controls.Add(this.ConfirmRegButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private MaterialSkin.Controls.MaterialLabel PasswordRegLabel;
        private MaterialSkin.Controls.MaterialLabel LoginRegLabel;
        private MaterialSkin.Controls.MaterialLabel FIOLabel;
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
        private MaterialSkin.Controls.MaterialSingleLineTextField FirstNameRegBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField LastNameRegBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField MiddleNameRegBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginRegBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassRegBox;
    }
}