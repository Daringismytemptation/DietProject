﻿using System;
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
    public partial class FrmHakkinda : Form
    {
        public FrmHakkinda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazırlayanlar:\n  \n Mertcan Akçamur \n Ege Sümer  \n Batuhan Bedir");
        }

        private void FrmHakkinda_Load(object sender, EventArgs e)
        {

        }
    }
}
