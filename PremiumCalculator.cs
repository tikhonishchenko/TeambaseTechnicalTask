using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeambaseTechnicalTask
{
    internal class PremiumCalculator
    {

        private readonly DateTime memberAdditionDate;
        private readonly int memberAge;
        private readonly char memberGender;
        private readonly int flatRate = 1000;
        private readonly float ageFactorWomen = 1.5f;
        private readonly DateTime policyEndDate;
        private readonly char prorateType;

        public PremiumCalculator(DateTime memberAdditionDate, int memberAge, char memberGender, char prorateType)
        {
            this.memberAdditionDate = memberAdditionDate;
            this.policyEndDate = new DateTime(memberAdditionDate.Year, 12, 31);
            this.memberAge = memberAge;
            this.memberGender = memberGender;
            this.prorateType = prorateType;
            
        }

        private int AgeMultiplier()
        {
            int ageMultiplier = memberAge / 10;
            return (ageMultiplier + 1) * 100;
        }

        private float GenderMultiplier()
        {
            if (memberGender == 'f' && memberAge > 18)
                return ageFactorWomen;
            return 1;
        }

        private double CalculateFullPremium()
        {
            return flatRate * AgeMultiplier() * GenderMultiplier();
        }

        public Tuple<double, double> CalculateProratedPremium()
        {
            if (prorateType == 'd')
            {
                int daysInPolicy = (policyEndDate - memberAdditionDate).Days + 1;
                return Tuple.Create(CalculateFullPremium(), CalculateFullPremium() * daysInPolicy / 365); ;
            }
            else if (prorateType == 'm')
            {
                int monthsInPolicy = (policyEndDate.Year - memberAdditionDate.Year) * 12 + policyEndDate.Month - memberAdditionDate.Month + 1;
                return Tuple.Create(CalculateFullPremium() , CalculateFullPremium() * monthsInPolicy / 12);
            }
            else
            {
                return Tuple.Create(CalculateFullPremium(), 0d);
            }
        }
    }
}
