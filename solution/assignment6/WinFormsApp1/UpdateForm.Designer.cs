namespace WinFormsApp1
{
    partial class UpdateForm
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
            update_button = new Button();
            updateBox3 = new GroupBox();
            update_goods_price_textbox = new TextBox();
            update_goods_amount_textbox = new TextBox();
            update_goods_name_textbox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            updateBox2 = new GroupBox();
            update_client_number_textbox = new TextBox();
            update_client_location_textbox = new TextBox();
            update_client_name_textbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            updateBox1 = new GroupBox();
            update_order_id_textbox = new TextBox();
            label1 = new Label();
            title = new Label();
            panel1.SuspendLayout();
            updateBox3.SuspendLayout();
            updateBox2.SuspendLayout();
            updateBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(updateBox3);
            panel1.Controls.Add(updateBox2);
            panel1.Controls.Add(updateBox1);
            panel1.Controls.Add(title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 634);
            panel1.TabIndex = 0;
            // 
            // update_button
            // 
            update_button.Anchor = AnchorStyles.Top;
            update_button.Location = new Point(357, 551);
            update_button.Name = "update_button";
            update_button.Size = new Size(140, 40);
            update_button.TabIndex = 4;
            update_button.Text = "确认修改此订单";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // updateBox3
            // 
            updateBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateBox3.BackColor = SystemColors.ActiveBorder;
            updateBox3.Controls.Add(update_goods_price_textbox);
            updateBox3.Controls.Add(update_goods_amount_textbox);
            updateBox3.Controls.Add(update_goods_name_textbox);
            updateBox3.Controls.Add(label7);
            updateBox3.Controls.Add(label6);
            updateBox3.Controls.Add(label5);
            updateBox3.Location = new Point(3, 351);
            updateBox3.Margin = new Padding(10);
            updateBox3.Name = "updateBox3";
            updateBox3.Size = new Size(824, 163);
            updateBox3.TabIndex = 3;
            updateBox3.TabStop = false;
            updateBox3.Text = "商品信息";
            // 
            // update_goods_price_textbox
            // 
            update_goods_price_textbox.Location = new Point(252, 113);
            update_goods_price_textbox.Name = "update_goods_price_textbox";
            update_goods_price_textbox.Size = new Size(207, 27);
            update_goods_price_textbox.TabIndex = 5;
            // 
            // update_goods_amount_textbox
            // 
            update_goods_amount_textbox.Location = new Point(252, 78);
            update_goods_amount_textbox.Name = "update_goods_amount_textbox";
            update_goods_amount_textbox.Size = new Size(207, 27);
            update_goods_amount_textbox.TabIndex = 4;
            // 
            // update_goods_name_textbox
            // 
            update_goods_name_textbox.Location = new Point(252, 42);
            update_goods_name_textbox.Name = "update_goods_name_textbox";
            update_goods_name_textbox.Size = new Size(207, 27);
            update_goods_name_textbox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 116);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 2;
            label7.Text = "请输入修改后的商品单价：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 81);
            label6.Name = "label6";
            label6.Size = new Size(189, 20);
            label6.TabIndex = 1;
            label6.Text = "请输入修改后的商品数量：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 45);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 0;
            label5.Text = "请输入修改后的商品名：";
            // 
            // updateBox2
            // 
            updateBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateBox2.BackColor = SystemColors.ActiveBorder;
            updateBox2.Controls.Add(update_client_number_textbox);
            updateBox2.Controls.Add(update_client_location_textbox);
            updateBox2.Controls.Add(update_client_name_textbox);
            updateBox2.Controls.Add(label4);
            updateBox2.Controls.Add(label3);
            updateBox2.Controls.Add(label2);
            updateBox2.Location = new Point(3, 181);
            updateBox2.Margin = new Padding(10);
            updateBox2.Name = "updateBox2";
            updateBox2.Size = new Size(827, 164);
            updateBox2.TabIndex = 2;
            updateBox2.TabStop = false;
            updateBox2.Text = "客户信息";
            updateBox2.Enter += updateBox2_Enter;
            // 
            // update_client_number_textbox
            // 
            update_client_number_textbox.Location = new Point(252, 120);
            update_client_number_textbox.Name = "update_client_number_textbox";
            update_client_number_textbox.Size = new Size(207, 27);
            update_client_number_textbox.TabIndex = 5;
            // 
            // update_client_location_textbox
            // 
            update_client_location_textbox.Location = new Point(252, 81);
            update_client_location_textbox.Name = "update_client_location_textbox";
            update_client_location_textbox.Size = new Size(207, 27);
            update_client_location_textbox.TabIndex = 4;
            // 
            // update_client_name_textbox
            // 
            update_client_name_textbox.Location = new Point(252, 41);
            update_client_name_textbox.Name = "update_client_name_textbox";
            update_client_name_textbox.Size = new Size(207, 27);
            update_client_name_textbox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 123);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 2;
            label4.Text = "请输入修改后的客户电话：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 84);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 1;
            label3.Text = "请输入修改后的客户地址：";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 44);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 0;
            label2.Text = "请输入修改后的客户姓名 ：";
            // 
            // updateBox1
            // 
            updateBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateBox1.BackColor = SystemColors.AppWorkspace;
            updateBox1.Controls.Add(update_order_id_textbox);
            updateBox1.Controls.Add(label1);
            updateBox1.ForeColor = Color.Black;
            updateBox1.Location = new Point(3, 65);
            updateBox1.Margin = new Padding(10);
            updateBox1.Name = "updateBox1";
            updateBox1.Size = new Size(827, 110);
            updateBox1.TabIndex = 1;
            updateBox1.TabStop = false;
            updateBox1.Text = "修改订单信息";
            // 
            // update_order_id_textbox
            // 
            update_order_id_textbox.Location = new Point(252, 54);
            update_order_id_textbox.Name = "update_order_id_textbox";
            update_order_id_textbox.Size = new Size(207, 27);
            update_order_id_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 57);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "请输入要修改的订单号：";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Location = new Point(323, 24);
            title.Name = "title";
            title.Size = new Size(174, 20);
            title.TabIndex = 0;
            title.Text = "欢迎使用修改订单功能！";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(857, 653);
            Controls.Add(panel1);
            Name = "UpdateForm";
            Text = "更新订单功能界面";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            updateBox3.ResumeLayout(false);
            updateBox3.PerformLayout();
            updateBox2.ResumeLayout(false);
            updateBox2.PerformLayout();
            updateBox1.ResumeLayout(false);
            updateBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox updateBox1;
        private Label title;
        private TextBox update_order_id_textbox;
        private Label label1;
        private GroupBox updateBox2;
        private GroupBox updateBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox update_client_number_textbox;
        private TextBox update_client_location_textbox;
        private TextBox update_client_name_textbox;
        private Button update_button;
        private TextBox update_goods_price_textbox;
        private TextBox update_goods_amount_textbox;
        private TextBox update_goods_name_textbox;
    }
}