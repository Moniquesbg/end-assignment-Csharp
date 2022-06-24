using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubContribution
{
    internal class Contribution
    {
        //fields
        private Member member;

        public Contribution(Member member)
        {
            this.member = member;
        }

        public Member Member { get; set; }

        public double calculateContribution()
        {
            double contribution = 0;

            if (member.getAge() < 18 && member.PlayingMember == 1 && member.calculateTotalMembershipYears() < 7)//Junior - niet spelend - niet langer dan 7 jaar lid : 75
            {
                return contribution = 75;
            }
            else if (member.getAge() < 18 && member.PlayingMember == 1 && member.calculateTotalMembershipYears() < 7)//Junior - spelend - niet langer dan 7 jaar lid: 120
            {
                return contribution = 120;
            }
            else if (member.getAge() < 18 && member.PlayingMember == 0 && member.calculateTotalMembershipYears() >= 7)//Junior - niet spelend - wel langer dan 7 jaar lid: 71.25
            {
                return contribution = 71.25;
            }
            else if (member.getAge() < 18 && member.PlayingMember == 1 && member.calculateTotalMembershipYears() >= 7)//Junior - spelend - wel langer dan 7 jaar lid: 114
            {
                return contribution = 114;
            }
            else if (member.getAge() >= 18 && member.PlayingMember == 0 && member.calculateTotalMembershipYears() < 7)//Senior - niet spelend - niet langer dan 7 jaar lid: 150
            {
                return contribution = 150;
            }
            else if (member.getAge() >= 18 && member.PlayingMember == 1 && member.calculateTotalMembershipYears() < 7)//Senior - spelend - niet langer dan 7 jaar lid: 195
            {
                return contribution = 195;
            }
            else if (member.getAge() >= 18 && member.PlayingMember == 0 && member.calculateTotalMembershipYears() >= 7)//Senior - niet spelend - wel langer dan 7 jaar lid: 142,50
            {
                return contribution = 142.50;
            }
            else if (member.getAge() >= 18 && member.PlayingMember == 1 && member.calculateTotalMembershipYears() >= 7)// Senior - spelend - wel langer dan 7 jaar lid: 185.25
            {
                return contribution = 185.25;
            }

            return contribution;
        }


    }
}
