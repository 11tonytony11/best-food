using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Client : Form
    {
        string connectionString = "data source=DESKTOP-TONY; initial catalog = best_food; user id = sa; password=1234";
        public static int totalPrice = 0;

        public Client()
        {
            InitializeComponent();
            GetCategories();
            initTable();
        }

        //---------------------------------------------------------------------------------
        /*
         This function generates table number
         Input:  None
         Output: None
        */
        private void initTable()
        {
            System.Random rnd = new System.Random();
            lblTable.Text = rnd.Next(1, 21).ToString();
        }
        //---------------------------------------------------------------------------------
        /*
         This function executes SQL query and returns the reader
         Input:  None
         Output: Query ans object
        */
        private SqlDataReader ExecuteQuery(string query)
        {
            SqlDataReader reader;
            SqlCommand command;
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            command = new SqlCommand(query, cnn);
            reader  = command.ExecuteReader();

            return reader;
        }
        //---------------------------------------------------------------------------------
        /*
         This function gets all categories from the DB
         Input:  None
         Output: Category Menu
        */
        private void GetCategories()
        {
            string query = @"SELECT name from Categories";

            try
            {
                SqlDataReader reader = ExecuteQuery(query);

                while (reader.Read())
                {
                    MenuCategory.Items.Add(reader.GetValue(0));
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Couldn't fetch categories","Critical Menu Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------
        /*
         This function Gets food by selected category
         Input:  None
         Output: Meal Menu
        */
        private void MenuCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string query = $"SELECT name from food where category_code = (select code from categories where name = '{MenuCategory.SelectedItem}')";

            MenuMeal.Items.Clear();
            MenuMeal.Text = "";
            
            try
            {
                SqlDataReader reader = ExecuteQuery(query);

                while (reader.Read())
                {
                    MenuMeal.Items.Add(reader.GetValue(0));
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Couldn't fetch meals", "Critical Meals Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        //---------------------------------------------------------------------------------
        /*
         This function gets all relevant info of selected meal
         Input:  None
         Output: price, description and cooking time
        */
        private void MenuMeal_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string query = $"SELECT cook_time, price, description from food where name = '{MenuMeal.SelectedItem}'";
            try
            {
                SqlDataReader reader = ExecuteQuery(query);

                while (reader.Read())
                {
                    lblCookingTime.Text = reader.GetValue(0).ToString() + " Minutes";
                    lblMealPrice.Text = reader.GetValue(1).ToString() + " ILS";
                    label1.Text = reader.GetValue(2).ToString();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Couldn't fetch meal info", "Critical Food Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------
        /*
         This function places order
         Input:  None
         Output: Order details
        */
        private void btnOrder_Click(object sender, System.EventArgs e)
        {
            string query = $"INSERT INTO orders VALUES('{MenuMeal.SelectedItem}', (select code from food where name = '{MenuMeal.SelectedItem}'), '{lblTable.Text}', 0, (select name from categories where code = (select category_code from food where name = '{MenuMeal.SelectedItem}')) )";

            try
            {
                SqlDataReader reader = ExecuteQuery(query);
                totalPrice += int.Parse(lblMealPrice.Text.Substring(0, lblMealPrice.Text.Length - 4));
                lblTotalPrice.Text = totalPrice + " ILS";
            }
            catch (SqlException)
            {
                MessageBox.Show("Couldn't place order", "Critical order Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Your order has been placed sueccesfully and will be ready in {lblCookingTime.Text}");
        }
    }
}
