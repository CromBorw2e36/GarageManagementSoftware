﻿using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.Interface.DataSystem;

namespace GarageManagementSoftware.Models.Service.DataSystem
{
    public class AccountService : DataSystemCommon, IAccount
    {
        public string tableName { get => this.tableName; set => this.tableName = "WorkFlowType"; }

        public StatusMessege<AccountModel> Delete(HttpRequest httpRequest, AccountModel model)
        {
            throw new NotImplementedException();
        }

        public List<AccountModel> Get(HttpRequest httpRequest, AccountModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<AccountModel> Insert(HttpRequest httpRequest, AccountModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<AccountModel> Search(HttpRequest httpRequest, AccountModel model)
        {
            throw new NotImplementedException();
        }

        public StatusMessege<AccountModel> Update(HttpRequest httpRequest, AccountModel model)
        {
            throw new NotImplementedException();
        }
    }
}
