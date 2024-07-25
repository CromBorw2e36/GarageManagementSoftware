using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;

namespace GarageManagementSoftware.Models.Interface.DataSystem
{
    public interface ICompany
    {
        public string tableName { get; set; }
        public List<CompanyModel> Get(HttpRequest httpRequest, CompanyModel model);
        public StatusMessege<CompanyModel> Insert(HttpRequest httpRequest, CompanyModel model);
        public StatusMessege<CompanyModel> Update(HttpRequest httpRequest, CompanyModel model);
        public StatusMessege<CompanyModel> Delete(HttpRequest httpRequest, CompanyModel model);
        public StatusMessege<CompanyModel> Search(HttpRequest httpRequest, CompanyModel model);
    }
}
