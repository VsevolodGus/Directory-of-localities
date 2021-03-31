using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibPlace;

namespace Справочник
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private const string TableCountry = "Country";
        private const string TableState = "State";
        private const string TableDistrict = "District";
        private const string TableTown = "Town";
       

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Place"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
                    throw new InvalidOperationException("Data base isn`t  connected.");

            ListCountry.DataSource = Country.LoadList(sqlConnection);
            ListState.DataSource = StateOrDistrict.LoadListState(TableState, ListCountry.Items[0].ToString(), sqlConnection);
            ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.Items[0].ToString(), sqlConnection);
            ListTown.DataSource = Town.LoadListState(ListDistrict.Items[0].ToString() ,"все" ,sqlConnection);

            Choice_Type.Text = "все";
        }
        
        
        // addendum in DB in the table Country 
        private void AddCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(InputCountry.Text);
            country.Add(sqlConnection);

            ListCountry.DataSource = Country.LoadList(sqlConnection);
            InputCountry.Text = "";

        }
        private void AddState_Click(object sender, EventArgs e)
        {
            var state = new StateOrDistrict(InputState.Text, TableState,ListCountry.SelectedItem.ToString());
            state.Add(sqlConnection);

            ListState.DataSource = StateOrDistrict.LoadListState(TableState, ListCountry.SelectedItem.ToString(), sqlConnection);
            InputState.Text = "";
        }
        private void AddDistrict_Click(object sender, EventArgs e)
        {
            var district = new StateOrDistrict(InputDistrict.Text, TableDistrict, ListState.SelectedItem.ToString());
            district.Add(sqlConnection);

            ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.SelectedItem.ToString(),sqlConnection);
            InputDistrict.Text = "";
        }
        private void AddSettlement_Click(object sender, EventArgs e)
        {
            var town = new Town(InputTown.Text, ListDistrict.SelectedItem.ToString(),Choice_Type.Text);
            town.Add(sqlConnection);

            ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text,sqlConnection);
            InputTown.Text = "";
        }



        // thid deleted object from our list
        private void DeleteCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(ListCountry.SelectedItem.ToString());
            country.Delete(sqlConnection);

            ListCountry.DataSource = Country.LoadList(sqlConnection);
        }
        private void DeleteState_Click(object sender, EventArgs e)
        {
            var state = new StateOrDistrict(ListState.SelectedItem.ToString(), TableState, ListCountry.SelectedItem.ToString());
            state.Delete(sqlConnection);

            ListState.DataSource = StateOrDistrict.LoadListState(TableState, ListCountry.SelectedItem.ToString(), sqlConnection);
        }
        private void DeleteDistrict_Click(object sender, EventArgs e)
        {
            var district = new StateOrDistrict(ListDistrict.SelectedItem.ToString(), TableDistrict, ListState.SelectedItem.ToString());
            district.Delete(sqlConnection);

            ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.SelectedItem.ToString(), sqlConnection);
        }
        private void DeleteTown_Click(object sender, EventArgs e)
        {
            var town = new Town(ListTown.SelectedItem.ToString(), ListDistrict.SelectedItem.ToString(), Choice_Type.Text);
            town.Delete(sqlConnection);

            ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text, sqlConnection);
            InputTown.Text = "";
        }


        // this checking field for input title object in the our list
        private bool MaxLengthInput(TextBox textBox)
        {
            if (textBox.Text.Length >=50)
            {
                MessageBox.Show("Превысили лимит вводимых символо",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                
                textBox.Text = "";
                return false;
            }

            return true;
        }
        private void InputCountry_TextChanged(object sender, EventArgs e)
        {
            MaxLengthInput(InputCountry);
        }
        private void InputState_TextChanged(object sender, EventArgs e)
        {
            MaxLengthInput(InputState);
        }
        private void InputDistrict_TextChanged(object sender, EventArgs e)
        {
            MaxLengthInput(InputDistrict);
        }
        private void InputTown_TextChanged(object sender, EventArgs e)
        {
            MaxLengthInput(InputTown);
        }


        // when changing selected item in one list, in other list change happens  too,
        // this changeninig happenes in strikg hierarchy  
        private void ListCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListCountry.SelectedItem.ToString() == null)
            {
                ListState.DataSource = null;
                ListDistrict.DataSource = null;
                ListTown.DataSource = null;
            }
            else
            {
                ListState.DataSource = StateOrDistrict.LoadListState(TableState, ListCountry.SelectedItem.ToString(),
                                                                     sqlConnection);
                ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.SelectedItem.ToString(),
                                                                     sqlConnection);
                ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text, sqlConnection);
            }
        }
        private void ListState_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListState.SelectedItem.ToString() == null)
            {
                ListDistrict.DataSource = null;
                ListTown.DataSource = null;
            }
            else
            {
                ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.SelectedItem.ToString(),
                                                                     sqlConnection);
                ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text, sqlConnection);
            }
        }
        private void ListDistrict_SelectedValueChanged(object sender, EventArgs e)
        {
            ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text , sqlConnection);
        }
        private void Choice_Type_TextChanged(object sender, EventArgs e)
        {
           ListTown.DataSource = Town.LoadListState(ListDistrict.SelectedItem.ToString(), Choice_Type.Text, sqlConnection);
        }
    }
}
