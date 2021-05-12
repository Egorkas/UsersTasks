using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.BusinessLayer.Interfaces;
using TaskSheduler.DataAccess;
using TaskSheduler.DataAccess.Entities;

namespace TaskSheduler.BusinessLayer
{
    public class UserService: IGenericServices<UserDTO>
    {
        private readonly IGenericRepository<User> _userRepo;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public void Create(UserDTO item)
            => _userRepo.Create(_mapper.Map<User>(item));

        public UserDTO FindById(int id)
            => _mapper.Map<UserDTO>(_userRepo.FindById(id));

        public IEnumerable<UserDTO> Get(Func<UserDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
            => _mapper.Map<IEnumerable<UserDTO>>(_userRepo.GetAll());

        //public void Remove(UserDTO item)
        //    => _userRepo.Remove(_mapper.Map<User>(item));

        public void Remove(int id)
            => _userRepo.Remove(id);

        public void Update(UserDTO item)
            => _userRepo.Update(_mapper.Map<User>(item));
    }
}
