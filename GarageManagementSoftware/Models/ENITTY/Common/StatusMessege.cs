namespace GarageManagementSoftware.Models.ENITTY.Common
{
    public class StatusMessege<T>
    {
        public int? status { get; set; }
        public string? messege { get; set; }

        public T? data { get; set; }

        public StatusMessege() { }  
        public StatusMessege(int? status, string? messege, T? data)
        {
            this.status = status;
            this.messege = messege;
            this.data = data;
        }

        public void setStatus(int i)
        {
            this.status = i;
        }

        public void setMessenger(string p)
        {
            this.messege = p;
        }

        public void setData(T p)
        {
            this.data = p;
        }
    }
}
