using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class AdminUsersControl : Form
    {
        SqlRepository sqlRepository;

        public AdminUsersControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }


    }
}
