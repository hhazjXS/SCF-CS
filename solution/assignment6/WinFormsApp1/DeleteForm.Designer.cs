namespace WinFormsApp1
{
    partial class DeleteForm
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
            delete_button = new Button();
            deleteBox = new GroupBox();
            delete_order_id_textbox = new TextBox();
            label1 = new Label();
            title = new Label();
            panel1.SuspendLayout();
            deleteBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(deleteBox);
            panel1.Controls.Add(title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 340);
            panel1.TabIndex = 0;
            // 
            // delete_button
            // 
            delete_button.Anchor = AnchorStyles.Top;
            delete_button.Location = new Point(311, 232);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(140, 40);
            delete_button.TabIndex = 2;
            delete_button.Text = "确认删除";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // deleteBox
            // 
            deleteBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deleteBox.BackColor = SystemColors.ActiveBorder;
            deleteBox.Controls.Add(delete_order_id_textbox);
            deleteBox.Controls.Add(label1);
            deleteBox.Location = new Point(3, 60);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(750, 117);
            deleteBox.TabIndex = 1;
            deleteBox.TabStop = false;
            deleteBox.Text = "删除订单信息";
            // 
            // delete_order_id_textbox
            // 
            delete_order_id_textbox.Location = new Point(221, 57);
            delete_order_id_textbox.Name = "delete_order_id_textbox";
            delete_order_id_textbox.Size = new Size(218, 27);
            delete_order_id_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "请输入要删除的订单号：";
            label1.Click += label1_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Location = new Point(291, 25);
            title.Name = "title";
            title.Size = new Size(69, 20);
            title.TabIndex = 0;
            title.Text = "删除订单";
            title.Click += title_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(780, 359);
            Controls.Add(panel1);
            Name = "DeleteForm";
            Text = "删除订单功能界面";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            deleteBox.ResumeLayout(false);
            deleteBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox deleteBox;
        private Label title;
        private Label label1;
        private TextBox delete_order_id_textbox;
        private Button delete_button;
    }
}