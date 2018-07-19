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
    public partial class CallDialog : Form
    {
        private int _customerId;

        public CallDialog(int customerId, Interaction interaction = null)
        {
            _customerId = customerId;
            this.Interaction = interaction;

            InitializeComponent();

            if (interaction != null)
            {
                var call = (Call)interaction;

                this.dtpReceiveDate.Value = call.ReceiveDateTime.Date;
                this.dtpReceiveTime.Value = DateTimePicker.MinimumDateTime.Add(call.ReceiveDateTime.TimeOfDay);
                this.txtContactName.Text = call.ContactName;
                this.chkRespondedTo.Checked = call.RespondedTo;
                this.txtPhoneNumber.Text = call.PhoneNumber;
                this.txtDescription.Text = call.Description;
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

                if (this.txtPhoneNumber.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply a phone number for the contact.";
                }

                if (this.txtPhoneNumber.Text.Trim().Length == 0)
                {
                    errorMessage = "You must supply a description of the call/voicemail.";
                }

                if (errorMessage != null)
                {
                    ShowValidationError(errorMessage);
                    e.Cancel = true;
                    return;
                }

                // Collect all the dialog info and populate a call
                if (this.Interaction == null)
                {
                    this.Interaction = new Call(_customerId)
                    {
                        ReceiveDateTime = this.dtpReceiveDate.Value.Date + this.dtpReceiveTime.Value.TimeOfDay,
                        ContactName = this.txtContactName.Text,
                        RespondedTo = this.chkRespondedTo.Checked,
                        PhoneNumber = this.txtPhoneNumber.Text,
                        Description = this.txtDescription.Text
                    };
                }
                else
                {
                    // I could have done this a couple different ways, but we need the Id to update the existing
                    // record so I just went with this approach because it's just a coding exercise.
                    this.Interaction.ReceiveDateTime = this.dtpReceiveDate.Value.Date + this.dtpReceiveTime.Value.TimeOfDay;
                    this.Interaction.ContactName = this.txtContactName.Text;
                    this.Interaction.RespondedTo = this.chkRespondedTo.Checked;
                    ((Call)this.Interaction).PhoneNumber = this.txtPhoneNumber.Text;
                    ((Call)this.Interaction).Description = this.txtDescription.Text;
                }
            }
        }
    }
}
