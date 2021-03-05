using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Справочник
{
    public partial class Form1 : Form
    {
        SqlConnection SqlData = null;
        bool Begin = false;
        public Form1()
        {
            InitializeComponent();
        }

        // считывание с базы данных в список , который запишут в listbox
        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "список_населенных_пунктовDataSet3.Settlement". При необходимости она может быть перемещена или удалена.
            this.settlementTableAdapter.Fill(this.список_населенных_пунктовDataSet3.Settlement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "список_населенных_пунктовDataSet2.District". При необходимости она может быть перемещена или удалена.
            this.districtTableAdapter.Fill(this.список_населенных_пунктовDataSet2.District);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "список_населенных_пунктовDataSet1.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.список_населенных_пунктовDataSet1.Area);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "список_населенных_пунктовDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.список_населенных_пунктовDataSet.Country);

            //Справочник.Properties.Settings[""]
            /// подключаемся к базе данных
            string connectionString =
       @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\С# coding\Справочник\Список_населенных_пунктов.mdf;Integrated Security=True";
            SqlData = new SqlConnection(connectionString);
            SqlData.Open();
            Begin = true;


            Choice_Type.Text = "все";
            ListArea.DataSource = ChangeSelected(
                                       "Area", "CountrY", ListCountry.SelectedValue.ToString());
            ListDistrict.DataSource = ChangeSelected(
                                        "District", "AreA", ListArea.SelectedValue.ToString());
            ListSettlement.DataSource = ChangeSelected(
                                            "Settlement", "DistricT", ListDistrict.SelectedValue.ToString());

        }


        /////////////
        /// добавление элементов в LISTBOX-ы
        ////////////

        private bool SimiliarItems(ListBox listBox, TextBox textBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].ToString() == textBox.Text)
                    return false;
            }
            return true;
        }
        //на пустоту textBox-ов
        private bool Empty_Input(TextBox textBox, ListBox listBox)
        {
            if (textBox.Text != "" && SimiliarItems(listBox, textBox)) // если не пустая то даем добро на добавление
                return true;
            else
            {
                if (!SimiliarItems(listBox, textBox))
                {
                    DialogResult result = MessageBox.Show("Такой элемент уже есть!", "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    textBox.Text = "";
                }
                else
                {
                    /// выводим напоминалку и запрещаем добавлять
                    DialogResult result = MessageBox.Show("Введите название!", "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                return false;
            }
        }

        // считывание Title с базы данных в список  , который запишут в listbox
        List<string> WildcardFiles(string Table)
        {
            SqlCommand command = new SqlCommand($"SELECT Title FROM {Table} ", SqlData);
            return ReturnListForReader(command);
        }

        // функции для добавление элментов в базы данных Областей/Area и Районов/District 
        private void Add_Area_or_District(TextBox textBox, ListBox listBox, ListBox listBox1, string Table, string Column)
        {
            if (Empty_Input(textBox, listBox1))
            {
                SqlCommand command = new SqlCommand($"INSERT INTO[{Table}](Title, {Column}) VALUES(@Title, @{Column})", SqlData);
                //  после 1-ого использования соединение listbox с БЗ прерывается и нужно считывать уже по Items
                command.Parameters.AddWithValue("Title", textBox.Text);// добавляем название    
                command.Parameters.AddWithValue(Column, listBox.SelectedValue);// считывание Value
                textBox.Text = string.Empty;
               command.ExecuteNonQuery();
                listBox1.DataSource = WildcardFiles(Table);
                CheckSelectedOldPlace();
            }
        }

        // добавляем страны 
        private void AddCountry_Click(object sender, EventArgs e)
        {
            if (Empty_Input(InputCountry, ListCountry))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Country] (Title) VALUES (@Title)", SqlData);
                command.Parameters.AddWithValue("Title", InputCountry.Text);// добавляем название страны
                InputCountry.Text = string.Empty;
                command.ExecuteNonQuery();
                ListCountry.DataSource = WildcardFiles("Country");
                CheckSelectedOldPlace();
            }
        }

        // добавляем области 
        private void AddArea_Click(object sender, EventArgs e)
        {
            // нужно определиться с иерархией UseList
            Add_Area_or_District(InputArea, ListCountry, ListArea, "Area", "CountrY");
            ListArea.DataSource = ListDistrict.DataSource = ChangeSelected(
                                                                "Area", "CountrY", ListCountry.SelectedValue.ToString());
        }
        // добавляем районы
        private void AddDistrict_Click(object sender, EventArgs e)
        {
            Add_Area_or_District(InputDistrict, ListArea, ListDistrict, "District", "AreA");
            ListDistrict.DataSource = ChangeSelected(
                                            "District", "AreA", ListArea.SelectedValue.ToString());
        }
        // добавляем населенные пункты 
        private void AddSettlement_Click(object sender, EventArgs e)
        {
            
            if (Empty_Input(InputSettlement, ListSettlement))
            {
                if (Choice_Type.Text == "все")// если не выбрана область то выводим сообщение в MessegeBox
                {
                    DialogResult = MessageBox.Show("Вы не указали тип населенного пунтка! \n" +
                        "Укажите тип населенного пунтка! ",
                        "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [Settlement] (Title, DistricT,Type) VALUES (@Title, @DistricT, @Type)", SqlData);
                    command.Parameters.AddWithValue("Title", InputSettlement.Text);// добавляем название
                    command.Parameters.AddWithValue("DistricT", ListDistrict.SelectedValue);// принадлежит району 
                    command.Parameters.AddWithValue("Type", Choice_Type.SelectedItem);// выбираем тип населенного пункта 
                    InputSettlement.Text = string.Empty;
                    command.ExecuteNonQuery();
                    if (Choice_Type.Text != "все")
                        ListSettlement.DataSource = ChangeSelectedType("Settlement", "DistricT", ListDistrict.SelectedValue.ToString(), Choice_Type.Text);
                    else
                        ListSettlement.DataSource = ChangeSelected("Settlement", "DistricT", ListDistrict.SelectedValue.ToString());
                }
                CheckSelectedOldPlace();
            }
        }



        /////////////
        /// удаление элементов в LISTBOX-ов
        ////////////
        private void Delete_All(ListBox listBox, string Table,string Name)
        {
            MessageBox.Show("Удален из "+ Name + " элемент - " + listBox.SelectedValue);
            /// находим элементы в БЗ с таким же название и удаляем 
            SqlCommand command = new SqlCommand($"DELETE FROM {Table} WHERE Title =@Title", SqlData);
            //  после 1-ого использования соединение listbox с БЗ прерывается и нужно считывать уже по Items
            command.Parameters.AddWithValue("Title", listBox.SelectedValue);// считываем значение         
            command.ExecuteNonQuery();
            listBox.DataSource = WildcardFiles(Table);
            CheckSelectedOldPlace();
        }
        ////////// 
        /// само удаление объектов
        //////////
        private void DeleteCountry_Click(object sender, EventArgs e)
        {
            Delete_All(ListCountry, "Country", "Страны");
        }
        private void DeleteArea_Click(object sender, EventArgs e)
        {
            Delete_All(ListArea, "Area","Области");
            ListArea.DataSource = ChangeSelected(
                                              "Area", "CountrY", ListCountry.SelectedValue.ToString());
        }
        private void DeleteDistrict_Click(object sender, EventArgs e)
        {
            Delete_All(ListDistrict, "District", "Районы");
            ListDistrict.DataSource = ChangeSelected(
                                                      "District", "AreA", ListArea.SelectedValue.ToString());
        }
        private void DeleteSettlement_Click(object sender, EventArgs e)
        {
            Delete_All(ListSettlement, "Settlement", "Насленные пукнты");
            if (Choice_Type.Text == "все")
                ListSettlement.DataSource = ChangeSelected(
                                       "Settlement", "DistricT", ListDistrict.SelectedValue.ToString());
            else if (Choice_Type.Text != "" && ListDistrict.SelectedValue != null)
                ListSettlement.DataSource = ChangeSelectedType(
                                            "Settlement", "DistricT", ListDistrict.SelectedValue.ToString(), Choice_Type.Text);
        }


        // для уменьшия объема кода ввидем функцию которая создает список 
        // для функции которая в свою очередь возвращает список в listbox.DataSourse
        List<string> ReturnListForReader(SqlCommand command)
        {
            List<string> listRange = new List<string>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listRange.Add(reader.GetString(0));
            }
            reader.Close();
            return listRange;
        }
        //Изменяем курсор при изменение выбранного элемента в старшем listbox
        List<string> ChangeSelected(string Table, string OldPlace, object Column)
        {
            if (Column != null)
            {
                SqlCommand command = new SqlCommand($"SELECT Title FROM {Table} WHERE {OldPlace}=@{OldPlace} ", SqlData);
                command.Parameters.AddWithValue(OldPlace, Column);

                return ReturnListForReader(command);
            }
            return null;

        }
        List<string> ChangeSelectedType(string Table, string OldPlace, object Column, string Type)
        {
            SqlCommand command = new SqlCommand(
                $"SELECT Title FROM {Table} WHERE ({OldPlace}=@{OldPlace} AND Type=@Type) ", SqlData);
            command.Parameters.AddWithValue(OldPlace, Column);
            command.Parameters.AddWithValue("Type", Type);
            return ReturnListForReader(command);
        }

        /// <summary>
        // Изменения элментов в listbox-ах
        /// </summary>
        private void ListCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Begin && ListCountry.SelectedValue != null)
                ListArea.DataSource = ListDistrict.DataSource = ChangeSelected(
                                                                "Area", "CountrY", ListCountry.SelectedValue.ToString());
            CheckSelectedOldPlace();
        }
        private void ListArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Begin && ListArea.SelectedValue != null)
                ListDistrict.DataSource = ChangeSelected(
                                            "District", "AreA", ListArea.SelectedValue.ToString());
            CheckSelectedOldPlace();
        }
        private void ListDistrict_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Begin && ListDistrict.SelectedValue != null)
                if (Choice_Type.Text == "все")
                    ListSettlement.DataSource = ChangeSelected(
                                           "Settlement", "DistricT", ListDistrict.SelectedValue.ToString());
                else if (Choice_Type.Text != "" && ListDistrict.SelectedValue != null)
                    ListSettlement.DataSource = ChangeSelectedType(
                                                "Settlement", "DistricT", ListDistrict.SelectedValue.ToString(), Choice_Type.Text);
            CheckSelectedOldPlace();
        }


        /////////////
        ///     проверка  TexBox-на количество символов, ибо БЗ поддерживает символы строки в 50 символов
        ////////////
        void Check_Input(TextBox textBox)
        {
            if (textBox.Text.Length == 50)
            {
                DialogResult = MessageBox.Show("Вы превысили лимит вводимых символов!", "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                textBox.Text = "";
            }
        }
        private void InputCountry_TextChanged(object sender, EventArgs e)
        {
            Check_Input(InputCountry);
        }
        private void InputArea_TextChanged(object sender, EventArgs e)
        {
            Check_Input(InputArea);
        }
        private void InputDistrict_TextChanged(object sender, EventArgs e)
        {
            Check_Input(InputDistrict);
        }
        private void InputSettlement_TextChanged(object sender, EventArgs e)
        {
            Check_Input(InputSettlement);
        }

        // справка о типах населенных пунтков
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("г. - город \n пгт. - поселок городского типа \n с. - станция \n" +
                "д. деревня/хутор", "Справка",
                MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void CheckSelectedOldPlace()
        {
            if (ListCountry.SelectedValue == null)
            {
                ListArea.DataSource = ListDistrict.DataSource = ListSettlement.DataSource = null;
            }
            else if (ListArea.SelectedValue == null)
            {
                ListDistrict.DataSource = ListSettlement.DataSource = null;
            }
            else if (ListDistrict.SelectedValue == null)
            {
                ListSettlement.DataSource = null;
            }
        }
    }
}
