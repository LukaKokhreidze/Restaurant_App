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

namespace Restaurant
{
    public partial class TablesForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSD7OP7\SQLEXPRESS;Initial Catalog=Market_DB;Integrated Security=True");   
        public string Name { get; set; }
        public TablesForm()
        {
            InitializeComponent();
            TalbeList();
        }
        private void TablesForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from Tables_TB", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            List<PictureBox> list = TalbeList();
            foreach (DataRow item in table.Rows)
            {
                int tableNumber = int.Parse(item["TableNumber"].ToString());
                string tableStatus = item["Status"].ToString();
                (list.Select((el, i) => i == tableNumber && tableStatus == "Reserved") as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\yellowtable.png");
                (list.Select((el, i) => i == tableNumber && tableStatus == "Busy") as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\redtable.png");
                (list.Select((el, i) => i == tableNumber && tableStatus == "Free") as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\greentable.png");
            }
        }
        private List<PictureBox> TalbeList()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>()
            {
                pictureBox_1, pictureBox_2, pictureBox_3, pictureBox_4, 
                pictureBox_5, pictureBox_6, pictureBox_7, pictureBox_8,
                pictureBox_9, pictureBox_10, pictureBox_11, pictureBox_12
            };
            foreach (PictureBox item in pictureBoxes)
            {
                item.Click += TableEventHandler;
            }
            return pictureBoxes;
        }
        private void TableEventHandler(object sender, EventArgs e)
        {
            Name = (sender as PictureBox).Name; 
            CUR_Table currentTableForm = new CUR_Table(Name);
            currentTableForm.ShowDialog();
            if (currentTableForm.DialogResult == DialogResult.OK)
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                (sender as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\yellowtable.png");
                conn.Open();
                SqlCommand cmd = new SqlCommand($"update Tables_TB set status = 'Reserved', reserveTime = '{sqlFormattedDate}' where tablenumber = {int.Parse((sender as PictureBox).Name.Split('_')[1])}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (currentTableForm.DialogResult == DialogResult.Yes)
            {
                (sender as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\redtable.png");
                conn.Open();
                SqlCommand cmd = new SqlCommand($"update Tables_TB set status = 'Busy' where tablenumber = {(sender as PictureBox).Name.Split('_')[1]}",conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (currentTableForm.DialogResult == DialogResult.No)
            {
                (sender as PictureBox).Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\greentable.png");
                conn.Open();
                SqlCommand cmd = new SqlCommand($"update Tables_TB set status = 'Free' where tablenumber = {(sender as PictureBox).Name.Split('_')[1]}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
