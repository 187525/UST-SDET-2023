using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CarInsurance:AInsurancePolicy
    {
        public CarInsurance(int policyId, string policyName, double premiumAmount,string? cartype) : base(policyId, policyName, premiumAmount)
        {
        }

        public string? CarType { get; set; }

        public override double CalculatePremium()
        {
            if(CarType=="petrol")
            {
                return PremiumAmount * 0.1 + PremiumAmount;

            }
            else if(CarType=="diesel")
            {
                return PremiumAmount*0.2+PremiumAmount;

            }
            else if(CarType=="electrical")
            {
                return PremiumAmount * 0.5 + PremiumAmount;
            }
            else { return PremiumAmount *0.6 + PremiumAmount; }
        }
    }
}
