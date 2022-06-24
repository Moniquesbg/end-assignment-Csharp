using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubContribution
{
    internal class Sportclub
    {
        //fields
        private List<Member> members { get; set; }
        private List<Contribution> contributions { get; set; }

        public Sportclub()
        {
            this.members = new List<Member>();
            this.contributions = new List<Contribution>();  
        }

        public void AddMember(Member member)
        {
            this.members.Add(member);
        }

        public void addContribution(Contribution contribution)
        {
            this.contributions.Add(contribution);
        }
        public int showYoungestMember()
        {
            int age = 0;
            Member currentMember = members.First<Member>();

            foreach (Member member in members)
            {
                age = member.getAge();
                currentMember = member;
            }
            return age;
        }

        public double calculateTotalProfit()
        {
            double total = 0;

            foreach (Contribution contribution in contributions)
            {
                total += contribution.calculateContribution();
            }
            return total;
        }

        public int calculateAverageMembershipYears()
        {
            int years = 0;

            foreach (Member member in members)
            {
                years += member.calculateTotalMembershipYears();
            }
            years /= members.Count();
            return years;
        }
    }
}
