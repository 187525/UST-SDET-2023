using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(int policyId, string policyName, double premiumAmount)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PremiumAmount = premiumAmount;
        }

        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public double PremiumAmount { get; set; }

        public void RenewPolicy(double newPremium) 
        {
            PremiumAmount = newPremium;
            Console.WriteLine($"The new premium amount:" + PremiumAmount );
        
        }

        public void RenewPolicy()
        {
            PremiumAmount = PremiumAmount * 0.1 + PremiumAmount;
            Console.WriteLine("The Premium Amount is:"+PremiumAmount );

        }


    }
}
