using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Source.interfaces
{
    interface INotification
    {
        void Notify(string subject, string message);
    }
}
