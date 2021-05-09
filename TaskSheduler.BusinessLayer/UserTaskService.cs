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
    public class UserTaskService : IGenericServices<UserTaskDTO>
    {
        private readonly IGenericRepository<UserTask> _userTaskRepo;
        private readonly IMapper _mapper;

        public UserTaskService(IGenericRepository<UserTask> userTaskRepo, IMapper mapper)
        {
            _userTaskRepo = userTaskRepo;
            _mapper = mapper;
        }

        public void Create(UserTaskDTO item)
            => _userTaskRepo.Create(_mapper.Map<UserTask>(item));

        public UserTaskDTO FindById(int id)
            => _mapper.Map<UserTaskDTO>(_userTaskRepo.FindById(id));

        public IEnumerable<UserTaskDTO> Get(Func<UserTaskDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTaskDTO> GetAll()
            => _mapper.Map<IEnumerable<UserTaskDTO>>(_userTaskRepo.GetAll());

        public void Remove(UserTaskDTO item)
            => _userTaskRepo.Remove(_mapper.Map<UserTask>(item));

        public void Update(UserTaskDTO item)
            => _userTaskRepo.Update(_mapper.Map<UserTask>(item));
    }
}
