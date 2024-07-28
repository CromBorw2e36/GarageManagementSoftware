namespace GarageManagementSoftware.Models.Common
{
    public class DataSystemCommon
    {
        public DataContext _dataContext;
        public DataSystemCommon(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public string GenRowCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
