using AutoMapper;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.Group;
using SmartBot.DataDto.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SmartBot.DataDto.Topic;

namespace SmartBot.Services.Topics
{
    public class TopicService : ITopicService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<Topic> _topicRepository;
        public TopicService(IMapper mapper, ICommonUoW commonUoW, ICommonRepository<Topic> topicRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _topicRepository=topicRepository;
        }
        public ResponseBase GetAllTopic()
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var getTopic = _topicRepository.FindAll();
                var data = new List<TopicDto>();
                foreach (var item in getTopic) {
                    var newTopic = new TopicDto()
                    {
                        Id=item.Id,
                        Topic2=item.Topic1,
                    };
                    data.Add(newTopic);
                }
                response.Data = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
    }
}
