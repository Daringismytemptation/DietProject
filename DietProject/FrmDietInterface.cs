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
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          
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
            cmbFoodName.Items.Clear();
            cmbFoodName.SelectedIndex = -1;
           var a= cmbKategoriler.SelectedItem.ToString();
           var b= db.Categories.Where(x => x.Name == a).ToList();
            foreach (var item in b)
            {
                foreach (var items in item.Foods)
                {
                    cmbFoodName.Items.Add(items.Name);
                }
            }
        }
    }
}
