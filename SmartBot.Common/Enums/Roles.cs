namespace SmartBot.Common.Enums
{
    public enum Roles 
    {
        Vip1 = 0,
        Vip2 = 1,
        Vip3 = 2,
        Vip4 = 3,
        Vip5 = 4,
    }

    public class ActiveResponse
    {
        public string value { get; set; }
        public string status { get; set; }
        public ActiveResponse(string value, string status)
        {
            this.value = value;
            this.status = status;
        }
    }
}
