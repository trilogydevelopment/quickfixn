
namespace QuickFix
{
    /// <summary>
    /// Log implementation that does not do anything
    /// </summary>
    public class NullLog : ILog, ILogEventsWithDetail
    {
        #region ILog Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        { }

        public void OnOutgoing(string msg)
        { }

        public void OnEvent(string s)
        { }

        public void OnEvent(string s, Severity severity, System.Exception ex)
        { }

        public void Dispose()
        { }

        #endregion 
    }
}
