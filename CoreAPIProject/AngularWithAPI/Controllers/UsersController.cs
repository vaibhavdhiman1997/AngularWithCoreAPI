using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularWithAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using BusinessLogics;
using Interfaces;
using AutoMapper;
using DTOs;

namespace AngularWithAPI.Controllers
{
    [Authorize]
    public class UsersController : BaseAPIController
    {
        private MyDBContext _context;
        ServiceManager sm;

        public readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {

            sm = new ServiceManager();
            _userRepository = userRepository;
            _mapper = mapper;
            // clsa = cls;

        }

        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();

            // var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);
            return Ok(users);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userRepository.GetMemberAsync(username);
            
            // return _mapper.Map<MemberDto>(user); 
        }
    }
}
// eager loading
