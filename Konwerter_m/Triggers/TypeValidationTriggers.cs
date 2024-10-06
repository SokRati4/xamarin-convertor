using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace Konwerter_m.Triggers
{
    class TypeValidationTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text == null || sender.Text == "-" || sender.Text == "+" || sender.Text == ".")
                sender.BackgroundColor = Color.Red;
            else
                sender.BackgroundColor = Color.Default;
        }
    }

}
