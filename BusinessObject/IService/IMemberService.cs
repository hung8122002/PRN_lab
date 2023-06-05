using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface IMemberService
    {
        public int Login(MemberObject member);

        public void AddMember(MemberObject member);
        public void DeleteMember(MemberObject member);
        public void UpdateMember(MemberObject member);

        public ObservableCollection<MemberObject> GetMembers();
    }
}
