using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        public __gc class NewAccount : public System::Windows::Forms::Form
	{
	public: 
		NewAccount(void)
        {
            InitializeComponent();
        }

        String* Username;
        String* Password;

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private: System::Void btnClose_Click(System::Object* sender, System::EventArgs* e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private: System::Void btnOK_Click(System::Object* sender, System::EventArgs* e)
        {
            Username = this->txtUsername->Text;
            Password = this->txtPassword->Text;
            String* ConfPass = this->txtConfirmPassword->Text;

            if (Username->Equals(S"") == true)
            {
                MessageBox::Show(S"Invalid Username: We don't accept an empty username!");
                this->txtUsername->Focus();
                return;
            }
            if (Password->Equals(S"") == true)
            {
                MessageBox::Show(S"Invalid Password: We don't accept a blank password!");
                this->txtPassword->Focus();
                return;
            }
            if (String::Compare(Password, ConfPass) != 0)
            {
                MessageBox::Show(S"The passwords you provided are not the same!");
                this->txtPassword->Focus();
                return;
            }

            this->DialogResult = DialogResult::OK;
            Close();
        }


    }
}
