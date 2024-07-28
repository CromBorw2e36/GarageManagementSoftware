using GarageManagementSoftware.Models.Common;
using GarageManagementSoftware.Models.ENITTY.Common;
using GarageManagementSoftware.Models.ENITTY.DataSystem;
using GarageManagementSoftware.Models.ENITTY.Function.GarageAccess;
using GarageManagementSoftware.Models.Enum;
using GarageManagementSoftware.Models.Interface.Function.GarageAccess;

namespace GarageManagementSoftware.Models.Service.Function.GarageAccess
{
    public class InventoryService : DataSystemCommon, IInventory
    {
        public InventoryService(DataContext dataContext) : base(dataContext)
        {
        }

        public string tableName { get => this.tableName; set => this.tableName = "Inventory"; }
        public StatusMessege<InventoryModel> Delete(HttpRequest httpRequest, InventoryModel model)
        {

            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.InventoryModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    row.is_delete = true;
                    row.delete_at = DateTime.Now;
                    this._dataContext.Update(row);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                else
                {
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }

        public List<InventoryModel> Get(HttpRequest httpRequest, InventoryModel model)
        {
            var row = this._dataContext.InventoryModel.Where(item =>
                string.IsNullOrEmpty(model.code) ? true : item.code == model.code
            ).ToList();
            return row;
        }

        public StatusMessege<InventoryModel> Insert(HttpRequest httpRequest, InventoryModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    model.code = this.GenRowCode();
                    model.create_at = DateTime.Now;
                    model.update_at = DateTime.Now;
                    this._dataContext.InventoryModel.Add(model);
                    this._dataContext.SaveChanges();
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                }
                catch
                {
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<InventoryModel> Search(HttpRequest httpRequest, InventoryModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                try
                {
                    var row = this._dataContext.InventoryModel.Where(item => item.code == model.code).FirstOrDefault();
                    if (row != null)
                    {
                        if (!string.IsNullOrEmpty(model.company_code))
                        {
                            try
                            {

                                row.company = this._dataContext.CompanyModel.Where(x => x.code == model.company_code).FirstOrDefault();
                            }
                            catch { }
                        }

                        return new StatusMessege<InventoryModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    else
                    {
                        return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                    }
                }
                catch
                {
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                }
            }
        }

        public StatusMessege<InventoryModel> Update(HttpRequest httpRequest, InventoryModel model)
        {
            if (string.IsNullOrEmpty(model.code))
            {
                return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_CODE.GetMessage()).setData(model);
            }
            else
            {
                var row = this._dataContext.InventoryModel.Where(item => item.code == model.code).FirstOrDefault();
                if (row != null)
                {
                    try
                    {
                        row = model;
                        row.update_at = DateTime.Now;
                        this._dataContext.Update(row);
                        this._dataContext.SaveChanges();
                        return new StatusMessege<InventoryModel>().setStatus(EnumMessage.SUCCESS.GetStatus()).setMessage(EnumMessage.SUCCESS.GetMessage()).setData(model);
                    }
                    catch
                    {
                        return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.ERROR.GetMessage()).setData(model);
                    }
                }
                else
                {
                    return new StatusMessege<InventoryModel>().setStatus(EnumMessage.ERROR.GetStatus()).setMessage(EnumMessage.NOT_FOUND_ITEM.GetMessage()).setData(model);
                }
            }
        }
    }
}
