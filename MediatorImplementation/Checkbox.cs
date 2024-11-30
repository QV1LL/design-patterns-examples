using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorImplementation
{
    internal class Checkbox
    {
        public bool IsChecked { get; private set; } = false;
        private readonly IMediator _mediator;

        public Checkbox(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Toggle()
        {
            IsChecked = !IsChecked;
            _mediator.Notify(this, "CheckboxChanged");
        }
    }
}
