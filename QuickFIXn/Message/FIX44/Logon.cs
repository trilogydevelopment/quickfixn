// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class Logon : Message
        {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("A"));
            }

            public Logon(
                    QuickFix.Fields.EncryptMethod aEncryptMethod,
                    QuickFix.Fields.HeartBtInt aHeartBtInt
                ) : this()
            {
                this.EncryptMethod = aEncryptMethod;
                this.HeartBtInt = aHeartBtInt;
            }

            public QuickFix.Fields.EncryptMethod EncryptMethod
            { 
                get 
                {
                    QuickFix.Fields.EncryptMethod val = new QuickFix.Fields.EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptMethod val) 
            { 
                this.EncryptMethod = val;
            }
            
            public QuickFix.Fields.EncryptMethod Get(QuickFix.Fields.EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(Tags.EncryptMethod);
            }
            public QuickFix.Fields.HeartBtInt HeartBtInt
            { 
                get 
                {
                    QuickFix.Fields.HeartBtInt val = new QuickFix.Fields.HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HeartBtInt val) 
            { 
                this.HeartBtInt = val;
            }
            
            public QuickFix.Fields.HeartBtInt Get(QuickFix.Fields.HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(Tags.HeartBtInt);
            }
            public QuickFix.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawDataLength val) 
            { 
                this.RawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData RawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawData val) 
            { 
                this.RawData = val;
            }
            
            public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(Tags.RawData);
            }
            public QuickFix.Fields.ResetSeqNumFlag ResetSeqNumFlag
            { 
                get 
                {
                    QuickFix.Fields.ResetSeqNumFlag val = new QuickFix.Fields.ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                this.ResetSeqNumFlag = val;
            }
            
            public QuickFix.Fields.ResetSeqNumFlag Get(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(Tags.ResetSeqNumFlag);
            }
            public QuickFix.Fields.NextExpectedMsgSeqNum NextExpectedMsgSeqNum
            { 
                get 
                {
                    QuickFix.Fields.NextExpectedMsgSeqNum val = new QuickFix.Fields.NextExpectedMsgSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                this.NextExpectedMsgSeqNum = val;
            }
            
            public QuickFix.Fields.NextExpectedMsgSeqNum Get(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                return IsSetNextExpectedMsgSeqNum();
            }
            
            public bool IsSetNextExpectedMsgSeqNum() 
            { 
                return IsSetField(Tags.NextExpectedMsgSeqNum);
            }
            public QuickFix.Fields.MaxMessageSize MaxMessageSize
            { 
                get 
                {
                    QuickFix.Fields.MaxMessageSize val = new QuickFix.Fields.MaxMessageSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxMessageSize val) 
            { 
                this.MaxMessageSize = val;
            }
            
            public QuickFix.Fields.MaxMessageSize Get(QuickFix.Fields.MaxMessageSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxMessageSize val) 
            { 
                return IsSetMaxMessageSize();
            }
            
            public bool IsSetMaxMessageSize() 
            { 
                return IsSetField(Tags.MaxMessageSize);
            }
            public QuickFix.Fields.NoMsgTypes NoMsgTypes
            { 
                get 
                {
                    QuickFix.Fields.NoMsgTypes val = new QuickFix.Fields.NoMsgTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMsgTypes val) 
            { 
                this.NoMsgTypes = val;
            }
            
            public QuickFix.Fields.NoMsgTypes Get(QuickFix.Fields.NoMsgTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMsgTypes val) 
            { 
                return IsSetNoMsgTypes();
            }
            
            public bool IsSetNoMsgTypes() 
            { 
                return IsSetField(Tags.NoMsgTypes);
            }
            public QuickFix.Fields.TestMessageIndicator TestMessageIndicator
            { 
                get 
                {
                    QuickFix.Fields.TestMessageIndicator val = new QuickFix.Fields.TestMessageIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TestMessageIndicator val) 
            { 
                this.TestMessageIndicator = val;
            }
            
            public QuickFix.Fields.TestMessageIndicator Get(QuickFix.Fields.TestMessageIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TestMessageIndicator val) 
            { 
                return IsSetTestMessageIndicator();
            }
            
            public bool IsSetTestMessageIndicator() 
            { 
                return IsSetField(Tags.TestMessageIndicator);
            }
            public QuickFix.Fields.Username Username
            { 
                get 
                {
                    QuickFix.Fields.Username val = new QuickFix.Fields.Username();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Username val) 
            { 
                this.Username = val;
            }
            
            public QuickFix.Fields.Username Get(QuickFix.Fields.Username val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Username val) 
            { 
                return IsSetUsername();
            }
            
            public bool IsSetUsername() 
            { 
                return IsSetField(Tags.Username);
            }
            public QuickFix.Fields.Password Password
            { 
                get 
                {
                    QuickFix.Fields.Password val = new QuickFix.Fields.Password();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Password val) 
            { 
                this.Password = val;
            }
            
            public QuickFix.Fields.Password Get(QuickFix.Fields.Password val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Password val) 
            { 
                return IsSetPassword();
            }
            
            public bool IsSetPassword() 
            { 
                return IsSetField(Tags.Password);
            }
            public QuickFix.Fields.StrategyPreference StrategyPreference
            { 
                get 
                {
                    QuickFix.Fields.StrategyPreference val = new QuickFix.Fields.StrategyPreference();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrategyPreference val) 
            { 
                this.StrategyPreference = val;
            }
            
            public QuickFix.Fields.StrategyPreference Get(QuickFix.Fields.StrategyPreference val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrategyPreference val) 
            { 
                return IsSetStrategyPreference();
            }
            
            public bool IsSetStrategyPreference() 
            { 
                return IsSetField(Tags.StrategyPreference);
            }
            public QuickFix.Fields.ApplicationName ApplicationName
            { 
                get 
                {
                    QuickFix.Fields.ApplicationName val = new QuickFix.Fields.ApplicationName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplicationName val) 
            { 
                this.ApplicationName = val;
            }
            
            public QuickFix.Fields.ApplicationName Get(QuickFix.Fields.ApplicationName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplicationName val) 
            { 
                return IsSetApplicationName();
            }
            
            public bool IsSetApplicationName() 
            { 
                return IsSetField(Tags.ApplicationName);
            }
            public QuickFix.Fields.ApplicationVersion ApplicationVersion
            { 
                get 
                {
                    QuickFix.Fields.ApplicationVersion val = new QuickFix.Fields.ApplicationVersion();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplicationVersion val) 
            { 
                this.ApplicationVersion = val;
            }
            
            public QuickFix.Fields.ApplicationVersion Get(QuickFix.Fields.ApplicationVersion val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplicationVersion val) 
            { 
                return IsSetApplicationVersion();
            }
            
            public bool IsSetApplicationVersion() 
            { 
                return IsSetField(Tags.ApplicationVersion);
            }
            public QuickFix.Fields.ApplicationVendor ApplicationVendor
            { 
                get 
                {
                    QuickFix.Fields.ApplicationVendor val = new QuickFix.Fields.ApplicationVendor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplicationVendor val) 
            { 
                this.ApplicationVendor = val;
            }
            
            public QuickFix.Fields.ApplicationVendor Get(QuickFix.Fields.ApplicationVendor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplicationVendor val) 
            { 
                return IsSetApplicationVendor();
            }
            
            public bool IsSetApplicationVendor() 
            { 
                return IsSetField(Tags.ApplicationVendor);
            }
            public QuickFix.Fields.TimeStampPreference TimeStampPreference
            { 
                get 
                {
                    QuickFix.Fields.TimeStampPreference val = new QuickFix.Fields.TimeStampPreference();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeStampPreference val) 
            { 
                this.TimeStampPreference = val;
            }
            
            public QuickFix.Fields.TimeStampPreference Get(QuickFix.Fields.TimeStampPreference val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeStampPreference val) 
            { 
                return IsSetTimeStampPreference();
            }
            
            public bool IsSetTimeStampPreference() 
            { 
                return IsSetField(Tags.TimeStampPreference);
            }
            public class NoMsgTypesGroup : Group
            {
                public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, 0};
            
                public NoMsgTypesGroup() 
                  :base( Tags.NoMsgTypes, Tags.RefMsgType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMsgTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RefMsgType RefMsgType
                { 
                    get 
                    {
                        QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefMsgType val) 
                { 
                    this.RefMsgType = val;
                }
                
                public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefMsgType val) 
                { 
                    return IsSetRefMsgType();
                }
                
                public bool IsSetRefMsgType() 
                { 
                    return IsSetField(Tags.RefMsgType);
                }
                public QuickFix.Fields.MsgDirection MsgDirection
                { 
                    get 
                    {
                        QuickFix.Fields.MsgDirection val = new QuickFix.Fields.MsgDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MsgDirection val) 
                { 
                    this.MsgDirection = val;
                }
                
                public QuickFix.Fields.MsgDirection Get(QuickFix.Fields.MsgDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MsgDirection val) 
                { 
                    return IsSetMsgDirection();
                }
                
                public bool IsSetMsgDirection() 
                { 
                    return IsSetField(Tags.MsgDirection);
                }
            
            }
        }
    }
}
