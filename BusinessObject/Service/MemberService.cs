using AutoMapper;
using BusinessObject.IService;
using Data_Layer.IRepository;
using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class MemberService : IMemberService
    {
        private IMemberRepository _memberRepository;
        private IMapper _mapper;

        public MemberService(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public ObservableCollection<MemberObject> GetMembers()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Member, MemberObject>();
            });
            var mapper = config.CreateMapper();
            var list = mapper.Map<ObservableCollection<MemberObject>>(_memberRepository.GetMembers());
            return list;
        }

        public int Login(MemberObject member)
        {
            var m = _mapper.Map<Member>(member);
            return _memberRepository.Login(m);
        }

        public void AddMember(MemberObject member)
        {
            var m = _mapper.Map<Member>(member);
            _memberRepository.AddMember(m);
        }

        public void DeleteMember(MemberObject member)
        {
            var m = _mapper.Map<Member>(member);
            _memberRepository.DeleteMember(m);
        }

        public void UpdateMember(MemberObject member)
        {
            var m = _mapper.Map<Member>(member);
            _memberRepository.UpdateMember(m);
        }
    }
}
