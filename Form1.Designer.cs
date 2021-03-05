
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
            this.components = new System.ComponentModel.Container();
            this.AddCountry = new System.Windows.Forms.Button();
            this.ListCountry = new System.Windows.Forms.ListBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_населенных_пунктовDataSet = new Справочник.Список_населенных_пунктовDataSet();
            this.InputCountry = new System.Windows.Forms.TextBox();
            this.DeleteCountry = new System.Windows.Forms.Button();
            this.DeleteArea = new System.Windows.Forms.Button();
            this.InputArea = new System.Windows.Forms.TextBox();
            this.ListArea = new System.Windows.Forms.ListBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_населенных_пунктовDataSet1 = new Справочник.Список_населенных_пунктовDataSet1();
            this.AddArea = new System.Windows.Forms.Button();
            this.DeleteDistrict = new System.Windows.Forms.Button();
            this.InputDistrict = new System.Windows.Forms.TextBox();
            this.ListDistrict = new System.Windows.Forms.ListBox();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_населенных_пунктовDataSet2 = new Справочник.Список_населенных_пунктовDataSet2();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.DeleteSettlement = new System.Windows.Forms.Button();
            this.InputSettlement = new System.Windows.Forms.TextBox();
            this.ListSettlement = new System.Windows.Forms.ListBox();
            this.settlementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_населенных_пунктовDataSet3 = new Справочник.Список_населенных_пунктовDataSet3();
            this.AddSettlement = new System.Windows.Forms.Button();
            this.Choice_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countryTableAdapter = new Справочник.Список_населенных_пунктовDataSetTableAdapters.CountryTableAdapter();
            this.areaTableAdapter = new Справочник.Список_населенных_пунктовDataSet1TableAdapters.AreaTableAdapter();
            this.districtTableAdapter = new Справочник.Список_населенных_пунктовDataSet2TableAdapters.DistrictTableAdapter();
            this.settlementTableAdapter = new Справочник.Список_населенных_пунктовDataSet3TableAdapters.SettlementTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(22, 428);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(79, 30);
            this.AddCountry.TabIndex = 0;
            this.AddCountry.Text = "Добавить";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // ListCountry
            // 
            this.ListCountry.DataSource = this.countryBindingSource;
            this.ListCountry.DisplayMember = "Title";
            this.ListCountry.FormattingEnabled = true;
            this.ListCountry.Location = new System.Drawing.Point(22, 55);
            this.ListCountry.Name = "ListCountry";
            this.ListCountry.Size = new System.Drawing.Size(173, 342);
            this.ListCountry.TabIndex = 2;
            this.ListCountry.ValueMember = "Title";
            this.ListCountry.SelectedValueChanged += new System.EventHandler(this.ListCountry_SelectedValueChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.список_населенных_пунктовDataSet;
            // 
            // список_населенных_пунктовDataSet
            // 
            this.список_населенных_пунктовDataSet.DataSetName = "Список_населенных_пунктовDataSet";
            this.список_населенных_пунктовDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InputCountry
            // 
            this.InputCountry.Location = new System.Drawing.Point(31, 402);
            this.InputCountry.Name = "InputCountry";
            this.InputCountry.Size = new System.Drawing.Size(152, 20);
            this.InputCountry.TabIndex = 4;
            this.InputCountry.TextChanged += new System.EventHandler(this.InputCountry_TextChanged);
            // 
            // DeleteCountry
            // 
            this.DeleteCountry.Location = new System.Drawing.Point(116, 428);
            this.DeleteCountry.Name = "DeleteCountry";
            this.DeleteCountry.Size = new System.Drawing.Size(79, 30);
            this.DeleteCountry.TabIndex = 5;
            this.DeleteCountry.Text = "Удалить";
            this.DeleteCountry.UseVisualStyleBackColor = true;
            this.DeleteCountry.Click += new System.EventHandler(this.DeleteCountry_Click);
            // 
            // DeleteArea
            // 
            this.DeleteArea.Location = new System.Drawing.Point(310, 428);
            this.DeleteArea.Name = "DeleteArea";
            this.DeleteArea.Size = new System.Drawing.Size(79, 30);
            this.DeleteArea.TabIndex = 9;
            this.DeleteArea.Text = "Удалить";
            this.DeleteArea.UseVisualStyleBackColor = true;
            this.DeleteArea.Click += new System.EventHandler(this.DeleteArea_Click);
            // 
            // InputArea
            // 
            this.InputArea.Location = new System.Drawing.Point(225, 402);
            this.InputArea.Name = "InputArea";
            this.InputArea.Size = new System.Drawing.Size(152, 20);
            this.InputArea.TabIndex = 8;
            this.InputArea.TextChanged += new System.EventHandler(this.InputArea_TextChanged);
            // 
            // ListArea
            // 
            this.ListArea.DataSource = this.areaBindingSource;
            this.ListArea.DisplayMember = "Title";
            this.ListArea.FormattingEnabled = true;
            this.ListArea.Location = new System.Drawing.Point(216, 55);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(173, 342);
            this.ListArea.TabIndex = 7;
            this.ListArea.ValueMember = "Title";
            this.ListArea.SelectedValueChanged += new System.EventHandler(this.ListArea_SelectedValueChanged);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.список_населенных_пунктовDataSet1;
            // 
            // список_населенных_пунктовDataSet1
            // 
            this.список_населенных_пунктовDataSet1.DataSetName = "Список_населенных_пунктовDataSet1";
            this.список_населенных_пунктовDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddArea
            // 
            this.AddArea.Location = new System.Drawing.Point(216, 428);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(79, 30);
            this.AddArea.TabIndex = 6;
            this.AddArea.Text = "Добавить";
            this.AddArea.UseVisualStyleBackColor = true;
            this.AddArea.Click += new System.EventHandler(this.AddArea_Click);
            // 
            // DeleteDistrict
            // 
            this.DeleteDistrict.Location = new System.Drawing.Point(505, 428);
            this.DeleteDistrict.Name = "DeleteDistrict";
            this.DeleteDistrict.Size = new System.Drawing.Size(79, 30);
            this.DeleteDistrict.TabIndex = 13;
            this.DeleteDistrict.Text = "Удалить";
            this.DeleteDistrict.UseVisualStyleBackColor = true;
            this.DeleteDistrict.Click += new System.EventHandler(this.DeleteDistrict_Click);
            // 
            // InputDistrict
            // 
            this.InputDistrict.Location = new System.Drawing.Point(420, 402);
            this.InputDistrict.Name = "InputDistrict";
            this.InputDistrict.Size = new System.Drawing.Size(152, 20);
            this.InputDistrict.TabIndex = 12;
            this.InputDistrict.TextChanged += new System.EventHandler(this.InputDistrict_TextChanged);
            // 
            // ListDistrict
            // 
            this.ListDistrict.DataSource = this.districtBindingSource;
            this.ListDistrict.DisplayMember = "Title";
            this.ListDistrict.FormattingEnabled = true;
            this.ListDistrict.Location = new System.Drawing.Point(411, 55);
            this.ListDistrict.Name = "ListDistrict";
            this.ListDistrict.Size = new System.Drawing.Size(173, 342);
            this.ListDistrict.TabIndex = 11;
            this.ListDistrict.ValueMember = "Title";
            this.ListDistrict.SelectedValueChanged += new System.EventHandler(this.ListDistrict_SelectedValueChanged);
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataMember = "District";
            this.districtBindingSource.DataSource = this.список_населенных_пунктовDataSet2;
            // 
            // список_населенных_пунктовDataSet2
            // 
            this.список_населенных_пунктовDataSet2.DataSetName = "Список_населенных_пунктовDataSet2";
            this.список_населенных_пунктовDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddDistrict
            // 
            this.AddDistrict.Location = new System.Drawing.Point(411, 428);
            this.AddDistrict.Name = "AddDistrict";
            this.AddDistrict.Size = new System.Drawing.Size(79, 30);
            this.AddDistrict.TabIndex = 10;
            this.AddDistrict.Text = "Добавить";
            this.AddDistrict.UseVisualStyleBackColor = true;
            this.AddDistrict.Click += new System.EventHandler(this.AddDistrict_Click);
            // 
            // DeleteSettlement
            // 
            this.DeleteSettlement.Location = new System.Drawing.Point(790, 428);
            this.DeleteSettlement.Name = "DeleteSettlement";
            this.DeleteSettlement.Size = new System.Drawing.Size(79, 30);
            this.DeleteSettlement.TabIndex = 17;
            this.DeleteSettlement.Text = "Удалить";
            this.DeleteSettlement.UseVisualStyleBackColor = true;
            this.DeleteSettlement.Click += new System.EventHandler(this.DeleteSettlement_Click);
            // 
            // InputSettlement
            // 
            this.InputSettlement.Location = new System.Drawing.Point(706, 402);
            this.InputSettlement.Name = "InputSettlement";
            this.InputSettlement.Size = new System.Drawing.Size(163, 20);
            this.InputSettlement.TabIndex = 16;
            this.InputSettlement.TextChanged += new System.EventHandler(this.InputSettlement_TextChanged);
            // 
            // ListSettlement
            // 
            this.ListSettlement.DataSource = this.settlementBindingSource;
            this.ListSettlement.DisplayMember = "Title";
            this.ListSettlement.FormattingEnabled = true;
            this.ListSettlement.Location = new System.Drawing.Point(623, 55);
            this.ListSettlement.Name = "ListSettlement";
            this.ListSettlement.Size = new System.Drawing.Size(246, 342);
            this.ListSettlement.TabIndex = 15;
            this.ListSettlement.ValueMember = "Title";
            // 
            // settlementBindingSource
            // 
            this.settlementBindingSource.DataMember = "Settlement";
            this.settlementBindingSource.DataSource = this.список_населенных_пунктовDataSet3;
            // 
            // список_населенных_пунктовDataSet3
            // 
            this.список_населенных_пунктовDataSet3.DataSetName = "Список_населенных_пунктовDataSet3";
            this.список_населенных_пунктовDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddSettlement
            // 
            this.AddSettlement.Location = new System.Drawing.Point(623, 428);
            this.AddSettlement.Name = "AddSettlement";
            this.AddSettlement.Size = new System.Drawing.Size(79, 30);
            this.AddSettlement.TabIndex = 14;
            this.AddSettlement.Text = "Добавить";
            this.AddSettlement.UseVisualStyleBackColor = true;
            this.AddSettlement.Click += new System.EventHandler(this.AddSettlement_Click);
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
            this.Choice_Type.Location = new System.Drawing.Point(623, 401);
            this.Choice_Type.Name = "Choice_Type";
            this.Choice_Type.Size = new System.Drawing.Size(57, 21);
            this.Choice_Type.TabIndex = 18;
            this.Choice_Type.TextChanged += new System.EventHandler(this.ListDistrict_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(245, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Области";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(442, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Районы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(629, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Населенные пункты";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // districtTableAdapter
            // 
            this.districtTableAdapter.ClearBeforeFill = true;
            // 
            // settlementTableAdapter
            // 
            this.settlementTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 473);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_населенных_пунктовDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Список_населенных_пунктовDataSet список_населенных_пунктовDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Список_населенных_пунктовDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private Список_населенных_пунктовDataSet1 список_населенных_пунктовDataSet1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private Список_населенных_пунктовDataSet1TableAdapters.AreaTableAdapter areaTableAdapter;
        private Список_населенных_пунктовDataSet2 список_населенных_пунктовDataSet2;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private Список_населенных_пунктовDataSet2TableAdapters.DistrictTableAdapter districtTableAdapter;
        private Список_населенных_пунктовDataSet3 список_населенных_пунктовDataSet3;
        private System.Windows.Forms.BindingSource settlementBindingSource;
        private Список_населенных_пунктовDataSet3TableAdapters.SettlementTableAdapter settlementTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

