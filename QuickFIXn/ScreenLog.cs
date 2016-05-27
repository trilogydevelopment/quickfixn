
namespace QuickFix
{
    /// <summary>
    /// FIXME - needs to log sessionIDs, timestamps, etc.
    /// </summary>
    public class ScreenLog : ILog, ILogEventsWithDetail
    {
        private object sync_ = new object();
        private bool logIncoming_;
        private bool logOutgoing_;
        private bool logEvent_;

        public ScreenLog(SessionID sessionID, bool logIncoming, bool logOutgoing, bool logEvent)
        {
            logIncoming_ = logIncoming;
            logOutgoing_ = logOutgoing;
            logEvent_ = logEvent;
        }

        #region ILog Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        {
            if (!logIncoming_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<incoming> " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            if (!logOutgoing_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<outgoing> " + msg);
            }
        }

        public void OnEvent(string s)
        {
            if (!logEvent_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<event> " + s);
            }
        }
        public void OnEvent(string s, Severity severity, System.Exception ex)
        {
            if (!logEvent_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<event> (" + severity + ") " + s);
                var exception = ex;
                while(exception != null) {
                    System.Console.WriteLine("  >> Caused by " + exception.GetType().Name + ": " + exception.Message);
                    System.Console.WriteLine("  >> At: " + exception.StackTrace);
                    exception = exception.InnerException;
                }
            }
        }

        public void Dispose()
        { }

        #endregion
    }
}
