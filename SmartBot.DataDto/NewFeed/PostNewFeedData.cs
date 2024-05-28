using SmartBot.DataDto.Img;

namespace SmartBot.DataDto.NewFeed
{
    public class PostNewFeedData
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public ImgDto? Img { get; set; }
    }
}
