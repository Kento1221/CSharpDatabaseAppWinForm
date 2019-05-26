using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Source.interfaces;

namespace WindowsFormsApp1.Source
{
    class ProblemNotification : INotification
    {
        private const char TYPE = 'P';
        private string _subject;
        private string _message;

        public ProblemNotification()
        {
            _subject = null;
            _message = null;
        }

        public void Notify(string subject, string message)
        {
            _subject = subject;
            _message = message;
        }

        public override string ToString() => TYPE + ";" + _subject + ";" + _message;
    }
}
