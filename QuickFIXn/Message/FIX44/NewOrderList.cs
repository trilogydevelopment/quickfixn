// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class NewOrderList : Message
        {
            public const string MsgType = "E";

            public NewOrderList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("E"));
            }

            public NewOrderList(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.ListID = aListID;
                this.BidType = aBidType;
                this.TotNoOrders = aTotNoOrders;
            }

            public QuickFix.Fields.ListID ListID
            { 
                get 
                {
                    QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListID val) 
            { 
                this.ListID = val;
            }
            
            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(Tags.ListID);
            }
            public QuickFix.Fields.BidID BidID
            { 
                get 
                {
                    QuickFix.Fields.BidID val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidID val) 
            { 
                this.BidID = val;
            }
            
            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(Tags.BidID);
            }
            public QuickFix.Fields.ClientBidID ClientBidID
            { 
                get 
                {
                    QuickFix.Fields.ClientBidID val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientBidID val) 
            { 
                this.ClientBidID = val;
            }
            
            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(Tags.ClientBidID);
            }
            public QuickFix.Fields.ProgRptReqs ProgRptReqs
            { 
                get 
                {
                    QuickFix.Fields.ProgRptReqs val = new QuickFix.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgRptReqs val) 
            { 
                this.ProgRptReqs = val;
            }
            
            public QuickFix.Fields.ProgRptReqs Get(QuickFix.Fields.ProgRptReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgRptReqs val) 
            { 
                return IsSetProgRptReqs();
            }
            
            public bool IsSetProgRptReqs() 
            { 
                return IsSetField(Tags.ProgRptReqs);
            }
            public QuickFix.Fields.BidType BidType
            { 
                get 
                {
                    QuickFix.Fields.BidType val = new QuickFix.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidType val) 
            { 
                this.BidType = val;
            }
            
            public QuickFix.Fields.BidType Get(QuickFix.Fields.BidType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidType val) 
            { 
                return IsSetBidType();
            }
            
            public bool IsSetBidType() 
            { 
                return IsSetField(Tags.BidType);
            }
            public QuickFix.Fields.ProgPeriodInterval ProgPeriodInterval
            { 
                get 
                {
                    QuickFix.Fields.ProgPeriodInterval val = new QuickFix.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                this.ProgPeriodInterval = val;
            }
            
            public QuickFix.Fields.ProgPeriodInterval Get(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                return IsSetProgPeriodInterval();
            }
            
            public bool IsSetProgPeriodInterval() 
            { 
                return IsSetField(Tags.ProgPeriodInterval);
            }
            public QuickFix.Fields.CancellationRights CancellationRights
            { 
                get 
                {
                    QuickFix.Fields.CancellationRights val = new QuickFix.Fields.CancellationRights();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CancellationRights val) 
            { 
                this.CancellationRights = val;
            }
            
            public QuickFix.Fields.CancellationRights Get(QuickFix.Fields.CancellationRights val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CancellationRights val) 
            { 
                return IsSetCancellationRights();
            }
            
            public bool IsSetCancellationRights() 
            { 
                return IsSetField(Tags.CancellationRights);
            }
            public QuickFix.Fields.MoneyLaunderingStatus MoneyLaunderingStatus
            { 
                get 
                {
                    QuickFix.Fields.MoneyLaunderingStatus val = new QuickFix.Fields.MoneyLaunderingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                this.MoneyLaunderingStatus = val;
            }
            
            public QuickFix.Fields.MoneyLaunderingStatus Get(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                return IsSetMoneyLaunderingStatus();
            }
            
            public bool IsSetMoneyLaunderingStatus() 
            { 
                return IsSetField(Tags.MoneyLaunderingStatus);
            }
            public QuickFix.Fields.RegistID RegistID
            { 
                get 
                {
                    QuickFix.Fields.RegistID val = new QuickFix.Fields.RegistID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistID val) 
            { 
                this.RegistID = val;
            }
            
            public QuickFix.Fields.RegistID Get(QuickFix.Fields.RegistID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistID val) 
            { 
                return IsSetRegistID();
            }
            
            public bool IsSetRegistID() 
            { 
                return IsSetField(Tags.RegistID);
            }
            public QuickFix.Fields.ListExecInstType ListExecInstType
            { 
                get 
                {
                    QuickFix.Fields.ListExecInstType val = new QuickFix.Fields.ListExecInstType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListExecInstType val) 
            { 
                this.ListExecInstType = val;
            }
            
            public QuickFix.Fields.ListExecInstType Get(QuickFix.Fields.ListExecInstType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListExecInstType val) 
            { 
                return IsSetListExecInstType();
            }
            
            public bool IsSetListExecInstType() 
            { 
                return IsSetField(Tags.ListExecInstType);
            }
            public QuickFix.Fields.ListExecInst ListExecInst
            { 
                get 
                {
                    QuickFix.Fields.ListExecInst val = new QuickFix.Fields.ListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListExecInst val) 
            { 
                this.ListExecInst = val;
            }
            
            public QuickFix.Fields.ListExecInst Get(QuickFix.Fields.ListExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListExecInst val) 
            { 
                return IsSetListExecInst();
            }
            
            public bool IsSetListExecInst() 
            { 
                return IsSetField(Tags.ListExecInst);
            }
            public QuickFix.Fields.EncodedListExecInstLen EncodedListExecInstLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedListExecInstLen val = new QuickFix.Fields.EncodedListExecInstLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                this.EncodedListExecInstLen = val;
            }
            
            public QuickFix.Fields.EncodedListExecInstLen Get(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                return IsSetEncodedListExecInstLen();
            }
            
            public bool IsSetEncodedListExecInstLen() 
            { 
                return IsSetField(Tags.EncodedListExecInstLen);
            }
            public QuickFix.Fields.EncodedListExecInst EncodedListExecInst
            { 
                get 
                {
                    QuickFix.Fields.EncodedListExecInst val = new QuickFix.Fields.EncodedListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListExecInst val) 
            { 
                this.EncodedListExecInst = val;
            }
            
            public QuickFix.Fields.EncodedListExecInst Get(QuickFix.Fields.EncodedListExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListExecInst val) 
            { 
                return IsSetEncodedListExecInst();
            }
            
            public bool IsSetEncodedListExecInst() 
            { 
                return IsSetField(Tags.EncodedListExecInst);
            }
            public QuickFix.Fields.AllowableOneSidednessPct AllowableOneSidednessPct
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessPct val = new QuickFix.Fields.AllowableOneSidednessPct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                this.AllowableOneSidednessPct = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessPct Get(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                return IsSetAllowableOneSidednessPct();
            }
            
            public bool IsSetAllowableOneSidednessPct() 
            { 
                return IsSetField(Tags.AllowableOneSidednessPct);
            }
            public QuickFix.Fields.AllowableOneSidednessValue AllowableOneSidednessValue
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessValue val = new QuickFix.Fields.AllowableOneSidednessValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                this.AllowableOneSidednessValue = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessValue Get(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                return IsSetAllowableOneSidednessValue();
            }
            
            public bool IsSetAllowableOneSidednessValue() 
            { 
                return IsSetField(Tags.AllowableOneSidednessValue);
            }
            public QuickFix.Fields.AllowableOneSidednessCurr AllowableOneSidednessCurr
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessCurr val = new QuickFix.Fields.AllowableOneSidednessCurr();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                this.AllowableOneSidednessCurr = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessCurr Get(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                return IsSetAllowableOneSidednessCurr();
            }
            
            public bool IsSetAllowableOneSidednessCurr() 
            { 
                return IsSetField(Tags.AllowableOneSidednessCurr);
            }
            public QuickFix.Fields.TotNoOrders TotNoOrders
            { 
                get 
                {
                    QuickFix.Fields.TotNoOrders val = new QuickFix.Fields.TotNoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoOrders val) 
            { 
                this.TotNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders Get(QuickFix.Fields.TotNoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return IsSetTotNoOrders();
            }
            
            public bool IsSetTotNoOrders() 
            { 
                return IsSetField(Tags.TotNoOrders);
            }
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                this.LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoOrders NoOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrders val) 
            { 
                this.NoOrders = val;
            }
            
            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(Tags.NoOrders);
            }
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListSeqNo, Tags.ClOrdLinkID, Tags.SettlInstMode, Tags.NoPartyIDs, Tags.TradeOriginationDate, Tags.TradeDate, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.DayBookingInst, Tags.BookingUnit, Tags.AllocID, Tags.PreallocMethod, Tags.NoAllocs, Tags.SettlType, Tags.SettlDate, Tags.CashMargin, Tags.ClearingFeeIndicator, Tags.HandlInst, Tags.ExecInst, Tags.MinQty, Tags.MaxFloor, Tags.ExDestination, Tags.NoTradingSessions, Tags.ProcessCode, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptionsSymbol, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoUnderlyings, Tags.PrevClosePx, Tags.Side, Tags.SideValueInd, Tags.LocateReqd, Tags.TransactTime, Tags.NoStipulations, Tags.QtyType, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.OrdType, Tags.PriceType, Tags.Price, Tags.StopPx, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.BenchmarkPrice, Tags.BenchmarkPriceType, Tags.BenchmarkSecurityID, Tags.BenchmarkSecurityIDSource, Tags.YieldType, Tags.Yield, Tags.YieldCalcDate, Tags.YieldRedemptionDate, Tags.YieldRedemptionPrice, Tags.YieldRedemptionPriceType, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.IOIid, Tags.QuoteID, Tags.TimeInForce, Tags.EffectiveTime, Tags.ExpireDate, Tags.ExpireTime, Tags.GTBookingInst, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.ForexReq, Tags.SettlCurrency, Tags.BookingType, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SettlDate2, Tags.OrderQty2, Tags.Price2, Tags.PositionEffect, Tags.CoveredOrUncovered, Tags.MaxShow, Tags.PegOffsetValue, Tags.PegMoveType, Tags.PegOffsetType, Tags.PegLimitType, Tags.PegRoundDirection, Tags.PegScope, Tags.DiscretionInst, Tags.DiscretionOffsetValue, Tags.DiscretionMoveType, Tags.DiscretionOffsetType, Tags.DiscretionLimitType, Tags.DiscretionRoundDirection, Tags.DiscretionScope, Tags.TargetStrategy, Tags.TargetStrategyParameters, Tags.ParticipationRate, Tags.Designation, 0};
            
                public NoOrdersGroup() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                public QuickFix.Fields.ListSeqNo ListSeqNo
                { 
                    get 
                    {
                        QuickFix.Fields.ListSeqNo val = new QuickFix.Fields.ListSeqNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListSeqNo val) 
                { 
                    this.ListSeqNo = val;
                }
                
                public QuickFix.Fields.ListSeqNo Get(QuickFix.Fields.ListSeqNo val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListSeqNo val) 
                { 
                    return IsSetListSeqNo();
                }
                
                public bool IsSetListSeqNo() 
                { 
                    return IsSetField(Tags.ListSeqNo);
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
                public QuickFix.Fields.SettlInstMode SettlInstMode
                { 
                    get 
                    {
                        QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlInstMode val) 
                { 
                    this.SettlInstMode = val;
                }
                
                public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlInstMode val) 
                { 
                    return IsSetSettlInstMode();
                }
                
                public bool IsSetSettlInstMode() 
                { 
                    return IsSetField(Tags.SettlInstMode);
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
                public QuickFix.Fields.Account Account
                { 
                    get 
                    {
                        QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Account val) 
                { 
                    this.Account = val;
                }
                
                public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Account val) 
                { 
                    return IsSetAccount();
                }
                
                public bool IsSetAccount() 
                { 
                    return IsSetField(Tags.Account);
                }
                public QuickFix.Fields.AcctIDSource AcctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AcctIDSource val) 
                { 
                    this.AcctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(Tags.AcctIDSource);
                }
                public QuickFix.Fields.AccountType AccountType
                { 
                    get 
                    {
                        QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AccountType val) 
                { 
                    this.AccountType = val;
                }
                
                public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AccountType val) 
                { 
                    return IsSetAccountType();
                }
                
                public bool IsSetAccountType() 
                { 
                    return IsSetField(Tags.AccountType);
                }
                public QuickFix.Fields.DayBookingInst DayBookingInst
                { 
                    get 
                    {
                        QuickFix.Fields.DayBookingInst val = new QuickFix.Fields.DayBookingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DayBookingInst val) 
                { 
                    this.DayBookingInst = val;
                }
                
                public QuickFix.Fields.DayBookingInst Get(QuickFix.Fields.DayBookingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DayBookingInst val) 
                { 
                    return IsSetDayBookingInst();
                }
                
                public bool IsSetDayBookingInst() 
                { 
                    return IsSetField(Tags.DayBookingInst);
                }
                public QuickFix.Fields.BookingUnit BookingUnit
                { 
                    get 
                    {
                        QuickFix.Fields.BookingUnit val = new QuickFix.Fields.BookingUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BookingUnit val) 
                { 
                    this.BookingUnit = val;
                }
                
                public QuickFix.Fields.BookingUnit Get(QuickFix.Fields.BookingUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BookingUnit val) 
                { 
                    return IsSetBookingUnit();
                }
                
                public bool IsSetBookingUnit() 
                { 
                    return IsSetField(Tags.BookingUnit);
                }
                public QuickFix.Fields.AllocID AllocID
                { 
                    get 
                    {
                        QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocID val) 
                { 
                    this.AllocID = val;
                }
                
                public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocID val) 
                { 
                    return IsSetAllocID();
                }
                
                public bool IsSetAllocID() 
                { 
                    return IsSetField(Tags.AllocID);
                }
                public QuickFix.Fields.PreallocMethod PreallocMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PreallocMethod val = new QuickFix.Fields.PreallocMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PreallocMethod val) 
                { 
                    this.PreallocMethod = val;
                }
                
                public QuickFix.Fields.PreallocMethod Get(QuickFix.Fields.PreallocMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PreallocMethod val) 
                { 
                    return IsSetPreallocMethod();
                }
                
                public bool IsSetPreallocMethod() 
                { 
                    return IsSetField(Tags.PreallocMethod);
                }
                public QuickFix.Fields.NoAllocs NoAllocs
                { 
                    get 
                    {
                        QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoAllocs val) 
                { 
                    this.NoAllocs = val;
                }
                
                public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoAllocs val) 
                { 
                    return IsSetNoAllocs();
                }
                
                public bool IsSetNoAllocs() 
                { 
                    return IsSetField(Tags.NoAllocs);
                }
                public QuickFix.Fields.SettlType SettlType
                { 
                    get 
                    {
                        QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlType val) 
                { 
                    this.SettlType = val;
                }
                
                public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlType val) 
                { 
                    return IsSetSettlType();
                }
                
                public bool IsSetSettlType() 
                { 
                    return IsSetField(Tags.SettlType);
                }
                public QuickFix.Fields.SettlDate SettlDate
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlDate val) 
                { 
                    this.SettlDate = val;
                }
                
                public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlDate val) 
                { 
                    return IsSetSettlDate();
                }
                
                public bool IsSetSettlDate() 
                { 
                    return IsSetField(Tags.SettlDate);
                }
                public QuickFix.Fields.CashMargin CashMargin
                { 
                    get 
                    {
                        QuickFix.Fields.CashMargin val = new QuickFix.Fields.CashMargin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashMargin val) 
                { 
                    this.CashMargin = val;
                }
                
                public QuickFix.Fields.CashMargin Get(QuickFix.Fields.CashMargin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashMargin val) 
                { 
                    return IsSetCashMargin();
                }
                
                public bool IsSetCashMargin() 
                { 
                    return IsSetField(Tags.CashMargin);
                }
                public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.ClearingFeeIndicator val = new QuickFix.Fields.ClearingFeeIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    this.ClearingFeeIndicator = val;
                }
                
                public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    return IsSetClearingFeeIndicator();
                }
                
                public bool IsSetClearingFeeIndicator() 
                { 
                    return IsSetField(Tags.ClearingFeeIndicator);
                }
                public QuickFix.Fields.HandlInst HandlInst
                { 
                    get 
                    {
                        QuickFix.Fields.HandlInst val = new QuickFix.Fields.HandlInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HandlInst val) 
                { 
                    this.HandlInst = val;
                }
                
                public QuickFix.Fields.HandlInst Get(QuickFix.Fields.HandlInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HandlInst val) 
                { 
                    return IsSetHandlInst();
                }
                
                public bool IsSetHandlInst() 
                { 
                    return IsSetField(Tags.HandlInst);
                }
                public QuickFix.Fields.ExecInst ExecInst
                { 
                    get 
                    {
                        QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecInst val) 
                { 
                    this.ExecInst = val;
                }
                
                public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecInst val) 
                { 
                    return IsSetExecInst();
                }
                
                public bool IsSetExecInst() 
                { 
                    return IsSetField(Tags.ExecInst);
                }
                public QuickFix.Fields.MinQty MinQty
                { 
                    get 
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinQty val) 
                { 
                    this.MinQty = val;
                }
                
                public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinQty val) 
                { 
                    return IsSetMinQty();
                }
                
                public bool IsSetMinQty() 
                { 
                    return IsSetField(Tags.MinQty);
                }
                public QuickFix.Fields.MaxFloor MaxFloor
                { 
                    get 
                    {
                        QuickFix.Fields.MaxFloor val = new QuickFix.Fields.MaxFloor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxFloor val) 
                { 
                    this.MaxFloor = val;
                }
                
                public QuickFix.Fields.MaxFloor Get(QuickFix.Fields.MaxFloor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxFloor val) 
                { 
                    return IsSetMaxFloor();
                }
                
                public bool IsSetMaxFloor() 
                { 
                    return IsSetField(Tags.MaxFloor);
                }
                public QuickFix.Fields.ExDestination ExDestination
                { 
                    get 
                    {
                        QuickFix.Fields.ExDestination val = new QuickFix.Fields.ExDestination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExDestination val) 
                { 
                    this.ExDestination = val;
                }
                
                public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExDestination val) 
                { 
                    return IsSetExDestination();
                }
                
                public bool IsSetExDestination() 
                { 
                    return IsSetField(Tags.ExDestination);
                }
                public QuickFix.Fields.NoTradingSessions NoTradingSessions
                { 
                    get 
                    {
                        QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTradingSessions val) 
                { 
                    this.NoTradingSessions = val;
                }
                
                public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTradingSessions val) 
                { 
                    return IsSetNoTradingSessions();
                }
                
                public bool IsSetNoTradingSessions() 
                { 
                    return IsSetField(Tags.NoTradingSessions);
                }
                public QuickFix.Fields.ProcessCode ProcessCode
                { 
                    get 
                    {
                        QuickFix.Fields.ProcessCode val = new QuickFix.Fields.ProcessCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProcessCode val) 
                { 
                    this.ProcessCode = val;
                }
                
                public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProcessCode val) 
                { 
                    return IsSetProcessCode();
                }
                
                public bool IsSetProcessCode() 
                { 
                    return IsSetField(Tags.ProcessCode);
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
                public QuickFix.Fields.PrevClosePx PrevClosePx
                { 
                    get 
                    {
                        QuickFix.Fields.PrevClosePx val = new QuickFix.Fields.PrevClosePx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PrevClosePx val) 
                { 
                    this.PrevClosePx = val;
                }
                
                public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PrevClosePx val) 
                { 
                    return IsSetPrevClosePx();
                }
                
                public bool IsSetPrevClosePx() 
                { 
                    return IsSetField(Tags.PrevClosePx);
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
                public QuickFix.Fields.SideValueInd SideValueInd
                { 
                    get 
                    {
                        QuickFix.Fields.SideValueInd val = new QuickFix.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SideValueInd val) 
                { 
                    this.SideValueInd = val;
                }
                
                public QuickFix.Fields.SideValueInd Get(QuickFix.Fields.SideValueInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SideValueInd val) 
                { 
                    return IsSetSideValueInd();
                }
                
                public bool IsSetSideValueInd() 
                { 
                    return IsSetField(Tags.SideValueInd);
                }
                public QuickFix.Fields.LocateReqd LocateReqd
                { 
                    get 
                    {
                        QuickFix.Fields.LocateReqd val = new QuickFix.Fields.LocateReqd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocateReqd val) 
                { 
                    this.LocateReqd = val;
                }
                
                public QuickFix.Fields.LocateReqd Get(QuickFix.Fields.LocateReqd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocateReqd val) 
                { 
                    return IsSetLocateReqd();
                }
                
                public bool IsSetLocateReqd() 
                { 
                    return IsSetField(Tags.LocateReqd);
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
                public QuickFix.Fields.NoStipulations NoStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStipulations val) 
                { 
                    this.NoStipulations = val;
                }
                
                public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStipulations val) 
                { 
                    return IsSetNoStipulations();
                }
                
                public bool IsSetNoStipulations() 
                { 
                    return IsSetField(Tags.NoStipulations);
                }
                public QuickFix.Fields.QtyType QtyType
                { 
                    get 
                    {
                        QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QtyType val) 
                { 
                    this.QtyType = val;
                }
                
                public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QtyType val) 
                { 
                    return IsSetQtyType();
                }
                
                public bool IsSetQtyType() 
                { 
                    return IsSetField(Tags.QtyType);
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
                public QuickFix.Fields.OrdType OrdType
                { 
                    get 
                    {
                        QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdType val) 
                { 
                    this.OrdType = val;
                }
                
                public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdType val) 
                { 
                    return IsSetOrdType();
                }
                
                public bool IsSetOrdType() 
                { 
                    return IsSetField(Tags.OrdType);
                }
                public QuickFix.Fields.PriceType PriceType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceType val) 
                { 
                    this.PriceType = val;
                }
                
                public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceType val) 
                { 
                    return IsSetPriceType();
                }
                
                public bool IsSetPriceType() 
                { 
                    return IsSetField(Tags.PriceType);
                }
                public QuickFix.Fields.Price Price
                { 
                    get 
                    {
                        QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Price val) 
                { 
                    this.Price = val;
                }
                
                public QuickFix.Fields.Price Get(QuickFix.Fields.Price val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Price val) 
                { 
                    return IsSetPrice();
                }
                
                public bool IsSetPrice() 
                { 
                    return IsSetField(Tags.Price);
                }
                public QuickFix.Fields.StopPx StopPx
                { 
                    get 
                    {
                        QuickFix.Fields.StopPx val = new QuickFix.Fields.StopPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StopPx val) 
                { 
                    this.StopPx = val;
                }
                
                public QuickFix.Fields.StopPx Get(QuickFix.Fields.StopPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StopPx val) 
                { 
                    return IsSetStopPx();
                }
                
                public bool IsSetStopPx() 
                { 
                    return IsSetField(Tags.StopPx);
                }
                public QuickFix.Fields.Spread Spread
                { 
                    get 
                    {
                        QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Spread val) 
                { 
                    this.Spread = val;
                }
                
                public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Spread val) 
                { 
                    return IsSetSpread();
                }
                
                public bool IsSetSpread() 
                { 
                    return IsSetField(Tags.Spread);
                }
                public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    this.BenchmarkCurveCurrency = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    return IsSetBenchmarkCurveCurrency();
                }
                
                public bool IsSetBenchmarkCurveCurrency() 
                { 
                    return IsSetField(Tags.BenchmarkCurveCurrency);
                }
                public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    this.BenchmarkCurveName = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    return IsSetBenchmarkCurveName();
                }
                
                public bool IsSetBenchmarkCurveName() 
                { 
                    return IsSetField(Tags.BenchmarkCurveName);
                }
                public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    this.BenchmarkCurvePoint = val;
                }
                
                public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    return IsSetBenchmarkCurvePoint();
                }
                
                public bool IsSetBenchmarkCurvePoint() 
                { 
                    return IsSetField(Tags.BenchmarkCurvePoint);
                }
                public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    this.BenchmarkPrice = val;
                }
                
                public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    return IsSetBenchmarkPrice();
                }
                
                public bool IsSetBenchmarkPrice() 
                { 
                    return IsSetField(Tags.BenchmarkPrice);
                }
                public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    this.BenchmarkPriceType = val;
                }
                
                public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    return IsSetBenchmarkPriceType();
                }
                
                public bool IsSetBenchmarkPriceType() 
                { 
                    return IsSetField(Tags.BenchmarkPriceType);
                }
                public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    this.BenchmarkSecurityID = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    return IsSetBenchmarkSecurityID();
                }
                
                public bool IsSetBenchmarkSecurityID() 
                { 
                    return IsSetField(Tags.BenchmarkSecurityID);
                }
                public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    this.BenchmarkSecurityIDSource = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    return IsSetBenchmarkSecurityIDSource();
                }
                
                public bool IsSetBenchmarkSecurityIDSource() 
                { 
                    return IsSetField(Tags.BenchmarkSecurityIDSource);
                }
                public QuickFix.Fields.YieldType YieldType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldType val = new QuickFix.Fields.YieldType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldType val) 
                { 
                    this.YieldType = val;
                }
                
                public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldType val) 
                { 
                    return IsSetYieldType();
                }
                
                public bool IsSetYieldType() 
                { 
                    return IsSetField(Tags.YieldType);
                }
                public QuickFix.Fields.Yield Yield
                { 
                    get 
                    {
                        QuickFix.Fields.Yield val = new QuickFix.Fields.Yield();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Yield val) 
                { 
                    this.Yield = val;
                }
                
                public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Yield val) 
                { 
                    return IsSetYield();
                }
                
                public bool IsSetYield() 
                { 
                    return IsSetField(Tags.Yield);
                }
                public QuickFix.Fields.YieldCalcDate YieldCalcDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldCalcDate val = new QuickFix.Fields.YieldCalcDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldCalcDate val) 
                { 
                    this.YieldCalcDate = val;
                }
                
                public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldCalcDate val) 
                { 
                    return IsSetYieldCalcDate();
                }
                
                public bool IsSetYieldCalcDate() 
                { 
                    return IsSetField(Tags.YieldCalcDate);
                }
                public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionDate val = new QuickFix.Fields.YieldRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    this.YieldRedemptionDate = val;
                }
                
                public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    return IsSetYieldRedemptionDate();
                }
                
                public bool IsSetYieldRedemptionDate() 
                { 
                    return IsSetField(Tags.YieldRedemptionDate);
                }
                public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPrice val = new QuickFix.Fields.YieldRedemptionPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    this.YieldRedemptionPrice = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    return IsSetYieldRedemptionPrice();
                }
                
                public bool IsSetYieldRedemptionPrice() 
                { 
                    return IsSetField(Tags.YieldRedemptionPrice);
                }
                public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPriceType val = new QuickFix.Fields.YieldRedemptionPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    this.YieldRedemptionPriceType = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    return IsSetYieldRedemptionPriceType();
                }
                
                public bool IsSetYieldRedemptionPriceType() 
                { 
                    return IsSetField(Tags.YieldRedemptionPriceType);
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
                public QuickFix.Fields.SolicitedFlag SolicitedFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SolicitedFlag val = new QuickFix.Fields.SolicitedFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SolicitedFlag val) 
                { 
                    this.SolicitedFlag = val;
                }
                
                public QuickFix.Fields.SolicitedFlag Get(QuickFix.Fields.SolicitedFlag val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SolicitedFlag val) 
                { 
                    return IsSetSolicitedFlag();
                }
                
                public bool IsSetSolicitedFlag() 
                { 
                    return IsSetField(Tags.SolicitedFlag);
                }
                public QuickFix.Fields.IOIid IOIid
                { 
                    get 
                    {
                        QuickFix.Fields.IOIid val = new QuickFix.Fields.IOIid();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IOIid val) 
                { 
                    this.IOIid = val;
                }
                
                public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IOIid val) 
                { 
                    return IsSetIOIid();
                }
                
                public bool IsSetIOIid() 
                { 
                    return IsSetField(Tags.IOIid);
                }
                public QuickFix.Fields.QuoteID QuoteID
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteID val) 
                { 
                    this.QuoteID = val;
                }
                
                public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteID val) 
                { 
                    return IsSetQuoteID();
                }
                
                public bool IsSetQuoteID() 
                { 
                    return IsSetField(Tags.QuoteID);
                }
                public QuickFix.Fields.TimeInForce TimeInForce
                { 
                    get 
                    {
                        QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeInForce val) 
                { 
                    this.TimeInForce = val;
                }
                
                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TimeInForce val) 
                { 
                    return IsSetTimeInForce();
                }
                
                public bool IsSetTimeInForce() 
                { 
                    return IsSetField(Tags.TimeInForce);
                }
                public QuickFix.Fields.EffectiveTime EffectiveTime
                { 
                    get 
                    {
                        QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EffectiveTime val) 
                { 
                    this.EffectiveTime = val;
                }
                
                public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EffectiveTime val) 
                { 
                    return IsSetEffectiveTime();
                }
                
                public bool IsSetEffectiveTime() 
                { 
                    return IsSetField(Tags.EffectiveTime);
                }
                public QuickFix.Fields.ExpireDate ExpireDate
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireDate val) 
                { 
                    this.ExpireDate = val;
                }
                
                public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireDate val) 
                { 
                    return IsSetExpireDate();
                }
                
                public bool IsSetExpireDate() 
                { 
                    return IsSetField(Tags.ExpireDate);
                }
                public QuickFix.Fields.ExpireTime ExpireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.ExpireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return IsSetExpireTime();
                }
                
                public bool IsSetExpireTime() 
                { 
                    return IsSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.GTBookingInst GTBookingInst
                { 
                    get 
                    {
                        QuickFix.Fields.GTBookingInst val = new QuickFix.Fields.GTBookingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.GTBookingInst val) 
                { 
                    this.GTBookingInst = val;
                }
                
                public QuickFix.Fields.GTBookingInst Get(QuickFix.Fields.GTBookingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.GTBookingInst val) 
                { 
                    return IsSetGTBookingInst();
                }
                
                public bool IsSetGTBookingInst() 
                { 
                    return IsSetField(Tags.GTBookingInst);
                }
                public QuickFix.Fields.Commission Commission
                { 
                    get 
                    {
                        QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Commission val) 
                { 
                    this.Commission = val;
                }
                
                public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Commission val) 
                { 
                    return IsSetCommission();
                }
                
                public bool IsSetCommission() 
                { 
                    return IsSetField(Tags.Commission);
                }
                public QuickFix.Fields.CommType CommType
                { 
                    get 
                    {
                        QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CommType val) 
                { 
                    this.CommType = val;
                }
                
                public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CommType val) 
                { 
                    return IsSetCommType();
                }
                
                public bool IsSetCommType() 
                { 
                    return IsSetField(Tags.CommType);
                }
                public QuickFix.Fields.CommCurrency CommCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.CommCurrency val = new QuickFix.Fields.CommCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CommCurrency val) 
                { 
                    this.CommCurrency = val;
                }
                
                public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CommCurrency val) 
                { 
                    return IsSetCommCurrency();
                }
                
                public bool IsSetCommCurrency() 
                { 
                    return IsSetField(Tags.CommCurrency);
                }
                public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
                { 
                    get 
                    {
                        QuickFix.Fields.FundRenewWaiv val = new QuickFix.Fields.FundRenewWaiv();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    this.FundRenewWaiv = val;
                }
                
                public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    return IsSetFundRenewWaiv();
                }
                
                public bool IsSetFundRenewWaiv() 
                { 
                    return IsSetField(Tags.FundRenewWaiv);
                }
                public QuickFix.Fields.OrderCapacity OrderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.OrderCapacity val = new QuickFix.Fields.OrderCapacity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderCapacity val) 
                { 
                    this.OrderCapacity = val;
                }
                
                public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderCapacity val) 
                { 
                    return IsSetOrderCapacity();
                }
                
                public bool IsSetOrderCapacity() 
                { 
                    return IsSetField(Tags.OrderCapacity);
                }
                public QuickFix.Fields.OrderRestrictions OrderRestrictions
                { 
                    get 
                    {
                        QuickFix.Fields.OrderRestrictions val = new QuickFix.Fields.OrderRestrictions();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderRestrictions val) 
                { 
                    this.OrderRestrictions = val;
                }
                
                public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderRestrictions val) 
                { 
                    return IsSetOrderRestrictions();
                }
                
                public bool IsSetOrderRestrictions() 
                { 
                    return IsSetField(Tags.OrderRestrictions);
                }
                public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.CustOrderCapacity val = new QuickFix.Fields.CustOrderCapacity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    this.CustOrderCapacity = val;
                }
                
                public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    return IsSetCustOrderCapacity();
                }
                
                public bool IsSetCustOrderCapacity() 
                { 
                    return IsSetField(Tags.CustOrderCapacity);
                }
                public QuickFix.Fields.ForexReq ForexReq
                { 
                    get 
                    {
                        QuickFix.Fields.ForexReq val = new QuickFix.Fields.ForexReq();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ForexReq val) 
                { 
                    this.ForexReq = val;
                }
                
                public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ForexReq val) 
                { 
                    return IsSetForexReq();
                }
                
                public bool IsSetForexReq() 
                { 
                    return IsSetField(Tags.ForexReq);
                }
                public QuickFix.Fields.SettlCurrency SettlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrency val) 
                { 
                    this.SettlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return IsSetSettlCurrency();
                }
                
                public bool IsSetSettlCurrency() 
                { 
                    return IsSetField(Tags.SettlCurrency);
                }
                public QuickFix.Fields.BookingType BookingType
                { 
                    get 
                    {
                        QuickFix.Fields.BookingType val = new QuickFix.Fields.BookingType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BookingType val) 
                { 
                    this.BookingType = val;
                }
                
                public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BookingType val) 
                { 
                    return IsSetBookingType();
                }
                
                public bool IsSetBookingType() 
                { 
                    return IsSetField(Tags.BookingType);
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
                public QuickFix.Fields.SettlDate2 SettlDate2
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlDate2 val) 
                { 
                    this.SettlDate2 = val;
                }
                
                public QuickFix.Fields.SettlDate2 Get(QuickFix.Fields.SettlDate2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlDate2 val) 
                { 
                    return IsSetSettlDate2();
                }
                
                public bool IsSetSettlDate2() 
                { 
                    return IsSetField(Tags.SettlDate2);
                }
                public QuickFix.Fields.OrderQty2 OrderQty2
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty2 val) 
                { 
                    this.OrderQty2 = val;
                }
                
                public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty2 val) 
                { 
                    return IsSetOrderQty2();
                }
                
                public bool IsSetOrderQty2() 
                { 
                    return IsSetField(Tags.OrderQty2);
                }
                public QuickFix.Fields.Price2 Price2
                { 
                    get 
                    {
                        QuickFix.Fields.Price2 val = new QuickFix.Fields.Price2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Price2 val) 
                { 
                    this.Price2 = val;
                }
                
                public QuickFix.Fields.Price2 Get(QuickFix.Fields.Price2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Price2 val) 
                { 
                    return IsSetPrice2();
                }
                
                public bool IsSetPrice2() 
                { 
                    return IsSetField(Tags.Price2);
                }
                public QuickFix.Fields.PositionEffect PositionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.PositionEffect val = new QuickFix.Fields.PositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PositionEffect val) 
                { 
                    this.PositionEffect = val;
                }
                
                public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PositionEffect val) 
                { 
                    return IsSetPositionEffect();
                }
                
                public bool IsSetPositionEffect() 
                { 
                    return IsSetField(Tags.PositionEffect);
                }
                public QuickFix.Fields.CoveredOrUncovered CoveredOrUncovered
                { 
                    get 
                    {
                        QuickFix.Fields.CoveredOrUncovered val = new QuickFix.Fields.CoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    this.CoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.CoveredOrUncovered Get(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    return IsSetCoveredOrUncovered();
                }
                
                public bool IsSetCoveredOrUncovered() 
                { 
                    return IsSetField(Tags.CoveredOrUncovered);
                }
                public QuickFix.Fields.MaxShow MaxShow
                { 
                    get 
                    {
                        QuickFix.Fields.MaxShow val = new QuickFix.Fields.MaxShow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxShow val) 
                { 
                    this.MaxShow = val;
                }
                
                public QuickFix.Fields.MaxShow Get(QuickFix.Fields.MaxShow val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxShow val) 
                { 
                    return IsSetMaxShow();
                }
                
                public bool IsSetMaxShow() 
                { 
                    return IsSetField(Tags.MaxShow);
                }
                public QuickFix.Fields.PegOffsetValue PegOffsetValue
                { 
                    get 
                    {
                        QuickFix.Fields.PegOffsetValue val = new QuickFix.Fields.PegOffsetValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegOffsetValue val) 
                { 
                    this.PegOffsetValue = val;
                }
                
                public QuickFix.Fields.PegOffsetValue Get(QuickFix.Fields.PegOffsetValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegOffsetValue val) 
                { 
                    return IsSetPegOffsetValue();
                }
                
                public bool IsSetPegOffsetValue() 
                { 
                    return IsSetField(Tags.PegOffsetValue);
                }
                public QuickFix.Fields.PegMoveType PegMoveType
                { 
                    get 
                    {
                        QuickFix.Fields.PegMoveType val = new QuickFix.Fields.PegMoveType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegMoveType val) 
                { 
                    this.PegMoveType = val;
                }
                
                public QuickFix.Fields.PegMoveType Get(QuickFix.Fields.PegMoveType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegMoveType val) 
                { 
                    return IsSetPegMoveType();
                }
                
                public bool IsSetPegMoveType() 
                { 
                    return IsSetField(Tags.PegMoveType);
                }
                public QuickFix.Fields.PegOffsetType PegOffsetType
                { 
                    get 
                    {
                        QuickFix.Fields.PegOffsetType val = new QuickFix.Fields.PegOffsetType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegOffsetType val) 
                { 
                    this.PegOffsetType = val;
                }
                
                public QuickFix.Fields.PegOffsetType Get(QuickFix.Fields.PegOffsetType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegOffsetType val) 
                { 
                    return IsSetPegOffsetType();
                }
                
                public bool IsSetPegOffsetType() 
                { 
                    return IsSetField(Tags.PegOffsetType);
                }
                public QuickFix.Fields.PegLimitType PegLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.PegLimitType val = new QuickFix.Fields.PegLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegLimitType val) 
                { 
                    this.PegLimitType = val;
                }
                
                public QuickFix.Fields.PegLimitType Get(QuickFix.Fields.PegLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegLimitType val) 
                { 
                    return IsSetPegLimitType();
                }
                
                public bool IsSetPegLimitType() 
                { 
                    return IsSetField(Tags.PegLimitType);
                }
                public QuickFix.Fields.PegRoundDirection PegRoundDirection
                { 
                    get 
                    {
                        QuickFix.Fields.PegRoundDirection val = new QuickFix.Fields.PegRoundDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegRoundDirection val) 
                { 
                    this.PegRoundDirection = val;
                }
                
                public QuickFix.Fields.PegRoundDirection Get(QuickFix.Fields.PegRoundDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegRoundDirection val) 
                { 
                    return IsSetPegRoundDirection();
                }
                
                public bool IsSetPegRoundDirection() 
                { 
                    return IsSetField(Tags.PegRoundDirection);
                }
                public QuickFix.Fields.PegScope PegScope
                { 
                    get 
                    {
                        QuickFix.Fields.PegScope val = new QuickFix.Fields.PegScope();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegScope val) 
                { 
                    this.PegScope = val;
                }
                
                public QuickFix.Fields.PegScope Get(QuickFix.Fields.PegScope val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegScope val) 
                { 
                    return IsSetPegScope();
                }
                
                public bool IsSetPegScope() 
                { 
                    return IsSetField(Tags.PegScope);
                }
                public QuickFix.Fields.DiscretionInst DiscretionInst
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionInst val = new QuickFix.Fields.DiscretionInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionInst val) 
                { 
                    this.DiscretionInst = val;
                }
                
                public QuickFix.Fields.DiscretionInst Get(QuickFix.Fields.DiscretionInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionInst val) 
                { 
                    return IsSetDiscretionInst();
                }
                
                public bool IsSetDiscretionInst() 
                { 
                    return IsSetField(Tags.DiscretionInst);
                }
                public QuickFix.Fields.DiscretionOffsetValue DiscretionOffsetValue
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionOffsetValue val = new QuickFix.Fields.DiscretionOffsetValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    this.DiscretionOffsetValue = val;
                }
                
                public QuickFix.Fields.DiscretionOffsetValue Get(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    return IsSetDiscretionOffsetValue();
                }
                
                public bool IsSetDiscretionOffsetValue() 
                { 
                    return IsSetField(Tags.DiscretionOffsetValue);
                }
                public QuickFix.Fields.DiscretionMoveType DiscretionMoveType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionMoveType val = new QuickFix.Fields.DiscretionMoveType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    this.DiscretionMoveType = val;
                }
                
                public QuickFix.Fields.DiscretionMoveType Get(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    return IsSetDiscretionMoveType();
                }
                
                public bool IsSetDiscretionMoveType() 
                { 
                    return IsSetField(Tags.DiscretionMoveType);
                }
                public QuickFix.Fields.DiscretionOffsetType DiscretionOffsetType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionOffsetType val = new QuickFix.Fields.DiscretionOffsetType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    this.DiscretionOffsetType = val;
                }
                
                public QuickFix.Fields.DiscretionOffsetType Get(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    return IsSetDiscretionOffsetType();
                }
                
                public bool IsSetDiscretionOffsetType() 
                { 
                    return IsSetField(Tags.DiscretionOffsetType);
                }
                public QuickFix.Fields.DiscretionLimitType DiscretionLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionLimitType val = new QuickFix.Fields.DiscretionLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    this.DiscretionLimitType = val;
                }
                
                public QuickFix.Fields.DiscretionLimitType Get(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    return IsSetDiscretionLimitType();
                }
                
                public bool IsSetDiscretionLimitType() 
                { 
                    return IsSetField(Tags.DiscretionLimitType);
                }
                public QuickFix.Fields.DiscretionRoundDirection DiscretionRoundDirection
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionRoundDirection val = new QuickFix.Fields.DiscretionRoundDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    this.DiscretionRoundDirection = val;
                }
                
                public QuickFix.Fields.DiscretionRoundDirection Get(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    return IsSetDiscretionRoundDirection();
                }
                
                public bool IsSetDiscretionRoundDirection() 
                { 
                    return IsSetField(Tags.DiscretionRoundDirection);
                }
                public QuickFix.Fields.DiscretionScope DiscretionScope
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionScope val = new QuickFix.Fields.DiscretionScope();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionScope val) 
                { 
                    this.DiscretionScope = val;
                }
                
                public QuickFix.Fields.DiscretionScope Get(QuickFix.Fields.DiscretionScope val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionScope val) 
                { 
                    return IsSetDiscretionScope();
                }
                
                public bool IsSetDiscretionScope() 
                { 
                    return IsSetField(Tags.DiscretionScope);
                }
                public QuickFix.Fields.TargetStrategy TargetStrategy
                { 
                    get 
                    {
                        QuickFix.Fields.TargetStrategy val = new QuickFix.Fields.TargetStrategy();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TargetStrategy val) 
                { 
                    this.TargetStrategy = val;
                }
                
                public QuickFix.Fields.TargetStrategy Get(QuickFix.Fields.TargetStrategy val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TargetStrategy val) 
                { 
                    return IsSetTargetStrategy();
                }
                
                public bool IsSetTargetStrategy() 
                { 
                    return IsSetField(Tags.TargetStrategy);
                }
                public QuickFix.Fields.TargetStrategyParameters TargetStrategyParameters
                { 
                    get 
                    {
                        QuickFix.Fields.TargetStrategyParameters val = new QuickFix.Fields.TargetStrategyParameters();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    this.TargetStrategyParameters = val;
                }
                
                public QuickFix.Fields.TargetStrategyParameters Get(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    return IsSetTargetStrategyParameters();
                }
                
                public bool IsSetTargetStrategyParameters() 
                { 
                    return IsSetField(Tags.TargetStrategyParameters);
                }
                public QuickFix.Fields.ParticipationRate ParticipationRate
                { 
                    get 
                    {
                        QuickFix.Fields.ParticipationRate val = new QuickFix.Fields.ParticipationRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ParticipationRate val) 
                { 
                    this.ParticipationRate = val;
                }
                
                public QuickFix.Fields.ParticipationRate Get(QuickFix.Fields.ParticipationRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ParticipationRate val) 
                { 
                    return IsSetParticipationRate();
                }
                
                public bool IsSetParticipationRate() 
                { 
                    return IsSetField(Tags.ParticipationRate);
                }
                public QuickFix.Fields.Designation Designation
                { 
                    get 
                    {
                        QuickFix.Fields.Designation val = new QuickFix.Fields.Designation();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Designation val) 
                { 
                    this.Designation = val;
                }
                
                public QuickFix.Fields.Designation Get(QuickFix.Fields.Designation val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Designation val) 
                { 
                    return IsSetDesignation();
                }
                
                public bool IsSetDesignation() 
                { 
                    return IsSetField(Tags.Designation);
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
                public class NoAllocsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0};
                
                    public NoAllocsGroup() 
                      :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoAllocsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.AllocAccount AllocAccount
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocAccount val) 
                    { 
                        this.AllocAccount = val;
                    }
                    
                    public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocAccount val) 
                    { 
                        return IsSetAllocAccount();
                    }
                    
                    public bool IsSetAllocAccount() 
                    { 
                        return IsSetField(Tags.AllocAccount);
                    }
                    public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        this.AllocAcctIDSource = val;
                    }
                    
                    public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        return IsSetAllocAcctIDSource();
                    }
                    
                    public bool IsSetAllocAcctIDSource() 
                    { 
                        return IsSetField(Tags.AllocAcctIDSource);
                    }
                    public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocSettlCurrency val = new QuickFix.Fields.AllocSettlCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        this.AllocSettlCurrency = val;
                    }
                    
                    public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        return IsSetAllocSettlCurrency();
                    }
                    
                    public bool IsSetAllocSettlCurrency() 
                    { 
                        return IsSetField(Tags.AllocSettlCurrency);
                    }
                    public QuickFix.Fields.IndividualAllocID IndividualAllocID
                    { 
                        get 
                        {
                            QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        this.IndividualAllocID = val;
                    }
                    
                    public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        return IsSetIndividualAllocID();
                    }
                    
                    public bool IsSetIndividualAllocID() 
                    { 
                        return IsSetField(Tags.IndividualAllocID);
                    }
                    public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        this.NoNestedPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        return IsSetNoNestedPartyIDs();
                    }
                    
                    public bool IsSetNoNestedPartyIDs() 
                    { 
                        return IsSetField(Tags.NoNestedPartyIDs);
                    }
                    public QuickFix.Fields.AllocQty AllocQty
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocQty val = new QuickFix.Fields.AllocQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocQty val) 
                    { 
                        this.AllocQty = val;
                    }
                    
                    public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocQty val) 
                    { 
                        return IsSetAllocQty();
                    }
                    
                    public bool IsSetAllocQty() 
                    { 
                        return IsSetField(Tags.AllocQty);
                    }
                                    public class NoNestedPartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                    
                        public NoNestedPartyIDsGroup() 
                          :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.NestedPartyID NestedPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyID val) 
                        { 
                            this.NestedPartyID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                        { 
                            return IsSetNestedPartyID();
                        }
                        
                        public bool IsSetNestedPartyID() 
                        { 
                            return IsSetField(Tags.NestedPartyID);
                        }
                        public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            this.NestedPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            return IsSetNestedPartyIDSource();
                        }
                        
                        public bool IsSetNestedPartyIDSource() 
                        { 
                            return IsSetField(Tags.NestedPartyIDSource);
                        }
                        public QuickFix.Fields.NestedPartyRole NestedPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            this.NestedPartyRole = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            return IsSetNestedPartyRole();
                        }
                        
                        public bool IsSetNestedPartyRole() 
                        { 
                            return IsSetField(Tags.NestedPartyRole);
                        }
                        public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            this.NoNestedPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            return IsSetNoNestedPartySubIDs();
                        }
                        
                        public bool IsSetNoNestedPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoNestedPartySubIDs);
                        }
                                            public class NoNestedPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                        
                            public NoNestedPartySubIDsGroup() 
                              :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoNestedPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.NestedPartySubID NestedPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                this.NestedPartySubID = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                return IsSetNestedPartySubID();
                            }
                            
                            public bool IsSetNestedPartySubID() 
                            { 
                                return IsSetField(Tags.NestedPartySubID);
                            }
                            public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                this.NestedPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                return IsSetNestedPartySubIDType();
                            }
                            
                            public bool IsSetNestedPartySubIDType() 
                            { 
                                return IsSetField(Tags.NestedPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoTradingSessionsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};
                
                    public NoTradingSessionsGroup() 
                      :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                public class NoStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};
                
                    public NoStipulationsGroup() 
                      :base( Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StipulationType StipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationType val) 
                    { 
                        this.StipulationType = val;
                    }
                    
                    public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationType val) 
                    { 
                        return IsSetStipulationType();
                    }
                    
                    public bool IsSetStipulationType() 
                    { 
                        return IsSetField(Tags.StipulationType);
                    }
                    public QuickFix.Fields.StipulationValue StipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationValue val) 
                    { 
                        this.StipulationValue = val;
                    }
                    
                    public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationValue val) 
                    { 
                        return IsSetStipulationValue();
                    }
                    
                    public bool IsSetStipulationValue() 
                    { 
                        return IsSetField(Tags.StipulationValue);
                    }
                
                }
            }
        }
    }
}
