using Data_Layer.IRepository;
using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private FstoreContext _context;

        public MemberRepository()
        {
            _context = FstoreContext.GetInstance();
        }

        public void AddMember(Member member)
        {
            Member m = new Member();
            m.Email = member.Email;
            m.City = member.City;
            m.Country = member.Country;
            m.CompanyName = member.CompanyName;
            m.Password = member.Password;
            _context.Members.Add(m);
            _context.SaveChanges();
        }

        public void DeleteMember(Member member)
        {
            Member m = _context.Members.FirstOrDefault(p => p.MemberId == member.MemberId);
            if (m != null)
            {
                _context.Members.Remove(m);
                _context.SaveChanges();
            }
        }

        public ObservableCollection<Member> GetMembers()
        {
            var members = _context.Members.ToList();
            var observableMembers = new ObservableCollection<Member>(members);
            return observableMembers;
        }

        public int Login(Member member)
        {
            Member m = _context.Members.FirstOrDefault(p => p.Email.Equals(member.Email) && p.Password.Equals(member.Password));
            if (m != null)
            {
                return m.MemberId;
            }
            return 0;
        }

        public void UpdateMember(Member member)
        {
            Member m = _context.Members.FirstOrDefault(p => p.MemberId == member.MemberId);
            if (m != null)
            {
                m.Email = member.Email;
                m.CompanyName = member.CompanyName;
                m.City = member.City;
                m.Country = member.Country;
                m.Password = member.Password;
                _context.SaveChanges();
            }
        }
    }
}
