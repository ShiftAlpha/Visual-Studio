using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WeatherApplication
{
   

    public partial class DashBoard : Form
    {

        private string a;
        public string Val; 

        public DashBoard(string u)
        {
            a = u;

            InitializeComponent();
        }

        public DashBoard() {

            InitializeComponent();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);//connections string to db
            SqlCommand cmd;
            SqlDataReader dataReader;// variable to read data from sql db
            con.Open();// opening connection

            cmd = new SqlCommand("select city_name from city", con);//select statement for names of the cities

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read()) {
                lstCity.Items.Insert(0, dataReader["city_name"].ToString());
            }

            con.Close();//closing db connection

            loadDisp();
        }


        public  void loadDisp() {


            SqlConnection dgcon = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand dgcmd;
            dgcmd = new SqlCommand("SELECT city.city_name, weather.dates, weather.mintemp, weather.maxtemp, weather.prec, weather.hum, weather.winds FROM FAVOURITE INNER JOIN USERS ON USERS.USER_ID = FAVOURITE.USER_ID INNER JOIN  city on  city.city_id = favourite.city_id inner join weather on weather.city_Id = city.city_id WHERE USERS.USER_ID  = @val", dgcon);
            dgcmd.Parameters.AddWithValue("@val",this.a);
            //selecting what to display in when favourite selected


            SqlDataAdapter daView;
            daView = new SqlDataAdapter(dgcmd);
            dgcon.Open();

            DataTable dtRec = new DataTable();
            daView.Fill(dtRec);
            dgviewer.DataSource = dtRec;

   
            dgcon.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into favourite(city_id,user_id) values((select city_id from city where city_name like @val),@valb)",con);
            cmd.Parameters.AddWithValue("@val" ,lstCity.Items[lstCity.SelectedIndex] );
            cmd.Parameters.AddWithValue("@valb", this.a);
            cmd.ExecuteNonQuery();//adding favourites using button

            

            con.Close();


            loadDisp();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            report newRep = new report();
            newRep.Show();
            this.Hide();
            //button flowing to required page
        }

        private void redDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportType1 newRep = new ReportType1();
            newRep.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Report.txt";
            Boolean valid = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                valid = true;
            }
            else
            {
                valid = true;
            }

            if (valid)
            {
                StreamWriter stream = new StreamWriter(s.FileName);

                String output = "";

                SqlConnection con2 = new SqlConnection(Properties.Settings.Default.WaKon);
                con2.Open();
                SqlCommand cmd = new SqlCommand("select * from weather inner join city on city.city_id = weather.city_id", con2);

                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    stream.WriteLine("City Name               Date    min-Temp    max-Temp    Humididty   Precipitation   Wind Speed");
                    output = dr["City_Name"] + "    " + dr["dates"] + "     " + dr["mintemp"] + "             " + dr["maxtemp"] + "           " + dr["hum"] + "           " + dr["prec"] + "        " + dr["winds"];
                    stream.WriteLine(output);


                }
                stream.Close();
                con2.Close();

            }

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            /*dgviewer.Rows.Clear();
            dgviewer.Refresh();*/

            this.dgviewer.DataSource = null;
            this.dgviewer.Rows.Clear();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string highTemp = " ";
            string lowTemp = "";
            string cityname = "";
            string cityname1 = "";



            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);



            con.Open();
            SqlCommand cmd;
            SqlCommand cmd1;
            cmd = new SqlCommand("select top 1 maxtemp,  city_name from favourite inner join city on city.city_id  = favourite.city_id inner join weather on weather.city_id = city.city_id inner join users on users.user_id = favourite.user_id where users.user_id like @userid order by maxtemp desc", con);
            
            cmd.Parameters.AddWithValue("@userid", this.a);
            
            SqlDataReader dataReader;
            
            dataReader = cmd.ExecuteReader();
            

            while (dataReader.Read())
            {
                highTemp = dataReader["maxtemp"].ToString();
                cityname = dataReader["city_name"].ToString();
             }

            con.Close();

            con.Open();

            cmd1 = new SqlCommand("select top 1 mintemp,  city_name from favourite inner join city on city.city_id  = favourite.city_id inner join weather on weather.city_id = city.city_id inner join users on users.user_id = favourite.user_id where users.user_id like @userid order by mintemp asc", con);
            cmd1.Parameters.AddWithValue("@userid",this.a);
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                lowTemp = dr["mintemp"].ToString();
                cityname1 = dr["city_name"].ToString();
            }

            con.Close();

            MessageBox.Show("The city with highest temperature is " + cityname + " and is " + highTemp+"'C /n" + "The city with lowest temperature is " + cityname1 + " and is " + lowTemp + "'C");
        }
    }
}
