namespace WinFormsApp1
{
    partial class MainForm
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
            title = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            add_button = new Button();
            delete_button = new Button();
            update_button = new Button();
            select_button = new Button();
            panel1 = new Panel();
            EmbeddedPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Location = new Point(310, 25);
            title.Name = "title";
            title.Size = new Size(174, 20);
            title.TabIndex = 0;
            title.Text = "欢迎使用订单管理系统！";
            title.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 67);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 1;
            label1.Text = "请选择对订单的操作：";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(add_button);
            flowLayoutPanel1.Controls.Add(delete_button);
            flowLayoutPanel1.Controls.Add(update_button);
            flowLayoutPanel1.Controls.Add(select_button);
            flowLayoutPanel1.Location = new Point(3, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(808, 67);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // add_button
            // 
            add_button.Location = new Point(10, 10);
            add_button.Margin = new Padding(10);
            add_button.Name = "add_button";
            add_button.Size = new Size(140, 40);
            add_button.TabIndex = 0;
            add_button.Text = "添加订单";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(170, 10);
            delete_button.Margin = new Padding(10);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(140, 40);
            delete_button.TabIndex = 1;
            delete_button.Text = "删除订单";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.Location = new Point(330, 10);
            update_button.Margin = new Padding(10);
            update_button.Name = "update_button";
            update_button.Size = new Size(140, 40);
            update_button.TabIndex = 2;
            update_button.Text = "修改订单";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // select_button
            // 
            select_button.Location = new Point(490, 10);
            select_button.Margin = new Padding(10);
            select_button.Name = "select_button";
            select_button.Size = new Size(140, 40);
            select_button.TabIndex = 3;
            select_button.Text = "查询订单";
            select_button.UseVisualStyleBackColor = true;
            select_button.Click += select_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(EmbeddedPanel);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 562);
            panel1.TabIndex = 3;
            // 
            // EmbeddedPanel
            // 
            EmbeddedPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmbeddedPanel.BorderStyle = BorderStyle.FixedSingle;
            EmbeddedPanel.Location = new Point(3, 178);
            EmbeddedPanel.Name = "EmbeddedPanel";
            EmbeddedPanel.Size = new Size(808, 381);
            EmbeddedPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(838, 586);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "订单管理系统主窗口";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button add_button;
        private Button delete_button;
        private Button update_button;
        private Button select_button;
        private Panel EmbeddedPanel;
    }
}