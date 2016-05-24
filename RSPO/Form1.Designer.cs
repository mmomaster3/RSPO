namespace RSPO
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Login = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegistrationButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableAdapterManager = new RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager();
            this.employeesTableTableAdapter = new RSPO.EmployeesDBDataSetTableAdapters.EmployeesTableTableAdapter();
            this.employeesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new RSPO.EmployeesDBDataSet();
            this.LoginBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PassBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.Depth = 0;
            this.Login.Location = new System.Drawing.Point(327, 230);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.Primary = false;
            this.Login.Size = new System.Drawing.Size(58, 36);
            this.Login.TabIndex = 0;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LoginLabel.Depth = 0;
            this.LoginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginLabel.Location = new System.Drawing.Point(12, 101);
            this.LoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(53, 19);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordLabel.Depth = 0;
            this.PasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 147);
            this.PasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Depth = 0;
            this.RegistrationButton.Location = new System.Drawing.Point(289, 26);
            this.RegistrationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Primary = true;
            this.RegistrationButton.Size = new System.Drawing.Size(108, 38);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableTableAdapter = this.employeesTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = RSPO.EmployeesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableTableAdapter
            // 
            this.employeesTableTableAdapter.ClearBeforeFill = true;
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
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Login", true));
            this.LoginBox.Depth = 0;
            this.LoginBox.Hint = "Login";
            this.LoginBox.Location = new System.Drawing.Point(81, 101);
            this.LoginBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PasswordChar = '\0';
            this.LoginBox.SelectedText = "";
            this.LoginBox.SelectionLength = 0;
            this.LoginBox.SelectionStart = 0;
            this.LoginBox.Size = new System.Drawing.Size(182, 23);
            this.LoginBox.TabIndex = 6;
            this.LoginBox.UseSystemPasswordChar = false;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.SystemColors.Window;
            this.PassBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Password", true));
            this.PassBox.Depth = 0;
            this.PassBox.Hint = "Password";
            this.PassBox.Location = new System.Drawing.Point(81, 147);
            this.PassBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '\0';
            this.PassBox.SelectedText = "";
            this.PassBox.SelectionLength = 0;
            this.PassBox.SelectionStart = 0;
            this.PassBox.Size = new System.Drawing.Size(182, 23);
            this.PassBox.TabIndex = 7;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(398, 281);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Login;
        private MaterialSkin.Controls.MaterialLabel LoginLabel;
        private MaterialSkin.Controls.MaterialLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialRaisedButton RegistrationButton;
        private EmployeesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EmployeesDBDataSetTableAdapters.EmployeesTableTableAdapter employeesTableTableAdapter;
        private System.Windows.Forms.BindingSource employeesTableBindingSource;
        private EmployeesDBDataSet employeesDBDataSet;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassBox;
    }
}

