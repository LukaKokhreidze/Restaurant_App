using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FoodAmount : Form
    {
        public int Amount { get; set; }
        public FoodAmount()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dishAmount_ValueChanged(object sender, EventArgs e)
        {
            Amount = Convert.ToInt32(dishAmount.Value);
        }
    }
}
