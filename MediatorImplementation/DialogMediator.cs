using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MediatorImplementation
{
    internal class DialogMediator : IMediator
    {
        public Button SubmitButton { get; set; }
        public Checkbox TermsCheckbox { get; set; }
        public Label MessageLabel { get; set; }

        public void Notify(object sender, string eventDetails)
        {
            if (eventDetails == "CheckboxChanged")
            {
                if (TermsCheckbox.IsChecked)
                {
                    SubmitButton.IsEnabled = true;
                    MessageLabel.Text = "You can now submit.";
                }
                else
                {
                    SubmitButton.IsEnabled = false;
                    MessageLabel.Text = "Please accept the terms to proceed.";
                }
            }
            else if (eventDetails == "SubmitClicked")
            {
                if (TermsCheckbox.IsChecked)
                {
                    MessageLabel.Text = "Form submitted successfully!";
                }
            }
        }
    }
}
