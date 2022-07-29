// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class DerivativeSecurityListRequest : Message
        {
            public const string MsgType = "z";

            public DerivativeSecurityListRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("z"));
            }

            public DerivativeSecurityListRequest(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityListRequestType aSecurityListRequestType
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
                this.SecurityListRequestType = aSecurityListRequestType;
            }

            public QuickFix.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.SecurityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.SecurityListRequestType SecurityListRequestType
            { 
                get 
                {
                    QuickFix.Fields.SecurityListRequestType val = new QuickFix.Fields.SecurityListRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListRequestType val) 
            { 
                this.SecurityListRequestType = val;
            }
            
            public QuickFix.Fields.SecurityListRequestType Get(QuickFix.Fields.SecurityListRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListRequestType val) 
            { 
                return IsSetSecurityListRequestType();
            }
            
            public bool IsSetSecurityListRequestType() 
            { 
                return IsSetField(Tags.SecurityListRequestType);
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
            public QuickFix.Fields.Currency Currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Currency val) 
            { 
                this.Currency = val;
            }
            
            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(Tags.Currency);
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
            public QuickFix.Fields.TradingSessionID TradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.TradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.TradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return IsSetTradingSessionSubID();
            }
            
            public bool IsSetTradingSessionSubID() 
            { 
                return IsSetField(Tags.TradingSessionSubID);
            }
            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.SubscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return IsSetSubscriptionRequestType();
            }
            
            public bool IsSetSubscriptionRequestType() 
            { 
                return IsSetField(Tags.SubscriptionRequestType);
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
    }
}
