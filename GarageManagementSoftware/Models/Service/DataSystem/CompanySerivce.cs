using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Interface.DataSystem;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class CompanySerivce : DataSystemCommon, ICompany
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }
        public StatusMessege<CompanyModel> Delete(HttpRequest httpRequest, CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public List<CompanyModel> Get(HttpRequest httpRequest, CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<CompanyModel> Insert(HttpRequest httpRequest, CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<CompanyModel> Search(HttpRequest httpRequest, CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<CompanyModel> Update(HttpRequest httpRequest, CompanyModel model)
        {
            throw new NotImplementedException();
        }
    }
}
