using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Windows.Shapes;

namespace HMTDPTeamLibraryProject.Search_and_Sort
{
    public partial class Search : SearchPage
    {
        DataSet dstResults = new DataSet();
        DataView myView;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            //Populates the DataSet using a helper method
            ReadData("SELECT * FROM adventureworks.production.vproductanddescription",
                ref dstResults, "Products");

            //Creates a DataView from our table's default view
            myView = ((DataTable)dstResults.Tables["Products"]).DefaultView;

            //Assigns the DataView to the grid
            dgvResults.DataSource = myView;
        }

        //This method is fired by the KeyUp event handler on the textbox.
        //The purpose of this method is to take the text from the search
        //box, split it up into words, and then create and assign a filter
        //statement that will do a LIKE comparison on each of the selected
        //search fields.  Each word's filter statement is AND'ed together
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string outputInfo = "";
            string[] keyWords = txtSearch.ToString().Split(' ');

            //Text.Split

            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(Name LIKE '%" + word + "%' OR ProductModel LIKE '%" +
                        word + "%' OR Description LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (Name LIKE '%" + word + "%' OR ProductModel LIKE '%" +
                        word + "%' OR Description LIKE '%" + word + "%')";
                }
            }

            //Applies the filter to the DataView
            myView.RowFilter = outputInfo;
        }

        //A helper class that just dumps the SQL command into a DataSet and passes it back.
        //This isn't a method that is production-ready.  It is simply used here as a way
        //to populate our DataSet.
        public void ReadData(string strSQL, ref DataSet dstMain, string strTableName = "default")
        {
            try
            {
                string connectionString = "Database=AdventureWorks;Data Source=localhost;Trusted_Connection=True";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(strSQL, cnn);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstMain, strTableName);
                da.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private SearchPage txtSearch;
        private SearchPage dgvResults;
        private SearchPage lblSearch;
    }
}
