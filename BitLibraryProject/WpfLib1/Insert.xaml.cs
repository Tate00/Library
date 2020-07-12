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
    /// Interaction logic for LaodData.xaml
    /// </summary>
    public partial class LaodData : Window
    {
        public LaodData()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC-Q7-HP\sqle2012; Initial Catalog=Library; Integrated Security=True;");
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();


                String query = "INSERT INTO Library Values(@BI,@TI,@AU,@PC,@TO,@CO);";

                SqlCommand comm = new SqlCommand(query, con);




                comm.Parameters.Add("@BI", SqlDbType.Int).Value = txtBookID.Text;
                comm.Parameters.Add("@TI", SqlDbType.NChar).Value = txtTitle.Text;
                comm.Parameters.Add("@AU", SqlDbType.NChar).Value = txtAuthor.Text;
                comm.Parameters.Add("@PC", SqlDbType.Int).Value = txtPageCount.Text;
                comm.Parameters.Add("@TO", SqlDbType.NChar).Value = txtTopic.Text;
                comm.Parameters.Add("@CO", SqlDbType.NChar).Value = txtCode.Text;




                if ((txtBookID.Text != "") && (txtTitle.Text != "") && (txtAuthor.Text != "") && (txtPageCount.Text != "") && (txtTopic.Text != "") && (txtCode.Text != ""))
                {

                    comm.ExecuteNonQuery();

                    txtBookID.Text = "";
                    txtTitle.Text = "";
                    txtAuthor.Text = "";
                    txtPageCount.Text = "";
                    txtTopic.Text = "";
                    txtCode.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
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

        private void btnSubmit_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
    }
