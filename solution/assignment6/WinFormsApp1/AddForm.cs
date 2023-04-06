using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void title_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderBox_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void order_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void client_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void goodsBox_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void add_button_Click(object sender, EventArgs e)
        {
            int goodsamount = int.Parse(add_goods_amount_textbox.Text);
            double goodsprice = double.Parse(add_goods_price_textbox.Text);
            Order order = new Order(add_order_id_textbox.Text, add_order_name_textbox.Text, new OrderDetails(new Client(add_client_name_textbox.Text, add_client_location_textbox.Text, add_client_number_textbox.Text), new Goods(add_goods_name_textbox.Text, goodsamount, goodsprice)));
            MainForm.OS.AddOrder(order);
        }

        private void add_order_id_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
