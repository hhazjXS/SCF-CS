using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string order_id = update_order_id_textbox.Text;
            int idx = MainForm.OS.orders.FindIndex(o => o.Order_Id == order_id);
            int goodsamount = int.Parse(update_goods_amount_textbox.Text);
            double goodsprice = double.Parse(update_goods_price_textbox.Text);
            Order order = new Order(update_order_id_textbox.Text, MainForm.OS.orders[idx].Order_Name, new OrderDetails(new Client(update_client_name_textbox.Text, update_client_location_textbox.Text, update_client_number_textbox.Text), new Goods(update_goods_name_textbox.Text, goodsamount, goodsprice)));
            MainForm.OS.Update(order, order_id);
        }

        private void updateBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
