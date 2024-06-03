namespace SmartBot.Common.Enums
{
    public enum Vips 
    {
        Vip1 = 1,
        Vip2 = 2,
        Vip3 = 3,
        Vip4 = 4,
        Vip5 = 5,
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
