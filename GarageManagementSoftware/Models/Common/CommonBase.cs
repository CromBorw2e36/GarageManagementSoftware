namespace GarageManagementSoftware.Models.Common
{
    public class CommonBase
    {
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public Object SplitDate(DateTime p)
        {
            return new
            {
                dd = p.ToString("dd"),
                MM = p.ToString("MM"),
                yyyy = p.ToString("yyyy"),
            };
        }

        public string FormatNumberVoucherD32(int number)
        {
            return number.ToString("D32");
        }

        public string FormatNumberVoucherD8(int number)
        {
            return number.ToString("D8");
        }
    }
}
