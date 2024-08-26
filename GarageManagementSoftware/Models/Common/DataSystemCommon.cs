using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Service.Function.Sale;

namespace GarageManagementSoftware.Models.Common
{
    public class DataSystemCommon
    {
        public DataContext _dataContext;
        public GeneralJournalService _generalJournalService;
        public readonly CommonBase _commonBase;

        public DataSystemCommon(DataContext dataContext)
        {
            this._dataContext = dataContext;
            this._generalJournalService = new GeneralJournalService(dataContext);
            this._commonBase = new CommonBase();
        }

        public string GenRowCode(EnumTypeVoucher? typeVoucher = null)
        {
            string codeVoucher = Guid.NewGuid().ToString(); ;
            switch (typeVoucher)
            {
                case EnumTypeVoucher.INVOICE:
                    {
                        //dynamic dateObj = this._commonBase.SplitDate(DateTime.Now);
                        //int counter = this._dataContext.PaymentVoucherModel.Count() + 1;
                        //codeVoucher = $"I-{dateObj.yyyy}{dateObj.MM}{dateObj.dd}-{this._commonBase.FormatNumberVoucherD32(counter)}";
                        break;
                    }

                case EnumTypeVoucher.PAYMENT:
                    {
                        dynamic dateObj = this._commonBase.SplitDate(DateTime.Now);
                        int counter = this._dataContext.PaymentVoucherModel.Count() + 1;
                        codeVoucher = $"P-{dateObj.yyyy}{dateObj.MM}{dateObj.dd}-{this._commonBase.FormatNumberVoucherD8(counter)}";
                        break;
                    }
                case EnumTypeVoucher.RECIEPT:
                    {
                        dynamic dateObj = this._commonBase.SplitDate(DateTime.Now);
                        int counter = this._dataContext.PaymentVoucherModel.Count() + 1;
                        codeVoucher = $"R-{dateObj.yyyy}{dateObj.MM}{dateObj.dd}-{this._commonBase.FormatNumberVoucherD8(counter)}";
                        break;
                    }
                case EnumTypeVoucher.VOUCHER_1:
                    {
                        dynamic dateObj = this._commonBase.SplitDate(DateTime.Now);
                        int counter = this._dataContext.HistoryReciveOtoModel.Count() + 1;
                        codeVoucher = $"I-{dateObj.yyyy}{dateObj.MM}-{this._commonBase.FormatNumberVoucherD32(counter)}";
                        break;
                    }
            }
            return codeVoucher;
        }
    }
}
