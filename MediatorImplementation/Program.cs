using System;

namespace MediatorImplementation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mediator = new DialogMediator();

            var submitButton = new Button(mediator);
            var termsCheckbox = new Checkbox(mediator);
            var messageLabel = new Label();

            mediator.SubmitButton = submitButton;
            mediator.TermsCheckbox = termsCheckbox;
            mediator.MessageLabel = messageLabel;

            Console.WriteLine($"Message: {messageLabel.Text}");
            Console.WriteLine($"Submit Button Enabled: {submitButton.IsEnabled}");

            termsCheckbox.Toggle();
            Console.WriteLine($"Message: {messageLabel.Text}");
            Console.WriteLine($"Submit Button Enabled: {submitButton.IsEnabled}");

            submitButton.Click();
            Console.WriteLine($"Message: {messageLabel.Text}");
            Console.WriteLine($"Submit Button Enabled: {submitButton.IsEnabled}");

            termsCheckbox.Toggle();
            Console.WriteLine($"Message: {messageLabel.Text}");
            Console.WriteLine($"Submit Button Enabled: {submitButton.IsEnabled}");
        }
    }
}