using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;

namespace GFL_Application
{
    public partial class frmLogin : Form
    {
        GameLogin gLogin = new GameLogin();
        frmMain frmMain = new frmMain();
        public frmLogin()
        {
            InitializeComponent();
            gLogin.getForm(frmMain);
        }
    }
}
