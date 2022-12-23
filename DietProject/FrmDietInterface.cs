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
    public partial class FrmInterface : Form
    {
        User user;
        public FrmInterface()
        {
            InitializeComponent();
        }
        public FrmInterface(User gelenUser)
        {
            InitializeComponent();
            this.user = gelenUser;
        }

    }
}
