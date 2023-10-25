using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class LifeInsurance : AInsurancePolicy
    {
        public LifeInsurance(int policyId, string policyName, double premiumAmount,int age):base(policyId,policyName,premiumAmount)
        {
            this.age = age;
        }

        public int age { get; set; }

        public override double CalculatePremium()
        {

            if(age <=10)
            {
                return PremiumAmount * 0.1 + PremiumAmount;

            }
            else if(age <=18) 
            
            {
                return PremiumAmount * 0.2 + PremiumAmount;
                
            }
            else if(age <=60)
            {
                return PremiumAmount * 0.3 + PremiumAmount;
            }
            else
            {
                return PremiumAmount * 0.4 + PremiumAmount;
            }

        }

   }
}
