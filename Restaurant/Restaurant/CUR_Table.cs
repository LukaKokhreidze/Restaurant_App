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
    public partial class CUR_Table : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSD7OP7\SQLEXPRESS;Initial Catalog=Market_DB;Integrated Security=True");


        public int DishAmount { get; set; }
        public bool Reserved { get; set; } = false;
        public bool Busy { get; set; } = false;
        public bool Free { get; set; } = false;
        public string Name { get; set; }
        public CUR_Table()
        {
            InitializeComponent();
        }
        public CUR_Table(string name)
        {
            InitializeComponent();
            Name = name;
            CLBList();
        }
        private void LoadDishes(string command, ListBox listBox)
        { 
            conn.Open();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            foreach (DataRow item in dt.Rows)
            {
                listBox.Items.Add($"{item["Name"].ToString()}_{item["Price"].ToString()} GEL.");
            }
            tableNumberLbl.Text = Name.Split('_')[1];
        }
        

        private void CurrentTableForm_Load(object sender, EventArgs e)
        {
            LoadDishes("select * from Dishes_Tb where Type = 'Cold'", ColdDishes);
            LoadDishes("select * from dishes_tb where type = 'Hot'", hotDishes);
            LoadDishes("select * from dishes_tb where type = 'Cul'", culDishes);
            LoadDishes("select * from dishes_tb where type = 'Drink'", drinks);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\yellowtable.png");
            Reserved = true;
            Busy = false;
            Free = false;
            MessageBox.Show("RESERVED");
        }

        private void busyBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\redtable.png");
            Busy = true;
            Reserved = false;
            Free = false;
            MessageBox.Show("BUSY");
        }

        private void tableFreeBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\NEW\c#step\Restaurant_App\Restaurant\Restaurant\Resources\greentable.png");
            Reserved = false;
            Busy = false;
            Free = true;
            MessageBox.Show("FREE");
        }
        private void CLBList()
        {
            List<ListBox> list = new List<ListBox>()
            {
                ColdDishes,hotDishes,culDishes,drinks
            };
            foreach (ListBox item in list)
            {
                item.SelectedValueChanged += DishCLBHandeler;
            }
        }
        private void DishCLBHandeler(object sender, EventArgs e)
        {
            FoodAmount dishAmountFrom = new FoodAmount();
            dishAmountFrom.ShowDialog();
            if (dishAmountFrom.DialogResult == DialogResult.OK)
            {
                DishAmount = dishAmountFrom.Amount;
                orderLB.Items.Add($"{(sender as ListBox).SelectedItem.ToString().Split('_')[0]} {DishAmount}");
            }

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (Reserved)
                DialogResult = DialogResult.OK;
            else if (Busy)
                DialogResult = DialogResult.Yes;
            else if(Free)
                DialogResult = DialogResult.No;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
