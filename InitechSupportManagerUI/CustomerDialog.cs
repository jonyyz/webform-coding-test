using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InitechSupportManagement.Entity;

namespace InitechSupportManagerUI
{
    public partial class CustomerDialog : Form
    {
        public CustomerDialog(Customer customer = null)
        {
            this.Customer = customer;
            
            InitializeComponent();

            if (customer != null)
            {
                this.txtCompanyName.Text = customer.CompanyName;
                this.txtStreetAddress1.Text = customer.Address.StreetAddressOne;
                this.txtStreetAddress2.Text = customer.Address.StreetAddressTwo;
                this.txtCity.Text = customer.Address.City;
                this.txtState.Text = customer.Address.State;
                this.txtZip.Text = customer.Address.Zip;
            }
        }

        public Customer Customer { get; set; }

        private void ShowValidationError(string text)
        {
            MessageBox.Show(
                this,
                text,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
  
        private void CustomerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                string errorMessage = null;

                if (this.txtCompanyName.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply at least a Company Name.";
                }

                if (errorMessage != null)
                {
                    ShowValidationError(errorMessage);
                    e.Cancel = true;
                    return;
                }

                // Collect all the dialog info and populate a customer
                if (this.Customer == null)
                {
                    this.Customer = new Customer()
                    {
                        CompanyName = this.txtCompanyName.Text,
                        Address = new Address()
                        {
                            StreetAddressOne = this.txtStreetAddress1.Text,
                            StreetAddressTwo = this.txtStreetAddress2.Text,
                            City = this.txtCity.Text,
                            State = this.txtState.Text,
                            Zip = this.txtZip.Text
                        },
                        SoftwarePurchaseDate = this.dtpSoftwarePurchaseDate.Value
                    };
                }
                else
                {
                    // I could have done this a couple different ways, but we need the Id to update the existing
                    // record so I just went with this approach because it's just a coding exercise.
                    this.Customer.CompanyName = this.txtCompanyName.Text;
                    this.Customer.Address.StreetAddressOne = this.txtStreetAddress1.Text;
                    this.Customer.Address.StreetAddressTwo = this.txtStreetAddress2.Text;
                    this.Customer.Address.City = this.txtCity.Text;
                    this.Customer.Address.State = this.txtState.Text;
                    this.Customer.Address.Zip = this.txtZip.Text;
                }
            }

        }
    }
}
