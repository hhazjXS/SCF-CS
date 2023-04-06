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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectall_button_Click(object sender, EventArgs e)
        {
            List<Order> orderlist = MainForm.OS.orders;
            var orderdetailslist = orderlist.Select(o => new
            {
                order_id = o.Order_Id,
                order_name = o.Order_Name,
                client_name = o.orderdetails.client.Client_Name,
                client_location = o.orderdetails.client.Client_Location,
                o.orderdetails.client.Client_Number,
                goods_name = o.orderdetails.goods.Goods_Name,
                goods_amount = o.orderdetails.goods.Goods_Amount,
                goods_price = o.orderdetails.goods.Goods_Price,
                sumprice = o.orderdetails.SumPrince
            });
            orderdetailsDataGridView.DataSource = orderdetailslist.ToList();
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectbyclient_button_Click(object sender, EventArgs e)
        {
            string key = key_textbox.Text;
            List<Order> orderlist = MainForm.OS.SelectByClientName(key);
            var orderdetailslist = orderlist.Select(o => new
            {
                order_id = o.Order_Id,
                order_name = o.Order_Name,
                client_name = o.orderdetails.client.Client_Name,
                client_location = o.orderdetails.client.Client_Location,
                o.orderdetails.client.Client_Number,
                goods_name = o.orderdetails.goods.Goods_Name,
                goods_amount = o.orderdetails.goods.Goods_Amount,
                goods_price = o.orderdetails.goods.Goods_Price,
                sumprice = o.orderdetails.SumPrince
            });
            orderdetailsDataGridView.DataSource = orderdetailslist.ToList();
        }

        private void selectbygoods_button_Click(object sender, EventArgs e)
        {
            string key = key_textbox.Text;
            List<Order> orderlist = MainForm.OS.SelectByGoodsName(key);
            var orderdetailslist = orderlist.Select(o => new
            {
                order_id = o.Order_Id,
                order_name = o.Order_Name,
                client_name = o.orderdetails.client.Client_Name,
                client_location = o.orderdetails.client.Client_Location,
                o.orderdetails.client.Client_Number,
                goods_name = o.orderdetails.goods.Goods_Name,
                goods_amount = o.orderdetails.goods.Goods_Amount,
                goods_price = o.orderdetails.goods.Goods_Price,
                sumprice = o.orderdetails.SumPrince
            });
            orderdetailsDataGridView.DataSource = orderdetailslist.ToList();
        }

        private void selectbyid_button_Click(object sender, EventArgs e)
        {
            string key = key_textbox.Text;
            List<Order> orderlist = MainForm.OS.SelectByOrderID(key);
            var orderdetailslist = orderlist.Select(o => new
            {
                order_id = o.Order_Id,
                order_name = o.Order_Name,
                client_name = o.orderdetails.client.Client_Name,
                client_location = o.orderdetails.client.Client_Location,
                o.orderdetails.client.Client_Number,
                goods_name = o.orderdetails.goods.Goods_Name,
                goods_amount = o.orderdetails.goods.Goods_Amount,
                goods_price = o.orderdetails.goods.Goods_Price,
                sumprice = o.orderdetails.SumPrince
            });
            orderdetailsDataGridView.DataSource = orderdetailslist.ToList();
        }

        private void selectbysum_button_Click(object sender, EventArgs e)
        {
            double key = double.Parse(key_textbox.Text);
            List<Order> orderlist = MainForm.OS.SelectBySumPrice(key);
            var orderdetailslist = orderlist.Select(o => new
            {
                order_id = o.Order_Id,
                order_name = o.Order_Name,
                client_name = o.orderdetails.client.Client_Name,
                client_location = o.orderdetails.client.Client_Location,
                o.orderdetails.client.Client_Number,
                goods_name = o.orderdetails.goods.Goods_Name,
                goods_amount = o.orderdetails.goods.Goods_Amount,
                goods_price = o.orderdetails.goods.Goods_Price,
                sumprice = o.orderdetails.SumPrince
            });
            orderdetailsDataGridView.DataSource = orderdetailslist.ToList();
        }

        private void orderGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
