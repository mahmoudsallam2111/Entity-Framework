using EF_lab.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_lab
{
    public partial class Form1 : Form
    {
        ItiContext db = new ItiContext();


        public Form1()
        {
            InitializeComponent();
        }

        public void filldata()
        {
            var topic = db.Topics.Select(a => new {  a.TopName , a.TopId}).ToList();
            dgv_topic.DataSource = topic;
            combo_topic.DataSource = topic;
            combo_topic.ValueMember = "TopId";
            combo_topic.DisplayMember = "TopName";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            filldata();
         
            /// try include method on student table
            var stds = db.Students.Include(d => d.Dept).Select(s => new {s.StId ,s.StFname , s.Dept.DeptName}).ToList();
            D_G_VStudent.DataSource= stds;

        }
        // search Topics
        private void btn_srearch_Click(object sender, EventArgs e)
        {
            var txt = txt_input.Text;
            var topic = db.Topics.Where(a => a.TopName.ToLower().Contains(txt.ToLower())).ToList();
            dgv_topic.DataSource = topic;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Topic t = new Topic();

            t.TopId =(int)input_id.Value;
            t.TopName=txt_topicName.Text;
            db.Topics.Add(t);
            filldata();
            db.SaveChanges();
            MessageBox.Show("topic added successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id =(int) combo_topic.SelectedValue;
            var del_topic = db.Topics.Where(a => a.TopId == id).SingleOrDefault();
            db.Topics.Remove(del_topic);
            db.SaveChanges();
            filldata();
            MessageBox.Show("item deleted successfully");
        }
        private int id;
        // when double click on row
        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            input_id.Value =(int) dgv_topic.SelectedRows[0].Cells[0].Value;
            txt_topicName.Text = dgv_topic.SelectedRows[0].Cells[1].Value.ToString();
        }

        /// Update Topic
        private void btn_updatw_Click(object sender, EventArgs e)
        {
            var id = (int)input_id.Value;
            var newname = txt_topicName.Text.ToString();
            var top = db.Topics.Where(a =>a.TopId== id).SingleOrDefault();

            top.TopName = newname;

            db.Topics.Update(top);
            db.SaveChanges();
            filldata();



            MessageBox.Show("item Updated successfully");

        }
    }
}