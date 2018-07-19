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
    public partial class EmailDialog : Form
    {
        private int _customerId;

        public EmailDialog(int customerId, Interaction interaction = null)
        {
            _customerId = customerId;
            this.Interaction = interaction;

            InitializeComponent();

            if (interaction != null)
            {
                var email = (Email)interaction;

                this.dtpReceiveDate.Value = email.ReceiveDateTime.Date;
                this.dtpReceiveTime.Value = DateTimePicker.MinimumDateTime.Add(email.ReceiveDateTime.TimeOfDay);
                this.txtContactName.Text = email.ContactName;
                this.chkRespondedTo.Checked = email.RespondedTo;
                this.txtEmailAddress.Text = email.EmailAddress;
                this.txtSubject.Text = email.Subject;
                this.txtBody.Text = email.Body;
            }

        }

        public Interaction Interaction { get; set; }

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

        private void CallDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                string errorMessage = null;

                if (this.txtContactName.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply the contact's name.";
                }

                if (this.txtEmailAddress.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply an email address for the contact.";
                }

                if (this.txtSubject.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply the email subject.";
                }

                if (this.txtBody.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply the email body.";
                }

                if (errorMessage != null)
                {
                    ShowValidationError(errorMessage);
                    e.Cancel = true;
                    return;
                }

                // Collect all the dialog info and populate a email
                if (this.Interaction == null)
                {
                    this.Interaction = new Email(_customerId)
                    {
                        ReceiveDateTime = this.dtpReceiveDate.Value.Date + this.dtpReceiveTime.Value.TimeOfDay,
                        ContactName = this.txtContactName.Text,
                        RespondedTo = this.chkRespondedTo.Checked,
                        EmailAddress = this.txtEmailAddress.Text,
                        Subject = this.txtSubject.Text,
                        Body = this.txtBody.Text
                    };
                }
                else
                {
                    // I could have done this a couple different ways, but we need the Id to update the existing
                    // record so I just went with this approach because it's just a coding exercise.
                    this.Interaction.ReceiveDateTime = this.dtpReceiveDate.Value.Date + this.dtpReceiveTime.Value.TimeOfDay;
                    this.Interaction.ContactName = this.txtContactName.Text;
                    this.Interaction.RespondedTo = this.chkRespondedTo.Checked;
                    ((Email)this.Interaction).EmailAddress = this.txtEmailAddress.Text;
                    ((Email)this.Interaction).Subject = this.txtSubject.Text;
                    ((Email)this.Interaction).Body = this.txtBody.Text;
                }
            }
        }
    }
}
