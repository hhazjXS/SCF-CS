namespace WinFormsApp1
{
    partial class AddForm
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
            add_button = new Button();
            goodsBox = new GroupBox();
            add_goods_price_textbox = new TextBox();
            add_goods_amount_textbox = new TextBox();
            add_goods_name_textbox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            clientBox = new GroupBox();
            add_client_number_textbox = new TextBox();
            add_client_location_textbox = new TextBox();
            add_client_name_textbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            orderBox = new GroupBox();
            add_order_name_textbox = new TextBox();
            add_order_id_textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            title = new Label();
            panel1.SuspendLayout();
            goodsBox.SuspendLayout();
            clientBox.SuspendLayout();
            orderBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(add_button);
            panel1.Controls.Add(goodsBox);
            panel1.Controls.Add(clientBox);
            panel1.Controls.Add(orderBox);
            panel1.Controls.Add(title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 627);
            panel1.TabIndex = 0;
            // 
            // add_button
            // 
            add_button.Anchor = AnchorStyles.Top;
            add_button.Location = new Point(361, 558);
            add_button.Name = "add_button";
            add_button.Size = new Size(140, 40);
            add_button.TabIndex = 4;
            add_button.Text = "确认添加此订单";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // goodsBox
            // 
            goodsBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            goodsBox.BackColor = SystemColors.ActiveBorder;
            goodsBox.Controls.Add(add_goods_price_textbox);
            goodsBox.Controls.Add(add_goods_amount_textbox);
            goodsBox.Controls.Add(add_goods_name_textbox);
            goodsBox.Controls.Add(label8);
            goodsBox.Controls.Add(label7);
            goodsBox.Controls.Add(label6);
            goodsBox.Location = new Point(3, 377);
            goodsBox.Name = "goodsBox";
            goodsBox.Size = new Size(850, 158);
            goodsBox.TabIndex = 3;
            goodsBox.TabStop = false;
            goodsBox.Text = "商品信息";
            goodsBox.Enter += goodsBox_Enter;
            // 
            // add_goods_price_textbox
            // 
            add_goods_price_textbox.Location = new Point(168, 108);
            add_goods_price_textbox.Name = "add_goods_price_textbox";
            add_goods_price_textbox.Size = new Size(228, 27);
            add_goods_price_textbox.TabIndex = 5;
            // 
            // add_goods_amount_textbox
            // 
            add_goods_amount_textbox.Location = new Point(168, 70);
            add_goods_amount_textbox.Name = "add_goods_amount_textbox";
            add_goods_amount_textbox.Size = new Size(228, 27);
            add_goods_amount_textbox.TabIndex = 4;
            // 
            // add_goods_name_textbox
            // 
            add_goods_name_textbox.Location = new Point(168, 33);
            add_goods_name_textbox.Name = "add_goods_name_textbox";
            add_goods_name_textbox.Size = new Size(228, 27);
            add_goods_name_textbox.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 111);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 2;
            label8.Text = "请输入商品单价：";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 73);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 1;
            label7.Text = "请输入商品数量：";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 36);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 0;
            label6.Text = "请输入商品名称：";
            // 
            // clientBox
            // 
            clientBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientBox.BackColor = SystemColors.ActiveBorder;
            clientBox.Controls.Add(add_client_number_textbox);
            clientBox.Controls.Add(add_client_location_textbox);
            clientBox.Controls.Add(add_client_name_textbox);
            clientBox.Controls.Add(label5);
            clientBox.Controls.Add(label4);
            clientBox.Controls.Add(label3);
            clientBox.Location = new Point(3, 205);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(849, 166);
            clientBox.TabIndex = 2;
            clientBox.TabStop = false;
            clientBox.Text = "客户信息";
            // 
            // add_client_number_textbox
            // 
            add_client_number_textbox.Location = new Point(167, 119);
            add_client_number_textbox.Name = "add_client_number_textbox";
            add_client_number_textbox.Size = new Size(228, 27);
            add_client_number_textbox.TabIndex = 5;
            // 
            // add_client_location_textbox
            // 
            add_client_location_textbox.Location = new Point(167, 79);
            add_client_location_textbox.Name = "add_client_location_textbox";
            add_client_location_textbox.Size = new Size(228, 27);
            add_client_location_textbox.TabIndex = 4;
            // 
            // add_client_name_textbox
            // 
            add_client_name_textbox.Location = new Point(167, 36);
            add_client_name_textbox.Name = "add_client_name_textbox";
            add_client_name_textbox.Size = new Size(228, 27);
            add_client_name_textbox.TabIndex = 3;
            add_client_name_textbox.TextChanged += client_name_textbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 119);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 2;
            label5.Text = "请输入客户电话：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 79);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 1;
            label4.Text = "请输入客户地址：";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 39);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 0;
            label3.Text = "请输入客户姓名：";
            // 
            // orderBox
            // 
            orderBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderBox.BackColor = SystemColors.ActiveBorder;
            orderBox.Controls.Add(add_order_name_textbox);
            orderBox.Controls.Add(add_order_id_textbox);
            orderBox.Controls.Add(label2);
            orderBox.Controls.Add(label1);
            orderBox.Location = new Point(4, 72);
            orderBox.Name = "orderBox";
            orderBox.Size = new Size(849, 127);
            orderBox.TabIndex = 1;
            orderBox.TabStop = false;
            orderBox.Text = "订单信息";
            orderBox.Enter += orderBox_Enter;
            // 
            // add_order_name_textbox
            // 
            add_order_name_textbox.Location = new Point(167, 78);
            add_order_name_textbox.Name = "add_order_name_textbox";
            add_order_name_textbox.Size = new Size(228, 27);
            add_order_name_textbox.TabIndex = 3;
            add_order_name_textbox.TextChanged += order_name_textbox_TextChanged;
            // 
            // add_order_id_textbox
            // 
            add_order_id_textbox.Location = new Point(167, 37);
            add_order_id_textbox.Name = "add_order_id_textbox";
            add_order_id_textbox.Size = new Size(228, 27);
            add_order_id_textbox.TabIndex = 2;
            add_order_id_textbox.TextChanged += add_order_id_textbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "请输入订单名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "请输入订单号：";
            label1.Click += label1_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Location = new Point(344, 31);
            title.Name = "title";
            title.Size = new Size(174, 20);
            title.TabIndex = 0;
            title.Text = "欢迎使用添加订单功能！";
            title.TextAlign = ContentAlignment.TopCenter;
            title.Click += title_Click_1;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(880, 646);
            Controls.Add(panel1);
            Name = "AddForm";
            Text = "添加订单功能窗口";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            goodsBox.ResumeLayout(false);
            goodsBox.PerformLayout();
            clientBox.ResumeLayout(false);
            clientBox.PerformLayout();
            orderBox.ResumeLayout(false);
            orderBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title;
        private GroupBox orderBox;
        private Label label2;
        private Label label1;
        private GroupBox clientBox;
        private TextBox add_order_name_textbox;
        private TextBox add_order_id_textbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox add_client_number_textbox;
        private TextBox add_client_location_textbox;
        private TextBox add_client_name_textbox;
        private GroupBox goodsBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox add_goods_price_textbox;
        private TextBox add_goods_amount_textbox;
        private TextBox add_goods_name_textbox;
        private Button add_button;
    }
}