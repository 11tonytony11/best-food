using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Restaurant_Kitchen
{
    public partial class Kitchen : Form
    {
        string connectionString = "data source=DESKTOP-TONY; initial catalog = best_food; user id = sa; password=1234";
        BindingSource bindingSource1 = new BindingSource();

        public Kitchen()
        {
            InitializeComponent();
            InitGridView();
            GetOrders();
        }
        //---------------------------------------------------------------------------------
        /*
         This function sets the orders table properties
         Input:  None
         Output: None
        */
        private void InitGridView()
        {
            Orders.DataSource = bindingSource1;
            Orders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        //---------------------------------------------------------------------------------
        /*
         This function refreshes the order table
         Input:  None
         Output: New Order table
        */
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetOrders();
        }
        //---------------------------------------------------------------------------------
        /*
         This function alerts the user when order is ready
         Input:  None
         Output: MessageBox window
        */
        private void Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "UPDATE orders SET is_ready = 1 WHERE code = " + Orders.Rows[e.RowIndex].Cells[0].Value;
            string orderNumer = Orders.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {               
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, cnn);
                command.Connection.Open();
                command.ExecuteNonQuery();
                GetOrders();
            }
            catch(SqlException)
            {
                MessageBox.Show("Couldn't mark order as ready", "Critical Order system Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Order #" + orderNumer + " is ready");
        }
        //---------------------------------------------------------------------------------
        /*
         This function Opens old orders window
         Input:  None
         Output: History Window
        */
        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }
        //---------------------------------------------------------------------------------
        /*
         This function gets all the non-ready orders
         Input:  None
         Output: Order table
        */
        private void GetOrders()
        {
            string query = "SELECT code, table_num, category_name, food_name from orders where is_ready = 0";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };

            dataAdapter.Fill(table);            
            bindingSource1.DataSource = table;           
        }
        //---------------------------------------------------------------------------------
        
    }
}