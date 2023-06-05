using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.IRepository
{
    public interface IMemberRepository
    {
        public int Login(Member member);
        public void AddMember(Member member);
        public void UpdateMember(Member member);
        public void DeleteMember(Member member);

        public ObservableCollection<Member> GetMembers();
    }
}
