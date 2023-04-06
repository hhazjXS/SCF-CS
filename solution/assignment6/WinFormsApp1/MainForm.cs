using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //close窗口
        private void CloseForm()
        {
            foreach (Control item in this.EmbeddedPanel.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    this.panel1.Controls.Remove(form);
                }
            }
        }

        AddForm addForm;
        //删除
        DeleteForm deleteForm;
        //更新
        UpdateForm updateForm;
        //查询
        SelectForm selectForm;

        public static OrderService OS = new OrderService();
        //添加部分
        private void add_button_Click(object sender, EventArgs e)
        {
            CloseForm();
            addForm = new AddForm();
            addForm.TopLevel = false;
            addForm.FormBorderStyle = FormBorderStyle.None;
            addForm.Dock = DockStyle.Fill;
            addForm.Visible = true;
            this.EmbeddedPanel.Controls.Add(addForm);

        }
        //删除部分
        private void delete_button_Click(object sender, EventArgs e)
        {
            CloseForm();
            deleteForm = new DeleteForm();
            deleteForm.TopLevel = false;
            deleteForm.FormBorderStyle = FormBorderStyle.None;
            deleteForm.Dock = DockStyle.Fill;
            deleteForm.Visible = true;
            this.EmbeddedPanel.Controls.Add(deleteForm);
        }
        //更新部分
        private void update_button_Click(object sender, EventArgs e)
        {
            CloseForm();
            updateForm = new UpdateForm();
            updateForm.TopLevel = false;
            updateForm.FormBorderStyle = FormBorderStyle.None;
            updateForm.Dock = DockStyle.Fill;
            updateForm.Visible = true;
            this.EmbeddedPanel.Controls.Add(updateForm);
        }
        //查询部分
        private void select_button_Click(object sender, EventArgs e)
        {
            CloseForm();
            selectForm = new SelectForm();
            selectForm.TopLevel = false;
            selectForm.FormBorderStyle = FormBorderStyle.None;
            selectForm.Dock = DockStyle.Fill;
            selectForm.Visible = true;
            this.EmbeddedPanel.Controls.Add(selectForm);
        }
    }
}
