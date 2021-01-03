using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Restaurant_Kitchen
{
    public partial class History : Form
    {
        string connectionString = "data source=DESKTOP-TONY; initial catalog = best_food; user id = sa; password=1234";
        BindingSource bindingSource1 = new BindingSource();

        public History()
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
         This function gets all the non-ready orders
         Input:  None
         Output: Order table
        */
        private void GetOrders()
        {
            string query = "SELECT code, table_num, category_name, food_name from orders where is_ready = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;
        }
    }
}
