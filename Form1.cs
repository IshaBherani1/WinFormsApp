//Isha Bherani

using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        //Create the static variables for later use
        public static string ProductID;
        public static string proIdStr;
        public static string locIdStr;
        public static string binStr;
        public static string quanStr;
        public static string shelfStr;
        public static char shelfChar;
        public static double quantityDouble;
        public static double binDouble;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //initialize the Product ID inputs 
            double txt1 = Convert.ToDouble(startIDtxt.Text);
            double txt2 = Convert.ToDouble(endIDtxt.Text);

            //connect to the database
            string ConnectionString = @"Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.; TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //sql query for the first data table
            SqlCommand command = new SqlCommand("  SELECT TOP (20) [ProductID], [ProductNumber], [Color],[StandardCost], [ListPrice], [Production].[Product].ProductSubcategoryID, [Production].[ProductSubcategory].[Name]" +
                "FROM[AdventureWorks2019].[Production].[Product] left outer join[AdventureWorks2019].[Production].[ProductSubcategory] on[Production].[Product].ProductSubcategoryID = [Production].[ProductSubcategory].ProductSubcategoryID " +
                "where ProductID between "+ txt1+ " and " + txt2, connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            //Set the datagridview control = to the datatable, and make it visibile
            dataGridView1.DataSource = datatable;
            dataGridView1.Visible = true;

            connection.Close();//close connection to avoid errors

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //put the initialization in try catch block otherwise it gives an error
            try
            {
                ProductID = dataGridView1.SelectedCells[0].Value.ToString();
            }
            catch
            {
                ProductID = "0";
            }

            //connnect to the database
            String conn = "Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            //sql query for the second data table
            SqlCommand command = new SqlCommand("SELECT TOP (20) [ProductID] ,[LocationID],[Shelf],[Bin],[Quantity]" +
                "FROM[AdventureWorks2019].[Production].[ProductInventory] where ProductID =" + ProductID, connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            dataGridView2.DataSource = datatable;
            dataGridView2.Visible = true;

            //make the other elements visible 
            productIdLbl.Visible = true;
            productIdTxt.Visible = true;
            locationIdLbl.Visible = true;
            locationIdTxt.Visible = true;
            shelfLbl.Visible = true;
            shelfTxt.Visible = true;
            binLbl.Visible = true;
            binTxt.Visible = true;
            quantityLbl.Visible = true;
            quantityTxt.Visible = true;
            updateBtn.Visible = true;

            //initialize the variables using a try catch block to avoid runtime errors
            try
            {
                proIdStr = dataGridView2.SelectedCells[0].Value.ToString();
                productIdTxt.Text = proIdStr;
                locIdStr = dataGridView2.SelectedCells[1].Value.ToString();
                locationIdTxt.Text = locIdStr;
                shelfStr = dataGridView2.SelectedCells[2].Value.ToString();
                shelfTxt.Text = shelfStr;
                binStr = dataGridView2.SelectedCells[3].Value.ToString();
                binTxt.Text = binStr;
                quanStr = dataGridView2.SelectedCells[4].Value.ToString();
                quantityTxt.Text = quanStr;
            }
            catch
            {
                proIdStr = "0";
            }

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //initialize the variables using a try catch block to avoid runtime errors
            try
            {
                shelfStr = dataGridView2.SelectedCells[2].Value.ToString();
                shelfTxt.Text = shelfStr;
                binStr = dataGridView2.SelectedCells[3].Value.ToString();
                binTxt.Text = binStr;
                quanStr = dataGridView2.SelectedCells[4].Value.ToString();
                quantityTxt.Text = quanStr;
            }
            catch
            {
                proIdStr = "0";
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                shelfChar = Convert.ToChar(shelfTxt.Text);
                quantityDouble = Convert.ToDouble(quantityTxt.Text);
                binDouble = Convert.ToDouble(binTxt.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            try
            {
                ProductID = dataGridView2.SelectedCells[0].Value.ToString();
            }
            catch
            {
                ProductID = "0";
            }

            //connect to the database
            String conn = "Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            //UPDATE sql query to updaye the elements in the actual database with the values entered by the user
            SqlCommand command1 = new SqlCommand(" UPDATE [AdventureWorks2019].[Production].[ProductInventory] SET Shelf = '" + shelfChar +
                "' , Quantity = " + quantityDouble + " , Bin=" + binDouble + " WHERE[Production].[ProductInventory].[ProductID] =" + ProductID, connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable1 = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            adapter1.Fill(datatable1);

            dataGridView2.DataSource = datatable1;
            dataGridView2.Visible = true;

            //the query diaplays the items from the ProductInventory table
            SqlCommand command = new SqlCommand("SELECT TOP (20) [ProductID],[LocationID],[Shelf],[Bin],[Quantity]" +
                "FROM[AdventureWorks2019].[Production].[ProductInventory] where ProductID = " + ProductID , connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            dataGridView2.DataSource = datatable;
            dataGridView2.Visible = true;
        }
    }

}