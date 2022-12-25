using DietProject.BLL.Services;
using DietProject.DAL;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    
    public partial class FrmAdmin : Form
    {
        CaloriesDBContext db;

        public FrmAdmin()
        {
            InitializeComponent();
            userService = new UserService();
           // passiveUsers = new List<User>();
           db= new CaloriesDBContext();
        }
        UserService userService;
        List<User> passiveUsers;

        private void FrmAdmin_Load_1(object sender, EventArgs e)
        {
            passiveUsers = userService.GetPassiveUsers();
            FillListView();
        }


        public void FillListView()
        {
            lvAdmin.Items.Clear();
            ListViewItem lvi;
            foreach (User item in passiveUsers)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FirstName;
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.Email);
                lvi.SubItems.Add(item.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = item.ID;
                lvAdmin.Items.Add(lvi);
            }
        }

        private void lvAdmin_DoubleClick_1(object sender, EventArgs e)
        {
            int userID = (int)lvAdmin.SelectedItems[0].Tag;

            try
            {
                userService.ActivateUser(userID);
                FillListView();
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listmeal = new List<string>();
            listmeal.Add("Sabah");
            listmeal.Add("Öğlen");
            listmeal.Add("İkindi");
            listmeal.Add("Akşam");
            listmeal.Add("Brunch");
            listmeal.Add("Gece");

            for (int i = 0; i < listmeal.Count; i++)
            {
                Meal Meal = new Meal();
                Meal.MealName = listmeal[i];
                db.Meals.Add(Meal);
                db.SaveChanges();
            }

            List<string> listcategory = new List<string>();
            listcategory.Add("Tatlılar");
            listcategory.Add("Etler");
            listcategory.Add("TahılveBakliyatgiller");
            listcategory.Add("Meyveler");
            listcategory.Add("Kahvaltılar");
            listcategory.Add("Atıştırmalıklar");

            foreach (var item in listcategory)
            {
                Category category = new Category();
                category.Name = item;
                db.Categories.Add(category);
                db.SaveChanges();
            }

            Food food = new Food()
            {
                Name = "Sufle",
                CalorieAmountPer100gr = 387,
                CategoryID=1,
                
            };
            Food food1 = new Food()
            {
                Name = "Islak Kek",
                CalorieAmountPer100gr = 357,
                CategoryID = 1,

            };

            Food food2 = new Food()
            {
                Name = "Alabalık",
                CalorieAmountPer100gr = 168,
                CategoryID = 2,

            };
            Food food3 = new Food()
            {
                Name = "Bonfile",
                CalorieAmountPer100gr = 400,
                CategoryID = 2,

            };

            Food food4 = new Food()
            {
                Name = "Nohut",
                CalorieAmountPer100gr = 410,
                CategoryID = 3,

            };
            Food food5 = new Food()
            {
                Name = "Bezelye",
                CalorieAmountPer100gr = 80,
                CategoryID = 3,

            };

            Food food6 = new Food()
            {
                Name = "Avokado",
                CalorieAmountPer100gr = 150,
                CategoryID = 4,

            };
            Food food7 = new Food()
            {
                Name = "Mango",
                CalorieAmountPer100gr = 60,
                CategoryID = 4,

            };

            Food food8 = new Food()
            {
                Name = "Yumurta",
                CalorieAmountPer100gr = 155,
                CategoryID = 5,

            };
            Food food9 = new Food()
            {
                Name = "Ekmek",
                CalorieAmountPer100gr = 220,
                CategoryID = 5,

            };
            Food food10 = new Food()
            {
                Name = "Cips",
                CalorieAmountPer100gr = 490,
                CategoryID = 6,

            };

            Food food11 = new Food()
            {
                Name = "Tuzlu Kraker",
                CalorieAmountPer100gr = 230,
                CategoryID = 6,
            };












        }
    }
}
