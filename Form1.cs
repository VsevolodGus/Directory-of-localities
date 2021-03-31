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


            ListCountry.DataSource = Country.LoadList(TableCountry,sqlConnection);
            ListState.DataSource = StateOrDistrict.LoadListState(TableState, ListCountry.Items[0].ToString(), sqlConnection);
            ListDistrict.DataSource = StateOrDistrict.LoadListState(TableDistrict, ListState.Items[0].ToString(), sqlConnection);
            ListTown.DataSource = Town.LoadListState(TableTown, ListDistrict.Items[0].ToString(), "все" ,sqlConnection);
        }
        
        
        // addendum in DB in the table Country 
        private void AddCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(InputCountry.Text);
            country.Add(sqlConnection);

            ListCountry.DataSource = Country.LoadList(TableCountry, sqlConnection);
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

            ListTown.DataSource = Town.LoadListState(TableTown, ListDistrict.SelectedItem.ToString(), Choice_Type.Text,sqlConnection);
            InputTown.Text = "";
        }




        private void DeleteCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(ListCountry.SelectedItem.ToString());
            country.Delete(sqlConnection);

            ListCountry.DataSource = Country.LoadList(TableCountry, sqlConnection);
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
            var town = new Town(InputTown.Text, ListDistrict.SelectedItem.ToString(), Choice_Type.Text);
            town.Delete(sqlConnection);

            ListTown.DataSource = Town.LoadListState(TableTown, ListDistrict.SelectedItem.ToString(), Choice_Type.Text, sqlConnection);
            InputTown.Text = "";
        }
    }
}
