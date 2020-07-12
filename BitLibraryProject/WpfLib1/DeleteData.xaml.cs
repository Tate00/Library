using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace WpfLib1
{
    /// <summary>
    /// Interaction logic for DeleteData.xaml
    /// </summary>
    public partial class DeleteData : Window
    {
        public DeleteData()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
   //     SqlDataReader dreader;
        string connstring = @"Data Source=PC_Q7_HP\sqle2012; Initial Catalog=Library; Integrated Security=True;";

        private void btnSubmit_Click1(object sender, RoutedEventArgs e)
        {

            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("delete from Books where Code = " + txtCode.Text + " ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                txtBookID.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtPageCount.Clear();
                txtTopic.Clear();
                txtCode.Focus();
               
            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnSubmit_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void TxtCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtTopic_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPageCount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAuthor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtBookID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
