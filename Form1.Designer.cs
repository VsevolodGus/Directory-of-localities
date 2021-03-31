
namespace Справочник
{
    partial class Form1
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
            this.AddCountry = new System.Windows.Forms.Button();
            this.ListCountry = new System.Windows.Forms.ListBox();
            this.InputCountry = new System.Windows.Forms.TextBox();
            this.DeleteCountry = new System.Windows.Forms.Button();
            this.DeleteState = new System.Windows.Forms.Button();
            this.InputState = new System.Windows.Forms.TextBox();
            this.ListState = new System.Windows.Forms.ListBox();
            this.AddState = new System.Windows.Forms.Button();
            this.DeleteDistrict = new System.Windows.Forms.Button();
            this.InputDistrict = new System.Windows.Forms.TextBox();
            this.ListDistrict = new System.Windows.Forms.ListBox();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.DeleteTown = new System.Windows.Forms.Button();
            this.InputTown = new System.Windows.Forms.TextBox();
            this.ListTown = new System.Windows.Forms.ListBox();
            this.AddTown = new System.Windows.Forms.Button();
            this.Choice_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(29, 527);
            this.AddCountry.Margin = new System.Windows.Forms.Padding(4);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(105, 37);
            this.AddCountry.TabIndex = 0;
            this.AddCountry.Text = "Добавить";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // ListCountry
            // 
            this.ListCountry.FormattingEnabled = true;
            this.ListCountry.ItemHeight = 16;
            this.ListCountry.Location = new System.Drawing.Point(29, 68);
            this.ListCountry.Margin = new System.Windows.Forms.Padding(4);
            this.ListCountry.Name = "ListCountry";
            this.ListCountry.Size = new System.Drawing.Size(229, 420);
            this.ListCountry.TabIndex = 2;
            this.ListCountry.Tag = "";
            this.ListCountry.SelectedValueChanged += new System.EventHandler(this.ListCountry_SelectedValueChanged);
            // 
            // InputCountry
            // 
            this.InputCountry.Location = new System.Drawing.Point(41, 495);
            this.InputCountry.Margin = new System.Windows.Forms.Padding(4);
            this.InputCountry.Name = "InputCountry";
            this.InputCountry.Size = new System.Drawing.Size(201, 22);
            this.InputCountry.TabIndex = 4;
            this.InputCountry.TextChanged += new System.EventHandler(this.InputCountry_TextChanged);
            // 
            // DeleteCountry
            // 
            this.DeleteCountry.Location = new System.Drawing.Point(155, 527);
            this.DeleteCountry.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCountry.Name = "DeleteCountry";
            this.DeleteCountry.Size = new System.Drawing.Size(105, 37);
            this.DeleteCountry.TabIndex = 5;
            this.DeleteCountry.Text = "Удалить";
            this.DeleteCountry.UseVisualStyleBackColor = true;
            this.DeleteCountry.Click += new System.EventHandler(this.DeleteCountry_Click);
            // 
            // DeleteState
            // 
            this.DeleteState.Location = new System.Drawing.Point(413, 527);
            this.DeleteState.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteState.Name = "DeleteState";
            this.DeleteState.Size = new System.Drawing.Size(105, 37);
            this.DeleteState.TabIndex = 9;
            this.DeleteState.Text = "Удалить";
            this.DeleteState.UseVisualStyleBackColor = true;
            this.DeleteState.Click += new System.EventHandler(this.DeleteState_Click);
            // 
            // InputState
            // 
            this.InputState.Location = new System.Drawing.Point(300, 495);
            this.InputState.Margin = new System.Windows.Forms.Padding(4);
            this.InputState.Name = "InputState";
            this.InputState.Size = new System.Drawing.Size(201, 22);
            this.InputState.TabIndex = 8;
            this.InputState.TextChanged += new System.EventHandler(this.InputState_TextChanged);
            // 
            // ListState
            // 
            this.ListState.DisplayMember = "Title";
            this.ListState.FormattingEnabled = true;
            this.ListState.ItemHeight = 16;
            this.ListState.Location = new System.Drawing.Point(288, 68);
            this.ListState.Margin = new System.Windows.Forms.Padding(4);
            this.ListState.Name = "ListState";
            this.ListState.Size = new System.Drawing.Size(229, 420);
            this.ListState.TabIndex = 7;
            this.ListState.ValueMember = "Title";
            this.ListState.SelectedValueChanged += new System.EventHandler(this.ListState_SelectedValueChanged);
            // 
            // AddState
            // 
            this.AddState.Location = new System.Drawing.Point(288, 527);
            this.AddState.Margin = new System.Windows.Forms.Padding(4);
            this.AddState.Name = "AddState";
            this.AddState.Size = new System.Drawing.Size(105, 37);
            this.AddState.TabIndex = 6;
            this.AddState.Text = "Добавить";
            this.AddState.UseVisualStyleBackColor = true;
            this.AddState.Click += new System.EventHandler(this.AddState_Click);
            // 
            // DeleteDistrict
            // 
            this.DeleteDistrict.Location = new System.Drawing.Point(673, 527);
            this.DeleteDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteDistrict.Name = "DeleteDistrict";
            this.DeleteDistrict.Size = new System.Drawing.Size(105, 37);
            this.DeleteDistrict.TabIndex = 13;
            this.DeleteDistrict.Text = "Удалить";
            this.DeleteDistrict.UseVisualStyleBackColor = true;
            this.DeleteDistrict.Click += new System.EventHandler(this.DeleteDistrict_Click);
            // 
            // InputDistrict
            // 
            this.InputDistrict.Location = new System.Drawing.Point(560, 495);
            this.InputDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.InputDistrict.Name = "InputDistrict";
            this.InputDistrict.Size = new System.Drawing.Size(201, 22);
            this.InputDistrict.TabIndex = 12;
            this.InputDistrict.TextChanged += new System.EventHandler(this.InputDistrict_TextChanged);
            // 
            // ListDistrict
            // 
            this.ListDistrict.DisplayMember = "Title";
            this.ListDistrict.FormattingEnabled = true;
            this.ListDistrict.ItemHeight = 16;
            this.ListDistrict.Location = new System.Drawing.Point(548, 68);
            this.ListDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.ListDistrict.Name = "ListDistrict";
            this.ListDistrict.Size = new System.Drawing.Size(229, 420);
            this.ListDistrict.TabIndex = 11;
            this.ListDistrict.ValueMember = "Title";
            this.ListDistrict.SelectedValueChanged += new System.EventHandler(this.ListDistrict_SelectedValueChanged);
            // 
            // AddDistrict
            // 
            this.AddDistrict.Location = new System.Drawing.Point(548, 527);
            this.AddDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.AddDistrict.Name = "AddDistrict";
            this.AddDistrict.Size = new System.Drawing.Size(105, 37);
            this.AddDistrict.TabIndex = 10;
            this.AddDistrict.Text = "Добавить";
            this.AddDistrict.UseVisualStyleBackColor = true;
            this.AddDistrict.Click += new System.EventHandler(this.AddDistrict_Click);
            // 
            // DeleteTown
            // 
            this.DeleteTown.Location = new System.Drawing.Point(1053, 527);
            this.DeleteTown.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteTown.Name = "DeleteTown";
            this.DeleteTown.Size = new System.Drawing.Size(105, 37);
            this.DeleteTown.TabIndex = 17;
            this.DeleteTown.Text = "Удалить";
            this.DeleteTown.UseVisualStyleBackColor = true;
            this.DeleteTown.Click += new System.EventHandler(this.DeleteTown_Click);
            // 
            // InputTown
            // 
            this.InputTown.Location = new System.Drawing.Point(941, 495);
            this.InputTown.Margin = new System.Windows.Forms.Padding(4);
            this.InputTown.Name = "InputTown";
            this.InputTown.Size = new System.Drawing.Size(216, 22);
            this.InputTown.TabIndex = 16;
            this.InputTown.TextChanged += new System.EventHandler(this.InputTown_TextChanged);
            // 
            // ListTown
            // 
            this.ListTown.DisplayMember = "Title";
            this.ListTown.FormattingEnabled = true;
            this.ListTown.ItemHeight = 16;
            this.ListTown.Location = new System.Drawing.Point(831, 68);
            this.ListTown.Margin = new System.Windows.Forms.Padding(4);
            this.ListTown.Name = "ListTown";
            this.ListTown.Size = new System.Drawing.Size(327, 420);
            this.ListTown.TabIndex = 15;
            this.ListTown.ValueMember = "Title";
            // 
            // AddTown
            // 
            this.AddTown.Location = new System.Drawing.Point(831, 527);
            this.AddTown.Margin = new System.Windows.Forms.Padding(4);
            this.AddTown.Name = "AddTown";
            this.AddTown.Size = new System.Drawing.Size(105, 37);
            this.AddTown.TabIndex = 14;
            this.AddTown.Text = "Добавить";
            this.AddTown.UseVisualStyleBackColor = true;
            this.AddTown.Click += new System.EventHandler(this.AddSettlement_Click);
            // 
            // Choice_Type
            // 
            this.Choice_Type.FormattingEnabled = true;
            this.Choice_Type.Items.AddRange(new object[] {
            "г.",
            "пгт.",
            "с.",
            "ст.",
            "д.",
            "все"});
            this.Choice_Type.Location = new System.Drawing.Point(831, 494);
            this.Choice_Type.Margin = new System.Windows.Forms.Padding(4);
            this.Choice_Type.Name = "Choice_Type";
            this.Choice_Type.Size = new System.Drawing.Size(75, 24);
            this.Choice_Type.TabIndex = 18;
            this.Choice_Type.TextChanged += new System.EventHandler(this.Choice_Type_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Области";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(589, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Районы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(839, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Населенные пункты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Choice_Type);
            this.Controls.Add(this.DeleteTown);
            this.Controls.Add(this.InputTown);
            this.Controls.Add(this.ListTown);
            this.Controls.Add(this.AddTown);
            this.Controls.Add(this.DeleteDistrict);
            this.Controls.Add(this.InputDistrict);
            this.Controls.Add(this.ListDistrict);
            this.Controls.Add(this.AddDistrict);
            this.Controls.Add(this.DeleteState);
            this.Controls.Add(this.InputState);
            this.Controls.Add(this.ListState);
            this.Controls.Add(this.AddState);
            this.Controls.Add(this.DeleteCountry);
            this.Controls.Add(this.InputCountry);
            this.Controls.Add(this.ListCountry);
            this.Controls.Add(this.AddCountry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.ListBox ListCountry;
        private System.Windows.Forms.TextBox InputCountry;
        private System.Windows.Forms.Button DeleteCountry;
        private System.Windows.Forms.Button DeleteState;
        private System.Windows.Forms.TextBox InputState;
        private System.Windows.Forms.ListBox ListState;
        private System.Windows.Forms.Button AddState;
        private System.Windows.Forms.Button DeleteDistrict;
        private System.Windows.Forms.TextBox InputDistrict;
        private System.Windows.Forms.ListBox ListDistrict;
        private System.Windows.Forms.Button AddDistrict;
        private System.Windows.Forms.Button DeleteTown;
        private System.Windows.Forms.TextBox InputTown;
        private System.Windows.Forms.ListBox ListTown;
        private System.Windows.Forms.Button AddTown;
        private System.Windows.Forms.ComboBox Choice_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

