using SmartBot.DataDto.Common;

namespace SmartBot.DataDto.ClassConfigFacebook
{
    public class PostWallDto
    {
        public int DelayTimeLoad { get; set; }
        public int DelayAction { get; set; }
        public List<ClassFB> ClassNames { get; set; }
    }
}
