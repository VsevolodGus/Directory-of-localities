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
        private SqlConnection sqlConnection =  null;
        private string TableCountry = "Country";
        private string TableState = "State";
        private string TableDistrict = "District";
        private string TableTown = "Town";

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

        }
        
        
        // addendum in DB
        private void AddCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(InputCountry.Text);
            country.Add(sqlConnection);
            InputCountry.Text = "";
        }

        

        private void AddState_Click(object sender, EventArgs e)
        {
            var state = new StateOrDistrict(InputState.Text, TableState,ListCountry.SelectedItem.ToString());
            //state.Add();
        }

        private void AddDistrict_Click(object sender, EventArgs e)
        {
            var district = new StateOrDistrict(InputState.Text,TableDistrict, ListState.SelectedItem.ToString());
            //district.Add();
        }

        private void AddSettlement_Click(object sender, EventArgs e)
        {
            var town = new Town(InputSettlement.Text, TableTown, ListDistrict.SelectedItem.ToString(),Choice_Type.Text);
            //town.Add();
        }

        private void DeleteCountry_Click(object sender, EventArgs e)
        {
            var country = new Country(ListCountry.SelectedItem.ToString());
            country.Delete(TableCountry,sqlConnection);
        }

    }
}
