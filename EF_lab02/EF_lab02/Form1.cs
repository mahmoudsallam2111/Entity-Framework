using EF_lab02.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_lab02
{
    public partial class Form1 : Form
    {
        JournalContext db = new JournalContext();
        public Form1()
        {
            InitializeComponent();
        }

        public void filldata()
        {
            var news = db.News.Include(a=>a.Auther).Select(a => new { a.Id, a.datetime, a.Title , a.Bref , a.AutherId ,a.Auther.Name , a.Auther.Hiredate }).ToList();
            D_G_V_NEWS.DataSource = news;

            var authers = db.Authers.Select(a => new { a.Id, a.Name }).ToList();
           combo_autherId.DataSource = authers;
            combo_autherId.ValueMember = "Id";
            combo_autherId.DisplayMember = "Name";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filldata();

        }

      

       
/// add news
        private void btn_add_Click(object sender, EventArgs e)
        {
            News n = new News();



            n.Title =txt_title.Text;
            n.Bref = txt_bref.Text;
            n.datetime = (DateTime)D_T_P.Value;
            n.AutherId = (int)combo_autherId.SelectedValue;

            db.News.Add(n);
            filldata();
            db.SaveChanges();
            MessageBox.Show("news added successfully");

        }

        private int id; 
        // onrowheaderdoubleclick event
        private void D_G_V_NEWS_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id=(int)D_G_V_NEWS.SelectedRows[0].Cells[0].Value;
            D_T_P.Value =(DateTime) D_G_V_NEWS.SelectedRows[0].Cells[1].Value;
            txt_title.Text = D_G_V_NEWS.SelectedRows[0].Cells[2].Value.ToString();
            txt_bref.Text = D_G_V_NEWS.SelectedRows[0].Cells[3].Value.ToString();
            combo_autherId.SelectedValue =(int) D_G_V_NEWS.SelectedRows[0].Cells[4].Value;

        }
        //delete news
        private void btn_del_Click(object sender, EventArgs e)
        {
            var news = db.News.Where(n=>n.Id==id).SingleOrDefault();
            db.News.Remove(news);
            db.SaveChanges();
            filldata();
            MessageBox.Show("deleted successfully");
        }
        // update news
        private void btn_update_Click(object sender, EventArgs e)
        {
            var Updatednew = db.News.Where(n => n.Id == id).SingleOrDefault();
            Updatednew.Title = txt_title.Text;
            Updatednew.Bref = txt_bref.Text;
            Updatednew.AutherId = (int)combo_autherId.SelectedValue;
            Updatednew.datetime = (DateTime)D_T_P.Value;
            db.News.Update(Updatednew); 
            db.SaveChanges();
            filldata();

            MessageBox.Show("item Updated successfully");

        }

       
    }
}