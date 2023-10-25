using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal abstract class AInsurancePolicy
    {
        protected AInsurancePolicy(int policyId, string policyName, double premiumAmount)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PremiumAmount = premiumAmount;
        }

        public int PolicyId { get; set; }
        public  string PolicyName { get; set; }
        public  double PremiumAmount { get; set; }

        public abstract double CalculatePremium();
        
    }
}
