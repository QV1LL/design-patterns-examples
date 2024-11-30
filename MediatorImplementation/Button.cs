using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorImplementation
{
    internal class Button
    {
        public bool IsEnabled { get; set; } = false;
        private readonly IMediator _mediator;

        public Button(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Click()
        {
            if (IsEnabled)
            {
                _mediator.Notify(this, "SubmitClicked");
            }
        }
    }
}
