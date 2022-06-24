using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubContribution
{
    public class Member
    {
        //fields
        private String name;
        private DateTime birthDate;
        private DateTime memberSinceDate;
        private int playingMember;

        public Member(String name, DateTime birthDate, DateTime memberSinceDate, int playingMember)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.memberSinceDate = memberSinceDate;
            this.playingMember = playingMember;
        }

        public String Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime MemberSinceDate { get; set; }
        public int PlayingMember { get; set; }

        //checking if a member is a senior. Under 18 is junior, above 18 is senior
        public int getAge()
        {
            var today = DateTime.Today;

            var todayDate = (today.Year * 100 + today.Month) * 100 + today.Day; //example 2022062022
            var birthDate = (this.BirthDate.Year * 100 + this.BirthDate.Month) * 100 + this.BirthDate.Day;
            var period = (todayDate - birthDate) / 10000;

            return period;
        }

        //method that calculates how many years a member has a membership
        public int calculateTotalMembershipYears()
        {
            var today = DateTime.Today;

            var todayDate = (today.Year * 100 + today.Month) * 100 + today.Day; //example 2022062022
            var membershipDate = (this.memberSinceDate.Year * 100 + this.memberSinceDate.Month) * 100 + this.memberSinceDate.Day;
            var period = (todayDate - membershipDate) / 10000;

            return membershipDate;
        }
    }
}
