
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
            this.DeleteArea = new System.Windows.Forms.Button();
            this.InputArea = new System.Windows.Forms.TextBox();
            this.ListArea = new System.Windows.Forms.ListBox();
            this.AddArea = new System.Windows.Forms.Button();
            this.DeleteDistrict = new System.Windows.Forms.Button();
            this.InputDistrict = new System.Windows.Forms.TextBox();
            this.ListDistrict = new System.Windows.Forms.ListBox();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.DeleteSettlement = new System.Windows.Forms.Button();
            this.InputSettlement = new System.Windows.Forms.TextBox();
            this.ListSettlement = new System.Windows.Forms.ListBox();
            this.AddSettlement = new System.Windows.Forms.Button();
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
            // 
            // ListCountry
            // 
            this.ListCountry.DisplayMember = "Title";
            this.ListCountry.FormattingEnabled = true;
            this.ListCountry.ItemHeight = 16;
            this.ListCountry.Location = new System.Drawing.Point(29, 68);
            this.ListCountry.Margin = new System.Windows.Forms.Padding(4);
            this.ListCountry.Name = "ListCountry";
            this.ListCountry.Size = new System.Drawing.Size(229, 420);
            this.ListCountry.TabIndex = 2;
            this.ListCountry.ValueMember = "Title";
            // 
            // InputCountry
            // 
            this.InputCountry.Location = new System.Drawing.Point(41, 495);
            this.InputCountry.Margin = new System.Windows.Forms.Padding(4);
            this.InputCountry.Name = "InputCountry";
            this.InputCountry.Size = new System.Drawing.Size(201, 22);
            this.InputCountry.TabIndex = 4;
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
            // 
            // DeleteArea
            // 
            this.DeleteArea.Location = new System.Drawing.Point(413, 527);
            this.DeleteArea.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteArea.Name = "DeleteArea";
            this.DeleteArea.Size = new System.Drawing.Size(105, 37);
            this.DeleteArea.TabIndex = 9;
            this.DeleteArea.Text = "Удалить";
            this.DeleteArea.UseVisualStyleBackColor = true;
            // 
            // InputArea
            // 
            this.InputArea.Location = new System.Drawing.Point(300, 495);
            this.InputArea.Margin = new System.Windows.Forms.Padding(4);
            this.InputArea.Name = "InputArea";
            this.InputArea.Size = new System.Drawing.Size(201, 22);
            this.InputArea.TabIndex = 8;
            // 
            // ListArea
            // 
            this.ListArea.DisplayMember = "Title";
            this.ListArea.FormattingEnabled = true;
            this.ListArea.ItemHeight = 16;
            this.ListArea.Location = new System.Drawing.Point(288, 68);
            this.ListArea.Margin = new System.Windows.Forms.Padding(4);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(229, 420);
            this.ListArea.TabIndex = 7;
            this.ListArea.ValueMember = "Title";
            // 
            // AddArea
            // 
            this.AddArea.Location = new System.Drawing.Point(288, 527);
            this.AddArea.Margin = new System.Windows.Forms.Padding(4);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(105, 37);
            this.AddArea.TabIndex = 6;
            this.AddArea.Text = "Добавить";
            this.AddArea.UseVisualStyleBackColor = true;
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
            // 
            // InputDistrict
            // 
            this.InputDistrict.Location = new System.Drawing.Point(560, 495);
            this.InputDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.InputDistrict.Name = "InputDistrict";
            this.InputDistrict.Size = new System.Drawing.Size(201, 22);
            this.InputDistrict.TabIndex = 12;
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
            // 
            // DeleteSettlement
            // 
            this.DeleteSettlement.Location = new System.Drawing.Point(1053, 527);
            this.DeleteSettlement.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSettlement.Name = "DeleteSettlement";
            this.DeleteSettlement.Size = new System.Drawing.Size(105, 37);
            this.DeleteSettlement.TabIndex = 17;
            this.DeleteSettlement.Text = "Удалить";
            this.DeleteSettlement.UseVisualStyleBackColor = true;
            // 
            // InputSettlement
            // 
            this.InputSettlement.Location = new System.Drawing.Point(941, 495);
            this.InputSettlement.Margin = new System.Windows.Forms.Padding(4);
            this.InputSettlement.Name = "InputSettlement";
            this.InputSettlement.Size = new System.Drawing.Size(216, 22);
            this.InputSettlement.TabIndex = 16;
            // 
            // ListSettlement
            // 
            this.ListSettlement.DisplayMember = "Title";
            this.ListSettlement.FormattingEnabled = true;
            this.ListSettlement.ItemHeight = 16;
            this.ListSettlement.Location = new System.Drawing.Point(831, 68);
            this.ListSettlement.Margin = new System.Windows.Forms.Padding(4);
            this.ListSettlement.Name = "ListSettlement";
            this.ListSettlement.Size = new System.Drawing.Size(327, 420);
            this.ListSettlement.TabIndex = 15;
            this.ListSettlement.ValueMember = "Title";
            // 
            // AddSettlement
            // 
            this.AddSettlement.Location = new System.Drawing.Point(831, 527);
            this.AddSettlement.Margin = new System.Windows.Forms.Padding(4);
            this.AddSettlement.Name = "AddSettlement";
            this.AddSettlement.Size = new System.Drawing.Size(105, 37);
            this.AddSettlement.TabIndex = 14;
            this.AddSettlement.Text = "Добавить";
            this.AddSettlement.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.DeleteSettlement);
            this.Controls.Add(this.InputSettlement);
            this.Controls.Add(this.ListSettlement);
            this.Controls.Add(this.AddSettlement);
            this.Controls.Add(this.DeleteDistrict);
            this.Controls.Add(this.InputDistrict);
            this.Controls.Add(this.ListDistrict);
            this.Controls.Add(this.AddDistrict);
            this.Controls.Add(this.DeleteArea);
            this.Controls.Add(this.InputArea);
            this.Controls.Add(this.ListArea);
            this.Controls.Add(this.AddArea);
            this.Controls.Add(this.DeleteCountry);
            this.Controls.Add(this.InputCountry);
            this.Controls.Add(this.ListCountry);
            this.Controls.Add(this.AddCountry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Справочник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.ListBox ListCountry;
        private System.Windows.Forms.TextBox InputCountry;
        private System.Windows.Forms.Button DeleteCountry;
        private System.Windows.Forms.Button DeleteArea;
        private System.Windows.Forms.TextBox InputArea;
        private System.Windows.Forms.ListBox ListArea;
        private System.Windows.Forms.Button AddArea;
        private System.Windows.Forms.Button DeleteDistrict;
        private System.Windows.Forms.TextBox InputDistrict;
        private System.Windows.Forms.ListBox ListDistrict;
        private System.Windows.Forms.Button AddDistrict;
        private System.Windows.Forms.Button DeleteSettlement;
        private System.Windows.Forms.TextBox InputSettlement;
        private System.Windows.Forms.ListBox ListSettlement;
        private System.Windows.Forms.Button AddSettlement;
        private System.Windows.Forms.ComboBox Choice_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

