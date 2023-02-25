using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        SqlRepository sqlRepository;
        public LoginForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='C: \USERS\ANNA GREPLOVÁ\SOURCE\REPOS\ZAVERECNYPROJEKTIT4_2023\DB_ZAVERECNY_PROJEKT.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                sqlRepository.Login(tbUserName.Text, tbPassword.Text);
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }
    }
}
