// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class CrossOrderCancelRequest : Message
        {
            public const string MsgType = "u";

            public CrossOrderCancelRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("u"));
            }

            public CrossOrderCancelRequest(
                    QuickFix.Fields.CrossID aCrossID,
                    QuickFix.Fields.OrigCrossID aOrigCrossID,
                    QuickFix.Fields.CrossType aCrossType,
                    QuickFix.Fields.CrossPrioritization aCrossPrioritization,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.CrossID = aCrossID;
                this.OrigCrossID = aOrigCrossID;
                this.CrossType = aCrossType;
                this.CrossPrioritization = aCrossPrioritization;
                this.Symbol = aSymbol;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Tags.OrderID);
            }
            public QuickFix.Fields.CrossID CrossID
            { 
                get 
                {
                    QuickFix.Fields.CrossID val = new QuickFix.Fields.CrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossID val) 
            { 
                this.CrossID = val;
            }
            
            public QuickFix.Fields.CrossID Get(QuickFix.Fields.CrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossID val) 
            { 
                return IsSetCrossID();
            }
            
            public bool IsSetCrossID() 
            { 
                return IsSetField(Tags.CrossID);
            }
            public QuickFix.Fields.OrigCrossID OrigCrossID
            { 
                get 
                {
                    QuickFix.Fields.OrigCrossID val = new QuickFix.Fields.OrigCrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigCrossID val) 
            { 
                this.OrigCrossID = val;
            }
            
            public QuickFix.Fields.OrigCrossID Get(QuickFix.Fields.OrigCrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigCrossID val) 
            { 
                return IsSetOrigCrossID();
            }
            
            public bool IsSetOrigCrossID() 
            { 
                return IsSetField(Tags.OrigCrossID);
            }
            public QuickFix.Fields.CrossType CrossType
            { 
                get 
                {
                    QuickFix.Fields.CrossType val = new QuickFix.Fields.CrossType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossType val) 
            { 
                this.CrossType = val;
            }
            
            public QuickFix.Fields.CrossType Get(QuickFix.Fields.CrossType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossType val) 
            { 
                return IsSetCrossType();
            }
            
            public bool IsSetCrossType() 
            { 
                return IsSetField(Tags.CrossType);
            }
            public QuickFix.Fields.CrossPrioritization CrossPrioritization
            { 
                get 
                {
                    QuickFix.Fields.CrossPrioritization val = new QuickFix.Fields.CrossPrioritization();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossPrioritization val) 
            { 
                this.CrossPrioritization = val;
            }
            
            public QuickFix.Fields.CrossPrioritization Get(QuickFix.Fields.CrossPrioritization val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossPrioritization val) 
            { 
                return IsSetCrossPrioritization();
            }
            
            public bool IsSetCrossPrioritization() 
            { 
                return IsSetField(Tags.CrossPrioritization);
            }
            public QuickFix.Fields.NoSides NoSides
            { 
                get 
                {
                    QuickFix.Fields.NoSides val = new QuickFix.Fields.NoSides();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSides val) 
            { 
                this.NoSides = val;
            }
            
            public QuickFix.Fields.NoSides Get(QuickFix.Fields.NoSides val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSides val) 
            { 
                return IsSetNoSides();
            }
            
            public bool IsSetNoSides() 
            { 
                return IsSetField(Tags.NoSides);
            }
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.SymbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID SecurityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.NoSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product Product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                this.Product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode CFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                this.CFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.SecuritySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.MaturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                this.MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.CouponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate IssueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                this.IssueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.RepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.RepurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.RepurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor Factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                this.Factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating CreditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                this.CreditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.InstrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.CountryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.LocaleOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.RedemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                this.StrikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.OptionsSymbol OptionsSymbol
            { 
                get 
                {
                    QuickFix.Fields.OptionsSymbol val = new QuickFix.Fields.OptionsSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptionsSymbol val) 
            { 
                this.OptionsSymbol = val;
            }
            
            public QuickFix.Fields.OptionsSymbol Get(QuickFix.Fields.OptionsSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptionsSymbol val) 
            { 
                return IsSetOptionsSymbol();
            }
            
            public bool IsSetOptionsSymbol() 
            { 
                return IsSetField(Tags.OptionsSymbol);
            }
            public QuickFix.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.StrikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(Tags.StrikeCurrency);
            }
            public QuickFix.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptAttribute val) 
            { 
                this.OptAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.ContractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate CouponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponRate val) 
            { 
                this.CouponRate = val;
            }
            
            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.SecurityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer Issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Issuer val) 
            { 
                this.Issuer = val;
            }
            
            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.EncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.EncodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.EncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.EncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool Pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                this.Pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.ContractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram CPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                this.CPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType CPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                this.CPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents NoEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                this.NoEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate DatedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                this.DatedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.InterestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyings val) 
            { 
                this.NoUnderlyings = val;
            }
            
            public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(Tags.NoUnderlyings);
            }
            public QuickFix.Fields.NoLegs NoLegs
            { 
                get 
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLegs val) 
            { 
                this.NoLegs = val;
            }
            
            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(Tags.NoLegs);
            }
            public QuickFix.Fields.TransactTime TransactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.TransactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public class NoSidesGroup : Group
            {
                public static int[] fieldOrder = {Tags.Side, Tags.OrigClOrdID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ClOrdLinkID, Tags.OrigOrdModTime, Tags.NoPartyIDs, Tags.TradeOriginationDate, Tags.TradeDate, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.ComplianceID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
            
                public NoSidesGroup() 
                  :base( Tags.NoSides, Tags.Side, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSidesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.Side Side
                { 
                    get 
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Side val) 
                { 
                    this.Side = val;
                }
                
                public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(Tags.Side);
                }
                public QuickFix.Fields.OrigClOrdID OrigClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrigClOrdID val) 
                { 
                    this.OrigClOrdID = val;
                }
                
                public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrigClOrdID val) 
                { 
                    return IsSetOrigClOrdID();
                }
                
                public bool IsSetOrigClOrdID() 
                { 
                    return IsSetField(Tags.OrigClOrdID);
                }
                public QuickFix.Fields.ClOrdID ClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.ClOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return IsSetClOrdID();
                }
                
                public bool IsSetClOrdID() 
                { 
                    return IsSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.SecondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return IsSetSecondaryClOrdID();
                }
                
                public bool IsSetSecondaryClOrdID() 
                { 
                    return IsSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdLinkID val = new QuickFix.Fields.ClOrdLinkID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    this.ClOrdLinkID = val;
                }
                
                public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    return IsSetClOrdLinkID();
                }
                
                public bool IsSetClOrdLinkID() 
                { 
                    return IsSetField(Tags.ClOrdLinkID);
                }
                public QuickFix.Fields.OrigOrdModTime OrigOrdModTime
                { 
                    get 
                    {
                        QuickFix.Fields.OrigOrdModTime val = new QuickFix.Fields.OrigOrdModTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrigOrdModTime val) 
                { 
                    this.OrigOrdModTime = val;
                }
                
                public QuickFix.Fields.OrigOrdModTime Get(QuickFix.Fields.OrigOrdModTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrigOrdModTime val) 
                { 
                    return IsSetOrigOrdModTime();
                }
                
                public bool IsSetOrigOrdModTime() 
                { 
                    return IsSetField(Tags.OrigOrdModTime);
                }
                public QuickFix.Fields.NoPartyIDs NoPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartyIDs val) 
                { 
                    this.NoPartyIDs = val;
                }
                
                public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
                { 
                    return IsSetNoPartyIDs();
                }
                
                public bool IsSetNoPartyIDs() 
                { 
                    return IsSetField(Tags.NoPartyIDs);
                }
                public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
                { 
                    get 
                    {
                        QuickFix.Fields.TradeOriginationDate val = new QuickFix.Fields.TradeOriginationDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    this.TradeOriginationDate = val;
                }
                
                public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    return IsSetTradeOriginationDate();
                }
                
                public bool IsSetTradeOriginationDate() 
                { 
                    return IsSetField(Tags.TradeOriginationDate);
                }
                public QuickFix.Fields.TradeDate TradeDate
                { 
                    get 
                    {
                        QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeDate val) 
                { 
                    this.TradeDate = val;
                }
                
                public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradeDate val) 
                { 
                    return IsSetTradeDate();
                }
                
                public bool IsSetTradeDate() 
                { 
                    return IsSetField(Tags.TradeDate);
                }
                public QuickFix.Fields.OrderQty OrderQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty val) 
                { 
                    this.OrderQty = val;
                }
                
                public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty val) 
                { 
                    return IsSetOrderQty();
                }
                
                public bool IsSetOrderQty() 
                { 
                    return IsSetField(Tags.OrderQty);
                }
                public QuickFix.Fields.CashOrderQty CashOrderQty
                { 
                    get 
                    {
                        QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashOrderQty val) 
                { 
                    this.CashOrderQty = val;
                }
                
                public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashOrderQty val) 
                { 
                    return IsSetCashOrderQty();
                }
                
                public bool IsSetCashOrderQty() 
                { 
                    return IsSetField(Tags.CashOrderQty);
                }
                public QuickFix.Fields.OrderPercent OrderPercent
                { 
                    get 
                    {
                        QuickFix.Fields.OrderPercent val = new QuickFix.Fields.OrderPercent();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderPercent val) 
                { 
                    this.OrderPercent = val;
                }
                
                public QuickFix.Fields.OrderPercent Get(QuickFix.Fields.OrderPercent val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderPercent val) 
                { 
                    return IsSetOrderPercent();
                }
                
                public bool IsSetOrderPercent() 
                { 
                    return IsSetField(Tags.OrderPercent);
                }
                public QuickFix.Fields.RoundingDirection RoundingDirection
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingDirection val = new QuickFix.Fields.RoundingDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundingDirection val) 
                { 
                    this.RoundingDirection = val;
                }
                
                public QuickFix.Fields.RoundingDirection Get(QuickFix.Fields.RoundingDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundingDirection val) 
                { 
                    return IsSetRoundingDirection();
                }
                
                public bool IsSetRoundingDirection() 
                { 
                    return IsSetField(Tags.RoundingDirection);
                }
                public QuickFix.Fields.RoundingModulus RoundingModulus
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingModulus val = new QuickFix.Fields.RoundingModulus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundingModulus val) 
                { 
                    this.RoundingModulus = val;
                }
                
                public QuickFix.Fields.RoundingModulus Get(QuickFix.Fields.RoundingModulus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundingModulus val) 
                { 
                    return IsSetRoundingModulus();
                }
                
                public bool IsSetRoundingModulus() 
                { 
                    return IsSetField(Tags.RoundingModulus);
                }
                public QuickFix.Fields.ComplianceID ComplianceID
                { 
                    get 
                    {
                        QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplianceID val) 
                { 
                    this.ComplianceID = val;
                }
                
                public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplianceID val) 
                { 
                    return IsSetComplianceID();
                }
                
                public bool IsSetComplianceID() 
                { 
                    return IsSetField(Tags.ComplianceID);
                }
                public QuickFix.Fields.Text Text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Text val) 
                { 
                    this.Text = val;
                }
                
                public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Text val) 
                { 
                    return IsSetText();
                }
                
                public bool IsSetText() 
                { 
                    return IsSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen EncodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.EncodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return IsSetEncodedTextLen();
                }
                
                public bool IsSetEncodedTextLen() 
                { 
                    return IsSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText EncodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedText val) 
                { 
                    this.EncodedText = val;
                }
                
                public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedText val) 
                { 
                    return IsSetEncodedText();
                }
                
                public bool IsSetEncodedText() 
                { 
                    return IsSetField(Tags.EncodedText);
                }
                            public class NoPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                
                    public NoPartyIDsGroup() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.PartyID PartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyID val) 
                    { 
                        this.PartyID = val;
                    }
                    
                    public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyID val) 
                    { 
                        return IsSetPartyID();
                    }
                    
                    public bool IsSetPartyID() 
                    { 
                        return IsSetField(Tags.PartyID);
                    }
                    public QuickFix.Fields.PartyIDSource PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyIDSource val) 
                    { 
                        this.PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                    { 
                        return IsSetPartyIDSource();
                    }
                    
                    public bool IsSetPartyIDSource() 
                    { 
                        return IsSetField(Tags.PartyIDSource);
                    }
                    public QuickFix.Fields.PartyRole PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyRole val) 
                    { 
                        this.PartyRole = val;
                    }
                    
                    public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyRole val) 
                    { 
                        return IsSetPartyRole();
                    }
                    
                    public bool IsSetPartyRole() 
                    { 
                        return IsSetField(Tags.PartyRole);
                    }
                    public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        this.NoPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        return IsSetNoPartySubIDs();
                    }
                    
                    public bool IsSetNoPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoPartySubIDs);
                    }
                                    public class NoPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                    
                        public NoPartySubIDsGroup() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.PartySubID PartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartySubID val) 
                        { 
                            this.PartySubID = val;
                        }
                        
                        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartySubID val) 
                        { 
                            return IsSetPartySubID();
                        }
                        
                        public bool IsSetPartySubID() 
                        { 
                            return IsSetField(Tags.PartySubID);
                        }
                        public QuickFix.Fields.PartySubIDType PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartySubIDType val) 
                        { 
                            this.PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                        { 
                            return IsSetPartySubIDType();
                        }
                        
                        public bool IsSetPartySubIDType() 
                        { 
                            return IsSetField(Tags.PartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.SecurityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.SecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};
            
                public NoEventsGroup() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.EventType EventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    this.EventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate EventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    this.EventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx EventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    this.EventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText EventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    this.EventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(Tags.EventText);
                }
            
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.StartDate, Tags.EndDate, Tags.ImpliedType, Tags.PrimaryLegSymbol, Tags.SecondaryLegSymbol, Tags.ClearedAlias, Tags.Denominator, Tags.InitialMargin, Tags.LotMultiplier, Tags.ProductType, Tags.BaseNumLots, Tags.NumBlocks, Tags.TickValue, Tags.ProductId, Tags.ProductName, Tags.ProductDescription, Tags.NumOfDecimalPrice, Tags.NumOfDecimalQty, Tags.Granularity, Tags.PriceDenomination, Tags.PriceUnit, Tags.HubId, Tags.HubName, Tags.HubAlias, Tags.StripType, Tags.StripId, Tags.StripName, Tags.IncrementPrice, Tags.IncrementQty, Tags.LotSize, Tags.UnderlyingUnitOfMeasure, Tags.NumOfCycles, Tags.LotSizeMultiplier, Tags.Clearable, Tags.OffExchangeIncrementPrice, Tags.OffExchangeIncrementQty, Tags.PhysicalCode, Tags.MiFIDRegulatedMarket, Tags.AONAllowed, Tags.UnderlyingAccruedPremiumAmt, Tags.UnderlyingEventPaymentAmt, Tags.UnderlyingAlignmentInterestRate, Tags.UnderlyingRepurchaseDate, Tags.UnderlyingInterpolationFactor, Tags.HedgeProductID, Tags.HedgeMarketID, Tags.BlockOnly, Tags.FlexAllowed, Tags.HedgeOnly, Tags.GTAllowed, Tags.TestMarketIndicator, Tags.UDSAllowed, Tags.UnderlyingSettlMethod, Tags.SecurityTradingStatus, Tags.LegacyTickValue, Tags.ScreenTickValue, Tags.BlockTickValue, Tags.OverrideBlockMin, Tags.NoBlockDetails, 0};
            
                public NoUnderlyingsGroup() 
                  :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    this.UnderlyingSymbol = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(Tags.UnderlyingSymbol);
                }
                public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    this.UnderlyingSymbolSfx = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    return IsSetUnderlyingSymbolSfx();
                }
                
                public bool IsSetUnderlyingSymbolSfx() 
                { 
                    return IsSetField(Tags.UnderlyingSymbolSfx);
                }
                public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    this.UnderlyingSecurityID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityID);
                }
                public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    this.UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityIDSource);
                }
                public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    this.NoUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return IsSetNoUnderlyingSecurityAltID();
                }
                
                public bool IsSetNoUnderlyingSecurityAltID() 
                { 
                    return IsSetField(Tags.NoUnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    this.UnderlyingProduct = val;
                }
                
                public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    return IsSetUnderlyingProduct();
                }
                
                public bool IsSetUnderlyingProduct() 
                { 
                    return IsSetField(Tags.UnderlyingProduct);
                }
                public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    this.UnderlyingCFICode = val;
                }
                
                public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(Tags.UnderlyingCFICode);
                }
                public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    this.UnderlyingSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    return IsSetUnderlyingSecurityType();
                }
                
                public bool IsSetUnderlyingSecurityType() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityType);
                }
                public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    this.UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(Tags.UnderlyingSecuritySubType);
                }
                public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    this.UnderlyingMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return IsSetUnderlyingMaturityMonthYear();
                }
                
                public bool IsSetUnderlyingMaturityMonthYear() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityMonthYear);
                }
                public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    this.UnderlyingMaturityDate = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityDate);
                }
                public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    this.UnderlyingCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return IsSetUnderlyingCouponPaymentDate();
                }
                
                public bool IsSetUnderlyingCouponPaymentDate() 
                { 
                    return IsSetField(Tags.UnderlyingCouponPaymentDate);
                }
                public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    this.UnderlyingIssueDate = val;
                }
                
                public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(Tags.UnderlyingIssueDate);
                }
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    this.UnderlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool IsSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
                }
                public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    this.UnderlyingRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return IsSetUnderlyingRepurchaseTerm();
                }
                
                public bool IsSetUnderlyingRepurchaseTerm() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseTerm);
                }
                public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    this.UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseRate);
                }
                public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    this.UnderlyingFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(Tags.UnderlyingFactor);
                }
                public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    this.UnderlyingCreditRating = val;
                }
                
                public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(Tags.UnderlyingCreditRating);
                }
                public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    this.UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(Tags.UnderlyingInstrRegistry);
                }
                public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    this.UnderlyingCountryOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return IsSetUnderlyingCountryOfIssue();
                }
                
                public bool IsSetUnderlyingCountryOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingCountryOfIssue);
                }
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    this.UnderlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    this.UnderlyingLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return IsSetUnderlyingLocaleOfIssue();
                }
                
                public bool IsSetUnderlyingLocaleOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingLocaleOfIssue);
                }
                public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    this.UnderlyingRedemptionDate = val;
                }
                
                public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    return IsSetUnderlyingRedemptionDate();
                }
                
                public bool IsSetUnderlyingRedemptionDate() 
                { 
                    return IsSetField(Tags.UnderlyingRedemptionDate);
                }
                public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    this.UnderlyingStrikePrice = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(Tags.UnderlyingStrikePrice);
                }
                public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    this.UnderlyingStrikeCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return IsSetUnderlyingStrikeCurrency();
                }
                
                public bool IsSetUnderlyingStrikeCurrency() 
                { 
                    return IsSetField(Tags.UnderlyingStrikeCurrency);
                }
                public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    this.UnderlyingOptAttribute = val;
                }
                
                public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    return IsSetUnderlyingOptAttribute();
                }
                
                public bool IsSetUnderlyingOptAttribute() 
                { 
                    return IsSetField(Tags.UnderlyingOptAttribute);
                }
                public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    this.UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(Tags.UnderlyingContractMultiplier);
                }
                public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    this.UnderlyingCouponRate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(Tags.UnderlyingCouponRate);
                }
                public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    this.UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityExchange);
                }
                public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    this.UnderlyingIssuer = val;
                }
                
                public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    return IsSetUnderlyingIssuer();
                }
                
                public bool IsSetUnderlyingIssuer() 
                { 
                    return IsSetField(Tags.UnderlyingIssuer);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    this.EncodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return IsSetEncodedUnderlyingIssuerLen();
                }
                
                public bool IsSetEncodedUnderlyingIssuerLen() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingIssuerLen);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    this.EncodedUnderlyingIssuer = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return IsSetEncodedUnderlyingIssuer();
                }
                
                public bool IsSetEncodedUnderlyingIssuer() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingIssuer);
                }
                public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    this.UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityDesc);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    this.EncodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    this.EncodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDesc() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
                }
                public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    this.UnderlyingCPProgram = val;
                }
                
                public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    return IsSetUnderlyingCPProgram();
                }
                
                public bool IsSetUnderlyingCPProgram() 
                { 
                    return IsSetField(Tags.UnderlyingCPProgram);
                }
                public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    this.UnderlyingCPRegType = val;
                }
                
                public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    return IsSetUnderlyingCPRegType();
                }
                
                public bool IsSetUnderlyingCPRegType() 
                { 
                    return IsSetField(Tags.UnderlyingCPRegType);
                }
                public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    this.UnderlyingCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(Tags.UnderlyingCurrency);
                }
                public QuickFix.Fields.UnderlyingQty UnderlyingQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingQty val) 
                { 
                    this.UnderlyingQty = val;
                }
                
                public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
                { 
                    return IsSetUnderlyingQty();
                }
                
                public bool IsSetUnderlyingQty() 
                { 
                    return IsSetField(Tags.UnderlyingQty);
                }
                public QuickFix.Fields.UnderlyingPx UnderlyingPx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPx val) 
                { 
                    this.UnderlyingPx = val;
                }
                
                public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
                { 
                    return IsSetUnderlyingPx();
                }
                
                public bool IsSetUnderlyingPx() 
                { 
                    return IsSetField(Tags.UnderlyingPx);
                }
                public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    this.UnderlyingDirtyPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    return IsSetUnderlyingDirtyPrice();
                }
                
                public bool IsSetUnderlyingDirtyPrice() 
                { 
                    return IsSetField(Tags.UnderlyingDirtyPrice);
                }
                public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    this.UnderlyingEndPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    return IsSetUnderlyingEndPrice();
                }
                
                public bool IsSetUnderlyingEndPrice() 
                { 
                    return IsSetField(Tags.UnderlyingEndPrice);
                }
                public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    this.UnderlyingStartValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    return IsSetUnderlyingStartValue();
                }
                
                public bool IsSetUnderlyingStartValue() 
                { 
                    return IsSetField(Tags.UnderlyingStartValue);
                }
                public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    this.UnderlyingCurrentValue = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    return IsSetUnderlyingCurrentValue();
                }
                
                public bool IsSetUnderlyingCurrentValue() 
                { 
                    return IsSetField(Tags.UnderlyingCurrentValue);
                }
                public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    this.UnderlyingEndValue = val;
                }
                
                public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    return IsSetUnderlyingEndValue();
                }
                
                public bool IsSetUnderlyingEndValue() 
                { 
                    return IsSetField(Tags.UnderlyingEndValue);
                }
                public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    this.NoUnderlyingStips = val;
                }
                
                public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    return IsSetNoUnderlyingStips();
                }
                
                public bool IsSetNoUnderlyingStips() 
                { 
                    return IsSetField(Tags.NoUnderlyingStips);
                }
                public QuickFix.Fields.StartDate StartDate
                { 
                    get 
                    {
                        QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StartDate val) 
                { 
                    this.StartDate = val;
                }
                
                public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StartDate val) 
                { 
                    return IsSetStartDate();
                }
                
                public bool IsSetStartDate() 
                { 
                    return IsSetField(Tags.StartDate);
                }
                public QuickFix.Fields.EndDate EndDate
                { 
                    get 
                    {
                        QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EndDate val) 
                { 
                    this.EndDate = val;
                }
                
                public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EndDate val) 
                { 
                    return IsSetEndDate();
                }
                
                public bool IsSetEndDate() 
                { 
                    return IsSetField(Tags.EndDate);
                }
                public QuickFix.Fields.ImpliedType ImpliedType
                { 
                    get 
                    {
                        QuickFix.Fields.ImpliedType val = new QuickFix.Fields.ImpliedType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ImpliedType val) 
                { 
                    this.ImpliedType = val;
                }
                
                public QuickFix.Fields.ImpliedType Get(QuickFix.Fields.ImpliedType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ImpliedType val) 
                { 
                    return IsSetImpliedType();
                }
                
                public bool IsSetImpliedType() 
                { 
                    return IsSetField(Tags.ImpliedType);
                }
                public QuickFix.Fields.PrimaryLegSymbol PrimaryLegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.PrimaryLegSymbol val = new QuickFix.Fields.PrimaryLegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    this.PrimaryLegSymbol = val;
                }
                
                public QuickFix.Fields.PrimaryLegSymbol Get(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    return IsSetPrimaryLegSymbol();
                }
                
                public bool IsSetPrimaryLegSymbol() 
                { 
                    return IsSetField(Tags.PrimaryLegSymbol);
                }
                public QuickFix.Fields.SecondaryLegSymbol SecondaryLegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryLegSymbol val = new QuickFix.Fields.SecondaryLegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    this.SecondaryLegSymbol = val;
                }
                
                public QuickFix.Fields.SecondaryLegSymbol Get(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    return IsSetSecondaryLegSymbol();
                }
                
                public bool IsSetSecondaryLegSymbol() 
                { 
                    return IsSetField(Tags.SecondaryLegSymbol);
                }
                public QuickFix.Fields.ClearedAlias ClearedAlias
                { 
                    get 
                    {
                        QuickFix.Fields.ClearedAlias val = new QuickFix.Fields.ClearedAlias();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClearedAlias val) 
                { 
                    this.ClearedAlias = val;
                }
                
                public QuickFix.Fields.ClearedAlias Get(QuickFix.Fields.ClearedAlias val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClearedAlias val) 
                { 
                    return IsSetClearedAlias();
                }
                
                public bool IsSetClearedAlias() 
                { 
                    return IsSetField(Tags.ClearedAlias);
                }
                public QuickFix.Fields.Denominator Denominator
                { 
                    get 
                    {
                        QuickFix.Fields.Denominator val = new QuickFix.Fields.Denominator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Denominator val) 
                { 
                    this.Denominator = val;
                }
                
                public QuickFix.Fields.Denominator Get(QuickFix.Fields.Denominator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Denominator val) 
                { 
                    return IsSetDenominator();
                }
                
                public bool IsSetDenominator() 
                { 
                    return IsSetField(Tags.Denominator);
                }
                public QuickFix.Fields.InitialMargin InitialMargin
                { 
                    get 
                    {
                        QuickFix.Fields.InitialMargin val = new QuickFix.Fields.InitialMargin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InitialMargin val) 
                { 
                    this.InitialMargin = val;
                }
                
                public QuickFix.Fields.InitialMargin Get(QuickFix.Fields.InitialMargin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InitialMargin val) 
                { 
                    return IsSetInitialMargin();
                }
                
                public bool IsSetInitialMargin() 
                { 
                    return IsSetField(Tags.InitialMargin);
                }
                public QuickFix.Fields.LotMultiplier LotMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LotMultiplier val = new QuickFix.Fields.LotMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotMultiplier val) 
                { 
                    this.LotMultiplier = val;
                }
                
                public QuickFix.Fields.LotMultiplier Get(QuickFix.Fields.LotMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotMultiplier val) 
                { 
                    return IsSetLotMultiplier();
                }
                
                public bool IsSetLotMultiplier() 
                { 
                    return IsSetField(Tags.LotMultiplier);
                }
                public QuickFix.Fields.ProductType ProductType
                { 
                    get 
                    {
                        QuickFix.Fields.ProductType val = new QuickFix.Fields.ProductType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductType val) 
                { 
                    this.ProductType = val;
                }
                
                public QuickFix.Fields.ProductType Get(QuickFix.Fields.ProductType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductType val) 
                { 
                    return IsSetProductType();
                }
                
                public bool IsSetProductType() 
                { 
                    return IsSetField(Tags.ProductType);
                }
                public QuickFix.Fields.BaseNumLots BaseNumLots
                { 
                    get 
                    {
                        QuickFix.Fields.BaseNumLots val = new QuickFix.Fields.BaseNumLots();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BaseNumLots val) 
                { 
                    this.BaseNumLots = val;
                }
                
                public QuickFix.Fields.BaseNumLots Get(QuickFix.Fields.BaseNumLots val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BaseNumLots val) 
                { 
                    return IsSetBaseNumLots();
                }
                
                public bool IsSetBaseNumLots() 
                { 
                    return IsSetField(Tags.BaseNumLots);
                }
                public QuickFix.Fields.NumBlocks NumBlocks
                { 
                    get 
                    {
                        QuickFix.Fields.NumBlocks val = new QuickFix.Fields.NumBlocks();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumBlocks val) 
                { 
                    this.NumBlocks = val;
                }
                
                public QuickFix.Fields.NumBlocks Get(QuickFix.Fields.NumBlocks val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumBlocks val) 
                { 
                    return IsSetNumBlocks();
                }
                
                public bool IsSetNumBlocks() 
                { 
                    return IsSetField(Tags.NumBlocks);
                }
                public QuickFix.Fields.TickValue TickValue
                { 
                    get 
                    {
                        QuickFix.Fields.TickValue val = new QuickFix.Fields.TickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickValue val) 
                { 
                    this.TickValue = val;
                }
                
                public QuickFix.Fields.TickValue Get(QuickFix.Fields.TickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickValue val) 
                { 
                    return IsSetTickValue();
                }
                
                public bool IsSetTickValue() 
                { 
                    return IsSetField(Tags.TickValue);
                }
                public QuickFix.Fields.ProductId ProductId
                { 
                    get 
                    {
                        QuickFix.Fields.ProductId val = new QuickFix.Fields.ProductId();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductId val) 
                { 
                    this.ProductId = val;
                }
                
                public QuickFix.Fields.ProductId Get(QuickFix.Fields.ProductId val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductId val) 
                { 
                    return IsSetProductId();
                }
                
                public bool IsSetProductId() 
                { 
                    return IsSetField(Tags.ProductId);
                }
                public QuickFix.Fields.ProductName ProductName
                { 
                    get 
                    {
                        QuickFix.Fields.ProductName val = new QuickFix.Fields.ProductName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductName val) 
                { 
                    this.ProductName = val;
                }
                
                public QuickFix.Fields.ProductName Get(QuickFix.Fields.ProductName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductName val) 
                { 
                    return IsSetProductName();
                }
                
                public bool IsSetProductName() 
                { 
                    return IsSetField(Tags.ProductName);
                }
                public QuickFix.Fields.ProductDescription ProductDescription
                { 
                    get 
                    {
                        QuickFix.Fields.ProductDescription val = new QuickFix.Fields.ProductDescription();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductDescription val) 
                { 
                    this.ProductDescription = val;
                }
                
                public QuickFix.Fields.ProductDescription Get(QuickFix.Fields.ProductDescription val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductDescription val) 
                { 
                    return IsSetProductDescription();
                }
                
                public bool IsSetProductDescription() 
                { 
                    return IsSetField(Tags.ProductDescription);
                }
                public QuickFix.Fields.NumOfDecimalPrice NumOfDecimalPrice
                { 
                    get 
                    {
                        QuickFix.Fields.NumOfDecimalPrice val = new QuickFix.Fields.NumOfDecimalPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumOfDecimalPrice val) 
                { 
                    this.NumOfDecimalPrice = val;
                }
                
                public QuickFix.Fields.NumOfDecimalPrice Get(QuickFix.Fields.NumOfDecimalPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumOfDecimalPrice val) 
                { 
                    return IsSetNumOfDecimalPrice();
                }
                
                public bool IsSetNumOfDecimalPrice() 
                { 
                    return IsSetField(Tags.NumOfDecimalPrice);
                }
                public QuickFix.Fields.NumOfDecimalQty NumOfDecimalQty
                { 
                    get 
                    {
                        QuickFix.Fields.NumOfDecimalQty val = new QuickFix.Fields.NumOfDecimalQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumOfDecimalQty val) 
                { 
                    this.NumOfDecimalQty = val;
                }
                
                public QuickFix.Fields.NumOfDecimalQty Get(QuickFix.Fields.NumOfDecimalQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumOfDecimalQty val) 
                { 
                    return IsSetNumOfDecimalQty();
                }
                
                public bool IsSetNumOfDecimalQty() 
                { 
                    return IsSetField(Tags.NumOfDecimalQty);
                }
                public QuickFix.Fields.Granularity Granularity
                { 
                    get 
                    {
                        QuickFix.Fields.Granularity val = new QuickFix.Fields.Granularity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Granularity val) 
                { 
                    this.Granularity = val;
                }
                
                public QuickFix.Fields.Granularity Get(QuickFix.Fields.Granularity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Granularity val) 
                { 
                    return IsSetGranularity();
                }
                
                public bool IsSetGranularity() 
                { 
                    return IsSetField(Tags.Granularity);
                }
                public QuickFix.Fields.PriceDenomination PriceDenomination
                { 
                    get 
                    {
                        QuickFix.Fields.PriceDenomination val = new QuickFix.Fields.PriceDenomination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceDenomination val) 
                { 
                    this.PriceDenomination = val;
                }
                
                public QuickFix.Fields.PriceDenomination Get(QuickFix.Fields.PriceDenomination val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceDenomination val) 
                { 
                    return IsSetPriceDenomination();
                }
                
                public bool IsSetPriceDenomination() 
                { 
                    return IsSetField(Tags.PriceDenomination);
                }
                public QuickFix.Fields.PriceUnit PriceUnit
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnit val = new QuickFix.Fields.PriceUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceUnit val) 
                { 
                    this.PriceUnit = val;
                }
                
                public QuickFix.Fields.PriceUnit Get(QuickFix.Fields.PriceUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceUnit val) 
                { 
                    return IsSetPriceUnit();
                }
                
                public bool IsSetPriceUnit() 
                { 
                    return IsSetField(Tags.PriceUnit);
                }
                public QuickFix.Fields.HubId HubId
                { 
                    get 
                    {
                        QuickFix.Fields.HubId val = new QuickFix.Fields.HubId();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HubId val) 
                { 
                    this.HubId = val;
                }
                
                public QuickFix.Fields.HubId Get(QuickFix.Fields.HubId val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HubId val) 
                { 
                    return IsSetHubId();
                }
                
                public bool IsSetHubId() 
                { 
                    return IsSetField(Tags.HubId);
                }
                public QuickFix.Fields.HubName HubName
                { 
                    get 
                    {
                        QuickFix.Fields.HubName val = new QuickFix.Fields.HubName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HubName val) 
                { 
                    this.HubName = val;
                }
                
                public QuickFix.Fields.HubName Get(QuickFix.Fields.HubName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HubName val) 
                { 
                    return IsSetHubName();
                }
                
                public bool IsSetHubName() 
                { 
                    return IsSetField(Tags.HubName);
                }
                public QuickFix.Fields.HubAlias HubAlias
                { 
                    get 
                    {
                        QuickFix.Fields.HubAlias val = new QuickFix.Fields.HubAlias();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HubAlias val) 
                { 
                    this.HubAlias = val;
                }
                
                public QuickFix.Fields.HubAlias Get(QuickFix.Fields.HubAlias val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HubAlias val) 
                { 
                    return IsSetHubAlias();
                }
                
                public bool IsSetHubAlias() 
                { 
                    return IsSetField(Tags.HubAlias);
                }
                public QuickFix.Fields.StripType StripType
                { 
                    get 
                    {
                        QuickFix.Fields.StripType val = new QuickFix.Fields.StripType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StripType val) 
                { 
                    this.StripType = val;
                }
                
                public QuickFix.Fields.StripType Get(QuickFix.Fields.StripType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StripType val) 
                { 
                    return IsSetStripType();
                }
                
                public bool IsSetStripType() 
                { 
                    return IsSetField(Tags.StripType);
                }
                public QuickFix.Fields.StripId StripId
                { 
                    get 
                    {
                        QuickFix.Fields.StripId val = new QuickFix.Fields.StripId();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StripId val) 
                { 
                    this.StripId = val;
                }
                
                public QuickFix.Fields.StripId Get(QuickFix.Fields.StripId val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StripId val) 
                { 
                    return IsSetStripId();
                }
                
                public bool IsSetStripId() 
                { 
                    return IsSetField(Tags.StripId);
                }
                public QuickFix.Fields.StripName StripName
                { 
                    get 
                    {
                        QuickFix.Fields.StripName val = new QuickFix.Fields.StripName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StripName val) 
                { 
                    this.StripName = val;
                }
                
                public QuickFix.Fields.StripName Get(QuickFix.Fields.StripName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StripName val) 
                { 
                    return IsSetStripName();
                }
                
                public bool IsSetStripName() 
                { 
                    return IsSetField(Tags.StripName);
                }
                public QuickFix.Fields.IncrementPrice IncrementPrice
                { 
                    get 
                    {
                        QuickFix.Fields.IncrementPrice val = new QuickFix.Fields.IncrementPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IncrementPrice val) 
                { 
                    this.IncrementPrice = val;
                }
                
                public QuickFix.Fields.IncrementPrice Get(QuickFix.Fields.IncrementPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IncrementPrice val) 
                { 
                    return IsSetIncrementPrice();
                }
                
                public bool IsSetIncrementPrice() 
                { 
                    return IsSetField(Tags.IncrementPrice);
                }
                public QuickFix.Fields.IncrementQty IncrementQty
                { 
                    get 
                    {
                        QuickFix.Fields.IncrementQty val = new QuickFix.Fields.IncrementQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IncrementQty val) 
                { 
                    this.IncrementQty = val;
                }
                
                public QuickFix.Fields.IncrementQty Get(QuickFix.Fields.IncrementQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IncrementQty val) 
                { 
                    return IsSetIncrementQty();
                }
                
                public bool IsSetIncrementQty() 
                { 
                    return IsSetField(Tags.IncrementQty);
                }
                public QuickFix.Fields.LotSize LotSize
                { 
                    get 
                    {
                        QuickFix.Fields.LotSize val = new QuickFix.Fields.LotSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotSize val) 
                { 
                    this.LotSize = val;
                }
                
                public QuickFix.Fields.LotSize Get(QuickFix.Fields.LotSize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotSize val) 
                { 
                    return IsSetLotSize();
                }
                
                public bool IsSetLotSize() 
                { 
                    return IsSetField(Tags.LotSize);
                }
                public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    this.UnderlyingUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    return IsSetUnderlyingUnitOfMeasure();
                }
                
                public bool IsSetUnderlyingUnitOfMeasure() 
                { 
                    return IsSetField(Tags.UnderlyingUnitOfMeasure);
                }
                public QuickFix.Fields.NumOfCycles NumOfCycles
                { 
                    get 
                    {
                        QuickFix.Fields.NumOfCycles val = new QuickFix.Fields.NumOfCycles();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumOfCycles val) 
                { 
                    this.NumOfCycles = val;
                }
                
                public QuickFix.Fields.NumOfCycles Get(QuickFix.Fields.NumOfCycles val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumOfCycles val) 
                { 
                    return IsSetNumOfCycles();
                }
                
                public bool IsSetNumOfCycles() 
                { 
                    return IsSetField(Tags.NumOfCycles);
                }
                public QuickFix.Fields.LotSizeMultiplier LotSizeMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LotSizeMultiplier val = new QuickFix.Fields.LotSizeMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotSizeMultiplier val) 
                { 
                    this.LotSizeMultiplier = val;
                }
                
                public QuickFix.Fields.LotSizeMultiplier Get(QuickFix.Fields.LotSizeMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotSizeMultiplier val) 
                { 
                    return IsSetLotSizeMultiplier();
                }
                
                public bool IsSetLotSizeMultiplier() 
                { 
                    return IsSetField(Tags.LotSizeMultiplier);
                }
                public QuickFix.Fields.Clearable Clearable
                { 
                    get 
                    {
                        QuickFix.Fields.Clearable val = new QuickFix.Fields.Clearable();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Clearable val) 
                { 
                    this.Clearable = val;
                }
                
                public QuickFix.Fields.Clearable Get(QuickFix.Fields.Clearable val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Clearable val) 
                { 
                    return IsSetClearable();
                }
                
                public bool IsSetClearable() 
                { 
                    return IsSetField(Tags.Clearable);
                }
                public QuickFix.Fields.OffExchangeIncrementPrice OffExchangeIncrementPrice
                { 
                    get 
                    {
                        QuickFix.Fields.OffExchangeIncrementPrice val = new QuickFix.Fields.OffExchangeIncrementPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OffExchangeIncrementPrice val) 
                { 
                    this.OffExchangeIncrementPrice = val;
                }
                
                public QuickFix.Fields.OffExchangeIncrementPrice Get(QuickFix.Fields.OffExchangeIncrementPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OffExchangeIncrementPrice val) 
                { 
                    return IsSetOffExchangeIncrementPrice();
                }
                
                public bool IsSetOffExchangeIncrementPrice() 
                { 
                    return IsSetField(Tags.OffExchangeIncrementPrice);
                }
                public QuickFix.Fields.OffExchangeIncrementQty OffExchangeIncrementQty
                { 
                    get 
                    {
                        QuickFix.Fields.OffExchangeIncrementQty val = new QuickFix.Fields.OffExchangeIncrementQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OffExchangeIncrementQty val) 
                { 
                    this.OffExchangeIncrementQty = val;
                }
                
                public QuickFix.Fields.OffExchangeIncrementQty Get(QuickFix.Fields.OffExchangeIncrementQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OffExchangeIncrementQty val) 
                { 
                    return IsSetOffExchangeIncrementQty();
                }
                
                public bool IsSetOffExchangeIncrementQty() 
                { 
                    return IsSetField(Tags.OffExchangeIncrementQty);
                }
                public QuickFix.Fields.PhysicalCode PhysicalCode
                { 
                    get 
                    {
                        QuickFix.Fields.PhysicalCode val = new QuickFix.Fields.PhysicalCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PhysicalCode val) 
                { 
                    this.PhysicalCode = val;
                }
                
                public QuickFix.Fields.PhysicalCode Get(QuickFix.Fields.PhysicalCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PhysicalCode val) 
                { 
                    return IsSetPhysicalCode();
                }
                
                public bool IsSetPhysicalCode() 
                { 
                    return IsSetField(Tags.PhysicalCode);
                }
                public QuickFix.Fields.MiFIDRegulatedMarket MiFIDRegulatedMarket
                { 
                    get 
                    {
                        QuickFix.Fields.MiFIDRegulatedMarket val = new QuickFix.Fields.MiFIDRegulatedMarket();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MiFIDRegulatedMarket val) 
                { 
                    this.MiFIDRegulatedMarket = val;
                }
                
                public QuickFix.Fields.MiFIDRegulatedMarket Get(QuickFix.Fields.MiFIDRegulatedMarket val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MiFIDRegulatedMarket val) 
                { 
                    return IsSetMiFIDRegulatedMarket();
                }
                
                public bool IsSetMiFIDRegulatedMarket() 
                { 
                    return IsSetField(Tags.MiFIDRegulatedMarket);
                }
                public QuickFix.Fields.AONAllowed AONAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.AONAllowed val = new QuickFix.Fields.AONAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AONAllowed val) 
                { 
                    this.AONAllowed = val;
                }
                
                public QuickFix.Fields.AONAllowed Get(QuickFix.Fields.AONAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AONAllowed val) 
                { 
                    return IsSetAONAllowed();
                }
                
                public bool IsSetAONAllowed() 
                { 
                    return IsSetField(Tags.AONAllowed);
                }
                public QuickFix.Fields.UnderlyingAccruedPremiumAmt UnderlyingAccruedPremiumAmt
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAccruedPremiumAmt val = new QuickFix.Fields.UnderlyingAccruedPremiumAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    this.UnderlyingAccruedPremiumAmt = val;
                }
                
                public QuickFix.Fields.UnderlyingAccruedPremiumAmt Get(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    return IsSetUnderlyingAccruedPremiumAmt();
                }
                
                public bool IsSetUnderlyingAccruedPremiumAmt() 
                { 
                    return IsSetField(Tags.UnderlyingAccruedPremiumAmt);
                }
                public QuickFix.Fields.UnderlyingEventPaymentAmt UnderlyingEventPaymentAmt
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEventPaymentAmt val = new QuickFix.Fields.UnderlyingEventPaymentAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    this.UnderlyingEventPaymentAmt = val;
                }
                
                public QuickFix.Fields.UnderlyingEventPaymentAmt Get(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    return IsSetUnderlyingEventPaymentAmt();
                }
                
                public bool IsSetUnderlyingEventPaymentAmt() 
                { 
                    return IsSetField(Tags.UnderlyingEventPaymentAmt);
                }
                public QuickFix.Fields.UnderlyingAlignmentInterestRate UnderlyingAlignmentInterestRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAlignmentInterestRate val = new QuickFix.Fields.UnderlyingAlignmentInterestRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    this.UnderlyingAlignmentInterestRate = val;
                }
                
                public QuickFix.Fields.UnderlyingAlignmentInterestRate Get(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    return IsSetUnderlyingAlignmentInterestRate();
                }
                
                public bool IsSetUnderlyingAlignmentInterestRate() 
                { 
                    return IsSetField(Tags.UnderlyingAlignmentInterestRate);
                }
                public QuickFix.Fields.UnderlyingRepurchaseDate UnderlyingRepurchaseDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseDate val = new QuickFix.Fields.UnderlyingRepurchaseDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    this.UnderlyingRepurchaseDate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseDate Get(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    return IsSetUnderlyingRepurchaseDate();
                }
                
                public bool IsSetUnderlyingRepurchaseDate() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseDate);
                }
                public QuickFix.Fields.UnderlyingInterpolationFactor UnderlyingInterpolationFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInterpolationFactor val = new QuickFix.Fields.UnderlyingInterpolationFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    this.UnderlyingInterpolationFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingInterpolationFactor Get(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    return IsSetUnderlyingInterpolationFactor();
                }
                
                public bool IsSetUnderlyingInterpolationFactor() 
                { 
                    return IsSetField(Tags.UnderlyingInterpolationFactor);
                }
                public QuickFix.Fields.HedgeProductID HedgeProductID
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeProductID val = new QuickFix.Fields.HedgeProductID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeProductID val) 
                { 
                    this.HedgeProductID = val;
                }
                
                public QuickFix.Fields.HedgeProductID Get(QuickFix.Fields.HedgeProductID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeProductID val) 
                { 
                    return IsSetHedgeProductID();
                }
                
                public bool IsSetHedgeProductID() 
                { 
                    return IsSetField(Tags.HedgeProductID);
                }
                public QuickFix.Fields.HedgeMarketID HedgeMarketID
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeMarketID val = new QuickFix.Fields.HedgeMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeMarketID val) 
                { 
                    this.HedgeMarketID = val;
                }
                
                public QuickFix.Fields.HedgeMarketID Get(QuickFix.Fields.HedgeMarketID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeMarketID val) 
                { 
                    return IsSetHedgeMarketID();
                }
                
                public bool IsSetHedgeMarketID() 
                { 
                    return IsSetField(Tags.HedgeMarketID);
                }
                public QuickFix.Fields.BlockOnly BlockOnly
                { 
                    get 
                    {
                        QuickFix.Fields.BlockOnly val = new QuickFix.Fields.BlockOnly();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BlockOnly val) 
                { 
                    this.BlockOnly = val;
                }
                
                public QuickFix.Fields.BlockOnly Get(QuickFix.Fields.BlockOnly val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BlockOnly val) 
                { 
                    return IsSetBlockOnly();
                }
                
                public bool IsSetBlockOnly() 
                { 
                    return IsSetField(Tags.BlockOnly);
                }
                public QuickFix.Fields.FlexAllowed FlexAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.FlexAllowed val = new QuickFix.Fields.FlexAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FlexAllowed val) 
                { 
                    this.FlexAllowed = val;
                }
                
                public QuickFix.Fields.FlexAllowed Get(QuickFix.Fields.FlexAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FlexAllowed val) 
                { 
                    return IsSetFlexAllowed();
                }
                
                public bool IsSetFlexAllowed() 
                { 
                    return IsSetField(Tags.FlexAllowed);
                }
                public QuickFix.Fields.HedgeOnly HedgeOnly
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeOnly val = new QuickFix.Fields.HedgeOnly();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeOnly val) 
                { 
                    this.HedgeOnly = val;
                }
                
                public QuickFix.Fields.HedgeOnly Get(QuickFix.Fields.HedgeOnly val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeOnly val) 
                { 
                    return IsSetHedgeOnly();
                }
                
                public bool IsSetHedgeOnly() 
                { 
                    return IsSetField(Tags.HedgeOnly);
                }
                public QuickFix.Fields.GTAllowed GTAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.GTAllowed val = new QuickFix.Fields.GTAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.GTAllowed val) 
                { 
                    this.GTAllowed = val;
                }
                
                public QuickFix.Fields.GTAllowed Get(QuickFix.Fields.GTAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.GTAllowed val) 
                { 
                    return IsSetGTAllowed();
                }
                
                public bool IsSetGTAllowed() 
                { 
                    return IsSetField(Tags.GTAllowed);
                }
                public QuickFix.Fields.TestMarketIndicator TestMarketIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.TestMarketIndicator val = new QuickFix.Fields.TestMarketIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TestMarketIndicator val) 
                { 
                    this.TestMarketIndicator = val;
                }
                
                public QuickFix.Fields.TestMarketIndicator Get(QuickFix.Fields.TestMarketIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TestMarketIndicator val) 
                { 
                    return IsSetTestMarketIndicator();
                }
                
                public bool IsSetTestMarketIndicator() 
                { 
                    return IsSetField(Tags.TestMarketIndicator);
                }
                public QuickFix.Fields.UDSAllowed UDSAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.UDSAllowed val = new QuickFix.Fields.UDSAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UDSAllowed val) 
                { 
                    this.UDSAllowed = val;
                }
                
                public QuickFix.Fields.UDSAllowed Get(QuickFix.Fields.UDSAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UDSAllowed val) 
                { 
                    return IsSetUDSAllowed();
                }
                
                public bool IsSetUDSAllowed() 
                { 
                    return IsSetField(Tags.UDSAllowed);
                }
                public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    this.UnderlyingSettlMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    return IsSetUnderlyingSettlMethod();
                }
                
                public bool IsSetUnderlyingSettlMethod() 
                { 
                    return IsSetField(Tags.UnderlyingSettlMethod);
                }
                public QuickFix.Fields.SecurityTradingStatus SecurityTradingStatus
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityTradingStatus val = new QuickFix.Fields.SecurityTradingStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityTradingStatus val) 
                { 
                    this.SecurityTradingStatus = val;
                }
                
                public QuickFix.Fields.SecurityTradingStatus Get(QuickFix.Fields.SecurityTradingStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityTradingStatus val) 
                { 
                    return IsSetSecurityTradingStatus();
                }
                
                public bool IsSetSecurityTradingStatus() 
                { 
                    return IsSetField(Tags.SecurityTradingStatus);
                }
                public QuickFix.Fields.LegacyTickValue LegacyTickValue
                { 
                    get 
                    {
                        QuickFix.Fields.LegacyTickValue val = new QuickFix.Fields.LegacyTickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegacyTickValue val) 
                { 
                    this.LegacyTickValue = val;
                }
                
                public QuickFix.Fields.LegacyTickValue Get(QuickFix.Fields.LegacyTickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegacyTickValue val) 
                { 
                    return IsSetLegacyTickValue();
                }
                
                public bool IsSetLegacyTickValue() 
                { 
                    return IsSetField(Tags.LegacyTickValue);
                }
                public QuickFix.Fields.ScreenTickValue ScreenTickValue
                { 
                    get 
                    {
                        QuickFix.Fields.ScreenTickValue val = new QuickFix.Fields.ScreenTickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ScreenTickValue val) 
                { 
                    this.ScreenTickValue = val;
                }
                
                public QuickFix.Fields.ScreenTickValue Get(QuickFix.Fields.ScreenTickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ScreenTickValue val) 
                { 
                    return IsSetScreenTickValue();
                }
                
                public bool IsSetScreenTickValue() 
                { 
                    return IsSetField(Tags.ScreenTickValue);
                }
                public QuickFix.Fields.BlockTickValue BlockTickValue
                { 
                    get 
                    {
                        QuickFix.Fields.BlockTickValue val = new QuickFix.Fields.BlockTickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BlockTickValue val) 
                { 
                    this.BlockTickValue = val;
                }
                
                public QuickFix.Fields.BlockTickValue Get(QuickFix.Fields.BlockTickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BlockTickValue val) 
                { 
                    return IsSetBlockTickValue();
                }
                
                public bool IsSetBlockTickValue() 
                { 
                    return IsSetField(Tags.BlockTickValue);
                }
                public QuickFix.Fields.OverrideBlockMin OverrideBlockMin
                { 
                    get 
                    {
                        QuickFix.Fields.OverrideBlockMin val = new QuickFix.Fields.OverrideBlockMin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OverrideBlockMin val) 
                { 
                    this.OverrideBlockMin = val;
                }
                
                public QuickFix.Fields.OverrideBlockMin Get(QuickFix.Fields.OverrideBlockMin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OverrideBlockMin val) 
                { 
                    return IsSetOverrideBlockMin();
                }
                
                public bool IsSetOverrideBlockMin() 
                { 
                    return IsSetField(Tags.OverrideBlockMin);
                }
                public QuickFix.Fields.NoBlockDetails NoBlockDetails
                { 
                    get 
                    {
                        QuickFix.Fields.NoBlockDetails val = new QuickFix.Fields.NoBlockDetails();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoBlockDetails val) 
                { 
                    this.NoBlockDetails = val;
                }
                
                public QuickFix.Fields.NoBlockDetails Get(QuickFix.Fields.NoBlockDetails val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoBlockDetails val) 
                { 
                    return IsSetNoBlockDetails();
                }
                
                public bool IsSetNoBlockDetails() 
                { 
                    return IsSetField(Tags.NoBlockDetails);
                }
                            public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                
                    public NoUnderlyingSecurityAltIDGroup() 
                      :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        this.UnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return IsSetUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        this.UnderlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltIDSource() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                    }
                
                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                
                    public NoUnderlyingStipsGroup() 
                      :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        this.UnderlyingStipType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        return IsSetUnderlyingStipType();
                    }
                    
                    public bool IsSetUnderlyingStipType() 
                    { 
                        return IsSetField(Tags.UnderlyingStipType);
                    }
                    public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        this.UnderlyingStipValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        return IsSetUnderlyingStipValue();
                    }
                    
                    public bool IsSetUnderlyingStipValue() 
                    { 
                        return IsSetField(Tags.UnderlyingStipValue);
                    }
                
                }
                public class NoBlockDetailsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.BlockDetailsBlockType, Tags.BlockDetailsTradeType, Tags.BlockDetailsMinQty, 0};
                
                    public NoBlockDetailsGroup() 
                      :base( Tags.NoBlockDetails, Tags.BlockDetailsBlockType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoBlockDetailsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.BlockDetailsBlockType BlockDetailsBlockType
                    { 
                        get 
                        {
                            QuickFix.Fields.BlockDetailsBlockType val = new QuickFix.Fields.BlockDetailsBlockType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BlockDetailsBlockType val) 
                    { 
                        this.BlockDetailsBlockType = val;
                    }
                    
                    public QuickFix.Fields.BlockDetailsBlockType Get(QuickFix.Fields.BlockDetailsBlockType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BlockDetailsBlockType val) 
                    { 
                        return IsSetBlockDetailsBlockType();
                    }
                    
                    public bool IsSetBlockDetailsBlockType() 
                    { 
                        return IsSetField(Tags.BlockDetailsBlockType);
                    }
                    public QuickFix.Fields.BlockDetailsTradeType BlockDetailsTradeType
                    { 
                        get 
                        {
                            QuickFix.Fields.BlockDetailsTradeType val = new QuickFix.Fields.BlockDetailsTradeType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BlockDetailsTradeType val) 
                    { 
                        this.BlockDetailsTradeType = val;
                    }
                    
                    public QuickFix.Fields.BlockDetailsTradeType Get(QuickFix.Fields.BlockDetailsTradeType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BlockDetailsTradeType val) 
                    { 
                        return IsSetBlockDetailsTradeType();
                    }
                    
                    public bool IsSetBlockDetailsTradeType() 
                    { 
                        return IsSetField(Tags.BlockDetailsTradeType);
                    }
                    public QuickFix.Fields.BlockDetailsMinQty BlockDetailsMinQty
                    { 
                        get 
                        {
                            QuickFix.Fields.BlockDetailsMinQty val = new QuickFix.Fields.BlockDetailsMinQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BlockDetailsMinQty val) 
                    { 
                        this.BlockDetailsMinQty = val;
                    }
                    
                    public QuickFix.Fields.BlockDetailsMinQty Get(QuickFix.Fields.BlockDetailsMinQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BlockDetailsMinQty val) 
                    { 
                        return IsSetBlockDetailsMinQty();
                    }
                    
                    public bool IsSetBlockDetailsMinQty() 
                    { 
                        return IsSetField(Tags.BlockDetailsMinQty);
                    }
                
                }
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, 0};
            
                public NoLegsGroup() 
                  :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbol val) 
                { 
                    this.LegSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(Tags.LegSymbol);
                }
                public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    this.LegSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(Tags.LegSymbolSfx);
                }
                public QuickFix.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityID val) 
                { 
                    this.LegSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(Tags.LegSecurityID);
                }
                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    this.LegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(Tags.LegSecurityIDSource);
                }
                public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    this.NoLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(Tags.NoLegSecurityAltID);
                }
                public QuickFix.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegProduct val) 
                { 
                    this.LegProduct = val;
                }
                
                public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(Tags.LegProduct);
                }
                public QuickFix.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCFICode val) 
                { 
                    this.LegCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(Tags.LegCFICode);
                }
                public QuickFix.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityType val) 
                { 
                    this.LegSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(Tags.LegSecurityType);
                }
                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    this.LegSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(Tags.LegSecuritySubType);
                }
                public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    this.LegMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(Tags.LegMaturityMonthYear);
                }
                public QuickFix.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    this.LegMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(Tags.LegMaturityDate);
                }
                public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    this.LegCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(Tags.LegCouponPaymentDate);
                }
                public QuickFix.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssueDate val) 
                { 
                    this.LegIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(Tags.LegIssueDate);
                }
                public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    this.LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(Tags.LegRepoCollateralSecurityType);
                }
                public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    this.LegRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(Tags.LegRepurchaseTerm);
                }
                public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    this.LegRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(Tags.LegRepurchaseRate);
                }
                public QuickFix.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegFactor val) 
                { 
                    this.LegFactor = val;
                }
                
                public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(Tags.LegFactor);
                }
                public QuickFix.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCreditRating val) 
                { 
                    this.LegCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(Tags.LegCreditRating);
                }
                public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    this.LegInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(Tags.LegInstrRegistry);
                }
                public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    this.LegCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(Tags.LegCountryOfIssue);
                }
                public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    this.LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(Tags.LegStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    this.LegLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(Tags.LegLocaleOfIssue);
                }
                public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    this.LegRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(Tags.LegRedemptionDate);
                }
                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    this.LegStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(Tags.LegStrikePrice);
                }
                public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    this.LegStrikeCurrency = val;
                }
                
                public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(Tags.LegStrikeCurrency);
                }
                public QuickFix.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    this.LegOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(Tags.LegOptAttribute);
                }
                public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    this.LegContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(Tags.LegContractMultiplier);
                }
                public QuickFix.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponRate val) 
                { 
                    this.LegCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(Tags.LegCouponRate);
                }
                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    this.LegSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(Tags.LegSecurityExchange);
                }
                public QuickFix.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssuer val) 
                { 
                    this.LegIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(Tags.LegIssuer);
                }
                public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    this.EncodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(Tags.EncodedLegIssuerLen);
                }
                public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    this.EncodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(Tags.EncodedLegIssuer);
                }
                public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    this.LegSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(Tags.LegSecurityDesc);
                }
                public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    this.EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(Tags.EncodedLegSecurityDescLen);
                }
                public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    this.EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(Tags.EncodedLegSecurityDesc);
                }
                public QuickFix.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQty val) 
                { 
                    this.LegRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(Tags.LegRatioQty);
                }
                public QuickFix.Fields.LegSide LegSide
                { 
                    get 
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSide val) 
                { 
                    this.LegSide = val;
                }
                
                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(Tags.LegSide);
                }
                public QuickFix.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCurrency val) 
                { 
                    this.LegCurrency = val;
                }
                
                public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(Tags.LegCurrency);
                }
                public QuickFix.Fields.LegPool LegPool
                { 
                    get 
                    {
                        QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPool val) 
                { 
                    this.LegPool = val;
                }
                
                public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(Tags.LegPool);
                }
                public QuickFix.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegDatedDate val) 
                { 
                    this.LegDatedDate = val;
                }
                
                public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(Tags.LegDatedDate);
                }
                public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    this.LegContractSettlMonth = val;
                }
                
                public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(Tags.LegContractSettlMonth);
                }
                public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    this.LegInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(Tags.LegInterestAccrualDate);
                }
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        this.LegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(Tags.LegSecurityAltID);
                    }
                    public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        this.LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(Tags.LegSecurityAltIDSource);
                    }
                
                }
            }
        }
    }
}
