


using SmartBot.DataDto.Base;
using SmartBot.DataDto.Group;

namespace SmartBot.Services.Group
{
    public interface IGroupService
    {
        public ResponseBase GetDataGroupPost();
        public ResponseBase GetProvince();
        public ResponseBase GetTypeByKey(string key);
        public ResponseBase GetGroupByTypeAndLocation(string type, string location, string profile);
        public ResponseBase GetSearchConfig();
        public ResponseBase InsertGroup(InsertGroupDto data);
        public ResponseBase GetJoinedGroup(int idFacebook);

    }
}
