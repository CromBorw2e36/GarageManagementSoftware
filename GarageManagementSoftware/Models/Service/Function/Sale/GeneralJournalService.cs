using GarageManagementSoftware.Migrations;
using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.GarageAccess;
using GarageManagementSoftware.Models.Interface.Function.Sale;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementSoftware.Models.Service.Function.Sale
{
    public class GeneralJournalService : DataSystemCommon, IGeneralJournal
    {
        public GeneralJournalService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "GeneralJournal"; }

        public int AutoInsert(HttpRequest httpRequest, GeneralJournalModel model)
        {
            if (string.IsNullOrEmpty(model.code_voucher))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(model.accounting_number))
            {
                return -2;
            }
            else
            {
                try
                {
                    using (var context = this._dataContext)
                    {
                        var itemsToUpdate = context.GeneralJournalModel.Where(e => e.code_voucher == model.code_voucher && e.is_active == true).ToList();
                        foreach (var item in itemsToUpdate)
                        {
                            item.is_active = false;
                        }
                        context.SaveChanges();
                    }

                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.GeneralJournalModel.Add(model);
                    this._dataContext.SaveChanges();
                    return 1;
                }
                catch
                {
                    return -500;
                }
            }
        }


        public List<GeneralJournalModel> Get(HttpRequest httpRequest, GeneralJournalModel model)
        {
            var row = this._dataContext.GeneralJournalModel.Where(item =>
              string.IsNullOrEmpty(model.code) ? true : item.code == model.code
              && (item.is_active == model.is_active || (model.is_active == null && item.is_active == true))
              && item.is_delete != true
          ).ToList();
            return row;
        }
    }
}
