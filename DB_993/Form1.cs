using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_993
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationContex applicationContex = new ApplicationContex();
            applicationContex.ApplicationContext();
        }
    }
}
