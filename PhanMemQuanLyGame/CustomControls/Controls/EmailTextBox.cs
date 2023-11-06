using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public class EmailTextBox : TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public EmailTextBox() {
            this.Validating += EmailTextBox_Validating;
        }

        private void EmailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$";
            string inputEmail = this.Text;

            if (!Regex.IsMatch(inputEmail, emailPattern))
            {
                error.SetError(this, "Email không hợp lệ!");
                e.Cancel = true;
            } else
            {
                error.Clear();
            }
        }
    }
}
