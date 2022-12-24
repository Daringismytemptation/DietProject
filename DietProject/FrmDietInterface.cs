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
        ChoiseService choiseService;
        FoodService foodService;
        CategoryService categoryService;
        MealService mealService;
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
            mealService = new MealService();
            categoryService = new CategoryService();
            foodService = new FoodService();
            choiseService = new ChoiseService();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            var d = choiseService.GetCalorie(cmbFoodName.SelectedItem.ToString());
            Choise choise=new Choise();
            choise.Meal=cmbOgunler.SelectedItem.ToString();
            choise.Category=cmbKategoriler.SelectedItem.ToString();
            choise.FoodName=cmbFoodName.SelectedItem.ToString();
            choise.Portion = Convert.ToDecimal(txtFoodGram.Text) / 100 * d;
            choise.ExtraCalori = Convert.ToDecimal(txtExtraCalorie.Text);
            choise.RelevantDate = dtpTarih.Value;
            choise.UserID = gelenUser.ID;
            choiseService.Insert(choise);
            ListTheDataSource();

            //var tarihfiltresi = db.Choises.Where(x => x.RelevantDate == p);
            //var userfiltresidahil = tarihfiltresi.Where(x => x.User.ID == gelenUser.ID);
            //var sonuc = userfiltresidahil.Select(x => new { x.ID, x.Meal, x.Category, x.FoodName, x.Portion, x.ExtraCalori, ToplamKalori = (x.ExtraCalori + x.Portion) }).ToList();
            //dgvKullanici.DataSource = sonuc.ToList();

        }
       void ListTheDataSource()
        {
            var p = dtpTarih.Value;
            dgvKullanici.DataSource = db.Choises.Where(a => a.RelevantDate == p && a.User.ID == gelenUser.ID).Select(x => new { x.ID, x.Meal, x.Category, x.FoodName, x.Portion, x.ExtraCalori, ToplamKalori = (x.ExtraCalori + x.Portion) }).ToList();
        }

        private void FrmInterface_Load(object sender, EventArgs e)
        {
            CbFillWithSpecialties();
        }

        /// <summary>
        /// İlgili Kategori ve Öğün Kavramlarının Form Ekranlarında Dolması
        /// </summary>
        public void CbFillWithSpecialties()
        {
            var meals = mealService.Meals();
            foreach (var item in meals)
            {
                cmbOgunler.Items.Add(item.MealName);
            }
            var categories = categoryService.Categories();
            foreach (var item in categories)
            {
                cmbKategoriler.Items.Add(item.Name);
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFoodName.SelectedIndex = -1;
            cmbFoodName.Items.Clear();
            
            string categoryName = cmbKategoriler.SelectedItem.ToString();
            var foods = foodService.foods(categoryName);
            foreach (var item in foods)
            {
                cmbFoodName.Items.Add(item.Name);
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            ListTheDataSource();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var a= Convert.ToInt32(dgvKullanici.SelectedCells[0].Value);
            choiseService.Delete(a);
            // var c = db.Choises.Where(x => x.ID == a).FirstOrDefault();
            //db.Choises.Remove(c);
            //db.SaveChanges();
            btnGoruntule.PerformClick();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvKullanici_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = Convert.ToInt32(dgvKullanici.SelectedCells[0].Value);
            var choice = choiseService.SelectChoice(Id);

            cmbFoodName.Text = choice.FoodName;
            var d = choiseService.GetCalorie(cmbFoodName.Text);

            cmbKategoriler.Text = choice.Category;
            cmbOgunler.Text = choice.Meal;
            txtExtraCalorie.Text = choice.ExtraCalori.ToString();
            txtFoodGram.Text = ((choice.Portion * 100) / d).ToString();
        }
    }
}
