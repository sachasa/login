using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class Fees_Calculator : Form
    {
        public Fees_Calculator()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double total;
            if(com_SubjectCal.SelectedIndex==0 & com_ClassCal.SelectedIndex==0)
            {
                total = 6000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 0 & com_ClassCal.SelectedIndex == 1)
            {
                total = 4000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 1 & com_ClassCal.SelectedIndex == 0)
            {
                total = 6000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 1 & com_ClassCal.SelectedIndex == 1)
            {
                total = 4000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 2 & com_ClassCal.SelectedIndex == 0)
            {
                total = 5000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 2 & com_ClassCal.SelectedIndex == 1)
            {
                total =3000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 3 & com_ClassCal.SelectedIndex == 0)
            {
                total = 5000;
                txt_Fees.Text = Convert.ToString(total);
            }
            if (com_SubjectCal.SelectedIndex == 3 & com_ClassCal.SelectedIndex == 1)
            {
                total = 3000;
                txt_Fees.Text = Convert.ToString(total);
            }
        }

        private void btn_clearCal_Click(object sender, EventArgs e)
        {
            txt_Fees.Clear();
            com_SubjectCal.Items.Remove(com_SubjectCal.SelectedItem);
            com_ClassCal.Items.Remove(com_ClassCal.SelectedItem);

        }

        private void btn_ExitCal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
