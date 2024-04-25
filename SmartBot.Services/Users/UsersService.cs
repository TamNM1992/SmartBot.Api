
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Entities;
using SmartBot.DataAccess.Interface;
using SmartBot.DataDto.Base;
using SmartBot.DataDto.User;
using System.Data;
using System.Linq;

namespace SmartBot.Services.Users
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private readonly ICommonUoW _commonUoW;
        private readonly ICommonRepository<User> _userRepository;
        public UserService( IMapper mapper, ICommonUoW commonUoW, ICommonRepository<User> userRepository)
        {
            _mapper = mapper;
            _commonUoW = commonUoW;
            _userRepository = userRepository;
        }
        public ResponseBase CheckUserByAccount(string email, string password)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = "success",
                        Token =  "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoiYWRtaW4iLCJod0lEIjoiNTIyOS04MDA0LTE3NUMtRkEzQi02Njg2LTJEQjMtQzY0Qi1GMkFEIiwiZXhwIjoxNjk2NTg2OTIxLCJpYXQiOjE2OTU5ODIxMjF9.f1Dyw0n9q6uuzyotkQZiYFfxTDvgXoEwZmE2LJUJ4dQ"
                    },

                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase CheckUserByToken(string token)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                return new ResponseBase()
                {
                    Code= 0,
                    Message = "Success",
                    Data = new LoginDto()
                    {
                        Status = "success",
                    },
                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
        public ResponseBase Register(UserDto data)
        {
            ResponseBase response = new ResponseBase();
            try
            {
                var olduser = _userRepository.FindAll(x => x.UserName==data.Email);
                if (olduser!=null && olduser.Any())
                {
                    response.Message ="username existing";
                    return response;
                }
                var user = new User
                {
                    UserName = data.Email,
                    Password = data.Password,
                    Status=1,
                    DateCreated= DateTime.Now,
                    DateUpdate= DateTime.Now,
                };
                _commonUoW.BeginTransaction();
                _userRepository.Insert(user);
                _commonUoW.Commit();

                response.Data=user.Id;
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
