using WindowsFormsApp1.Source.interfaces;

namespace WindowsFormsApp1.Source
{
    class CProblemNotification : INotification
    {
        private const char TYPE = 'P';
        private string s_subject;
        private string s_message;

        public CProblemNotification()
        {
            s_subject = null;
            s_message = null;
        }

        public void Notify(string sSubject, string sMessage)
        {
            s_subject = sSubject;
            s_message = sMessage;
        }

        public override string ToString() => TYPE + ";" + s_subject + ";" + s_message;
    }
}
