﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0._01
{
    public partial class formRegister : Form
    {
        public formRegister()
        { 
            InitializeComponent();
            
            btnBack.Click += new EventHandler(btnBack_Click);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
