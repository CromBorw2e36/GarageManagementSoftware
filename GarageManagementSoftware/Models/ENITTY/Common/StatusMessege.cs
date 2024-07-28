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

        public StatusMessege<T> setStatus(int i)
        {
            status = i;
            return this; 
        }

        public StatusMessege<T> setMessage(string p)
        {
            this.messege = p;
            return this;
        }

        public StatusMessege<T> setData(T p)
        {
            this.data = p;
            return this;
        }
    }
}
