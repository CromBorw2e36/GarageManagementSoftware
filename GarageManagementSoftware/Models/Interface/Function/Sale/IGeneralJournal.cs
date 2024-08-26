using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.Sale;

namespace GarageManagementSoftware.Models.Interface.Function.Sale
{
    public interface IGeneralJournal
    {
        public string tableName { get => this.tableName; set => this.tableName = "GeneralJournal"; }
        public List<GeneralJournalModel> Get(HttpRequest httpRequest, GeneralJournalModel model);
        //public StatusMessege<GeneralJournalModel> Insert(HttpRequest httpRequest, GeneralJournalModel model);
        //public StatusMessege<GeneralJournalModel> Update(HttpRequest httpRequest, GeneralJournalModel model);
        //public StatusMessege<GeneralJournalModel> Delete(HttpRequest httpRequest, GeneralJournalModel model);
        //public StatusMessege<GeneralJournalModel> Search(HttpRequest httpRequest, GeneralJournalModel model);
        public int AutoInsert(HttpRequest httpRequest, GeneralJournalModel model);
    }
}
