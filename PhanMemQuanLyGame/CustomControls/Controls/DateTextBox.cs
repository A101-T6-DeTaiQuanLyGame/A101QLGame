using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public class DateTextBox : MaskedTextBox
    {
        ErrorProvider error = new ErrorProvider();

        public DateTextBox() {
            this.Mask = "00/00/0000";
            this.PromptChar = '_';
            this.TextAlign = HorizontalAlignment.Center;

            this.Validating += DateTextBox_Validating;
        }

        private void DateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = this.Text;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                error.SetError(this, "Ngày/Tháng/Năm không hợp lệ!");
                e.Cancel = true;
            }
            else
            {
                error.Clear();
            }
        }
    }
}
