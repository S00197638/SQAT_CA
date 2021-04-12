using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fitnesse.fixtures;
using InsurancePremiums;

namespace InsurancePremiumsFixture
{
    public class CaFitFixture : fit.ColumnFixture
    {
        public int age;
        public string gender;

        public float calcPremium()
        {
            InsuranceService service = new InsuranceService();
            return service.CalcPremium(age, gender);
        }
    }
}
