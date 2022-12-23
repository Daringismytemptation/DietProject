using DietProject.BLL.Services;
using DietProject.DAL;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    public partial class FrmInterface : Form
    {
        UserService userService;
        CaloriesDBContext db;
        User gelenUser;
        public FrmInterface()
        {
            InitializeComponent();
        }
        public FrmInterface(User gelenUser)
        {
            userService = new UserService();
            db = new CaloriesDBContext();
            InitializeComponent();
            this.gelenUser = gelenUser;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmInterface_Load(object sender, EventArgs e)
        {
            cmbOgunler.Items.Add(db.Meals.Select(x=>x.MealName).First());
        }


        //private void btnGoruntule_Click(object sender, EventArgs e)
        //{

        //    var a = db.Users.Where(x => x.ID == gelenUser.ID).FirstOrDefault();
        //    var b = db.UserMeals.Where(x => x.UserID == gelenUser.ID).FirstOrDefault();

        //    var c= db.Meals.Select(x=> new {x.ID,x.E})




        //}
    }
}
