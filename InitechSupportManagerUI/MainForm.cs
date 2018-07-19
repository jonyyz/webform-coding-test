using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InitechSupportManagement;
using InitechSupportManagement.Entity;

namespace InitechSupportManagerUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var dialog = new CustomerDialog();
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var customer = dialog.Customer;

                SupportService.Customers.Add(customer);

                this.cboCustomer.Items.Clear();

                var customers = SupportService.Customers.GetAll();

                foreach (var c in customers)
                {
                    this.cboCustomer.Items.Add(c);

                    if (c.Id == customer.Id)
                    {
                        this.cboCustomer.SelectedItem = c;
                    }
                }
            }
        }


        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected())
            {
                return;
            }

            var dialog = new CustomerDialog((Customer)cboCustomer.SelectedItem);
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.cboCustomer.Items[this.cboCustomer.SelectedIndex] = dialog.Customer;
            }
        }

        private bool CheckCustomerSelected()
        {
            if (this.cboCustomer.SelectedItem == null)
            {
                MessageBox.Show(
                    this,
                    "You must select a customer first.",
                    "Customer not Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        private void AddInteractionToList(Interaction interaction)
        {
            var index = this.dgvInteractions.Rows.Add();
            var row = this.dgvInteractions.Rows[index];

            UpdateInteractionRow(row, interaction);

            row.Tag = interaction;

            this.dgvInteractions.Rows.Remove(row);
            this.dgvInteractions.Rows.Insert(0, row);

            row.Selected = true;
        }

        private void btnLogCall_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected())
            {
                return;
            }

            var dialog = new CallDialog(((Customer)this.cboCustomer.SelectedItem).Id.Value);
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var interaction = dialog.Interaction;

                SupportService.Interactions.Add(interaction);
                AddInteractionToList(interaction);
            }
        }

        private void btnLogEmail_Click(object sender, EventArgs e)
        {
            if (!CheckCustomerSelected())
            {
                return;
            }

            var dialog = new EmailDialog(((Customer)this.cboCustomer.SelectedItem).Id.Value);
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var interaction = dialog.Interaction;

                SupportService.Interactions.Add(interaction);
                AddInteractionToList(interaction);
            }
        }

        private void lvwInteractions_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;

                using (var headerFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(Brushes.SteelBlue, e.Bounds);
                    e.Graphics.DrawString(
                        e.Header.Text,
                        headerFont,
                        Brushes.White,
                        e.Bounds,
                        sf
                    );
                    e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
                }
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboCustomer.SelectedItem != null)
            {
                var customer = (Customer)this.cboCustomer.SelectedItem;
                var interactions = SupportService.Interactions.Get(i => i.CustomerId == customer.Id);

                this.dgvInteractions.Rows.Clear();

                foreach (var interaction in interactions)
                {
                    this.AddInteractionToList(interaction);
                }
            }
        }

        private void UpdateInteractionRow(DataGridViewRow row, Interaction interaction)
        {
            row.Cells[0].Value = interaction.ReceiveDateTime.ToString();
            row.Cells[1].Value = interaction.InteractionType.ToString();
            row.Cells[2].Value = interaction.ContactName;
            row.Cells[3].Value = interaction.RespondedTo;
        }

        private Form CreateDialogForInteraction(
            int customerId,
            Interaction interaction
        ) {
            Form dialog = null;

            switch(interaction.InteractionType)
            {
                case InteractionType.Call:
                    dialog = new CallDialog(customerId, interaction);
                    break;

                case InteractionType.Email:
                    dialog = new EmailDialog(customerId, interaction);
                    break;
            }

            if(dialog == null)
            {
                throw new ArgumentException(String.Format("Cannot create dialog.  Unknown interaction type: {0}", interaction.InteractionType));
            }

            return dialog;
        }

        private void dgvInteractions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dgvInteractions.Rows[e.RowIndex];
            var dialog = CreateDialogForInteraction(
                ((Customer)this.cboCustomer.SelectedItem).Id.Value,
                (Interaction)row.Tag
            );
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                // I wouldn't normally do this but it's a hack around having to create a base dialog
                // class
                var interaction = (Interaction)dialog.GetType().GetProperty("Interaction").GetValue(dialog);
                UpdateInteractionRow(row, interaction);
            }
        }
    }
}
