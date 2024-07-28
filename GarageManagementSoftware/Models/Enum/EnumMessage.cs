using GarageManagementSoftware.Models.Enum;

namespace GarageManagementSoftware.Models.Enum
{
    public enum EnumMessage
    {
        NOT_CODE,
        NOT_FOUND_ITEM,
        SUCCESS,
        ERROR,
    }

    public static class EnumMessageExtensions
    {
        public static string GetMessage(this EnumMessage message)
        {
            return message switch
            {
                EnumMessage.NOT_CODE => "Not found code in item",
                EnumMessage.NOT_FOUND_ITEM => "Not found item",
                EnumMessage.SUCCESS => "Action success",
                EnumMessage.ERROR => "Action error",
                _ => "Unknown message"
            };
        }

        public static int GetStatus(this EnumMessage status)
        {
            return status switch
            {
                EnumMessage.ERROR => 0,
                EnumMessage.SUCCESS => 0,
                _ => -1
            };
        }
    }

}

//// Usage
//EnumMessage message = EnumMessage.NOT_CODE;
//string messageText = message.GetMessage();