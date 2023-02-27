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
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='899BAC5729D42BA087F0616BC1630C93_ICKÁ A ZDRAVOTNICKÁ A STŘEDNÍ ŠKOLA BOSKOVICE, PŘÍSPĚVKOVÁ ORGANIZACE\PRG\PROJEKT\PROJEKTDB.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                sqlRepository.Register(tbUserName.Text, tbPassword.Text);
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }
    }
}
