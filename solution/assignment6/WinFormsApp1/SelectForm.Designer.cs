namespace WinFormsApp1
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            orderdetailsDataGridView = new DataGridView();
            order_id = new DataGridViewTextBoxColumn();
            order_name = new DataGridViewTextBoxColumn();
            client_name = new DataGridViewTextBoxColumn();
            client_location = new DataGridViewTextBoxColumn();
            client_number = new DataGridViewTextBoxColumn();
            goods_name = new DataGridViewTextBoxColumn();
            goods_amount = new DataGridViewTextBoxColumn();
            goods_price = new DataGridViewTextBoxColumn();
            sumprice = new DataGridViewTextBoxColumn();
            key_textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            selectall_button = new Button();
            selectbyclient_button = new Button();
            selectbygoods_button = new Button();
            selectbyid_button = new Button();
            selectbysum_button = new Button();
            title = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderdetailsDataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(orderdetailsDataGridView);
            panel1.Controls.Add(key_textbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 627);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // orderdetailsDataGridView
            // 
            orderdetailsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderdetailsDataGridView.BackgroundColor = SystemColors.ActiveBorder;
            orderdetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { order_id, order_name, client_name, client_location, client_number, goods_name, goods_amount, goods_price, sumprice });
            orderdetailsDataGridView.Location = new Point(3, 244);
            orderdetailsDataGridView.Name = "orderdetailsDataGridView";
            orderdetailsDataGridView.RowHeadersWidth = 51;
            orderdetailsDataGridView.RowTemplate.Height = 29;
            orderdetailsDataGridView.Size = new Size(867, 378);
            orderdetailsDataGridView.TabIndex = 10;
            orderdetailsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // order_id
            // 
            order_id.DataPropertyName = "order_id";
            order_id.HeaderText = "订单号";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.Width = 125;
            // 
            // order_name
            // 
            order_name.DataPropertyName = "order_name";
            order_name.HeaderText = "订单名";
            order_name.MinimumWidth = 6;
            order_name.Name = "order_name";
            order_name.Width = 125;
            // 
            // client_name
            // 
            client_name.DataPropertyName = "client_name";
            client_name.HeaderText = "客户名";
            client_name.MinimumWidth = 6;
            client_name.Name = "client_name";
            client_name.Width = 125;
            // 
            // client_location
            // 
            client_location.DataPropertyName = "client_location";
            client_location.HeaderText = "客户地址";
            client_location.MinimumWidth = 6;
            client_location.Name = "client_location";
            client_location.Width = 125;
            // 
            // client_number
            // 
            client_number.DataPropertyName = "client_number";
            client_number.HeaderText = "客户电话";
            client_number.MinimumWidth = 6;
            client_number.Name = "client_number";
            client_number.Width = 125;
            // 
            // goods_name
            // 
            goods_name.DataPropertyName = "goods_name";
            goods_name.HeaderText = "商品名";
            goods_name.MinimumWidth = 6;
            goods_name.Name = "goods_name";
            goods_name.Width = 125;
            // 
            // goods_amount
            // 
            goods_amount.DataPropertyName = "goods_amount";
            goods_amount.HeaderText = "商品数量";
            goods_amount.MinimumWidth = 6;
            goods_amount.Name = "goods_amount";
            goods_amount.Width = 125;
            // 
            // goods_price
            // 
            goods_price.DataPropertyName = "goods_price";
            goods_price.HeaderText = "商品单价";
            goods_price.MinimumWidth = 6;
            goods_price.Name = "goods_price";
            goods_price.Width = 125;
            // 
            // sumprice
            // 
            sumprice.DataPropertyName = "sumprice";
            sumprice.HeaderText = "商品总价";
            sumprice.MinimumWidth = 6;
            sumprice.Name = "sumprice";
            sumprice.Width = 125;
            // 
            // key_textbox
            // 
            key_textbox.Location = new Point(14, 110);
            key_textbox.Name = "key_textbox";
            key_textbox.Size = new Size(217, 27);
            key_textbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 7;
            label2.Text = "请输入关键字：";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 158);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 6;
            label1.Text = "请选择查询方式：";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(selectall_button);
            flowLayoutPanel1.Controls.Add(selectbyclient_button);
            flowLayoutPanel1.Controls.Add(selectbygoods_button);
            flowLayoutPanel1.Controls.Add(selectbyid_button);
            flowLayoutPanel1.Controls.Add(selectbysum_button);
            flowLayoutPanel1.Location = new Point(3, 181);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(867, 59);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // selectall_button
            // 
            selectall_button.Location = new Point(10, 10);
            selectall_button.Margin = new Padding(10);
            selectall_button.Name = "selectall_button";
            selectall_button.Size = new Size(140, 40);
            selectall_button.TabIndex = 0;
            selectall_button.Text = "查询所有订单";
            selectall_button.UseVisualStyleBackColor = true;
            selectall_button.Click += selectall_button_Click;
            // 
            // selectbyclient_button
            // 
            selectbyclient_button.Location = new Point(170, 10);
            selectbyclient_button.Margin = new Padding(10);
            selectbyclient_button.Name = "selectbyclient_button";
            selectbyclient_button.Size = new Size(140, 40);
            selectbyclient_button.TabIndex = 1;
            selectbyclient_button.Text = "根据客户名查询";
            selectbyclient_button.UseVisualStyleBackColor = true;
            selectbyclient_button.Click += selectbyclient_button_Click;
            // 
            // selectbygoods_button
            // 
            selectbygoods_button.Location = new Point(330, 10);
            selectbygoods_button.Margin = new Padding(10);
            selectbygoods_button.Name = "selectbygoods_button";
            selectbygoods_button.Size = new Size(140, 40);
            selectbygoods_button.TabIndex = 2;
            selectbygoods_button.Text = "根据商品名查询";
            selectbygoods_button.UseVisualStyleBackColor = true;
            selectbygoods_button.Click += selectbygoods_button_Click;
            // 
            // selectbyid_button
            // 
            selectbyid_button.Location = new Point(490, 10);
            selectbyid_button.Margin = new Padding(10);
            selectbyid_button.Name = "selectbyid_button";
            selectbyid_button.Size = new Size(140, 40);
            selectbyid_button.TabIndex = 3;
            selectbyid_button.Text = "根据订单号查询";
            selectbyid_button.UseVisualStyleBackColor = true;
            selectbyid_button.Click += selectbyid_button_Click;
            // 
            // selectbysum_button
            // 
            selectbysum_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectbysum_button.Location = new Point(650, 10);
            selectbysum_button.Margin = new Padding(10);
            selectbysum_button.Name = "selectbysum_button";
            selectbysum_button.Size = new Size(140, 40);
            selectbysum_button.TabIndex = 4;
            selectbysum_button.Text = "根据商品总价查询";
            selectbysum_button.UseVisualStyleBackColor = true;
            selectbysum_button.Click += selectbysum_button_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Location = new Point(332, 33);
            title.Name = "title";
            title.Size = new Size(69, 20);
            title.TabIndex = 0;
            title.Text = "订单查询";
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(897, 651);
            Controls.Add(panel1);
            Name = "SelectForm";
            Text = "查询订单功能界面";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderdetailsDataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button selectbygoods_button;
        private Button selectbyid_button;
        private Button selectbysum_button;
        private Label title;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button selectall_button;
        private Button selectbyclient_button;
        private TextBox key_textbox;
        private DataGridView orderdetailsDataGridView;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn client_name;
        private DataGridViewTextBoxColumn client_location;
        private DataGridViewTextBoxColumn client_number;
        private DataGridViewTextBoxColumn goods_name;
        private DataGridViewTextBoxColumn goods_amount;
        private DataGridViewTextBoxColumn goods_price;
        private DataGridViewTextBoxColumn sumprice;
    }
}