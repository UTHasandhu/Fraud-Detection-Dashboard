using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionGenerator.Models
{
    public class TransactionDTO
    {
        public int ClientNum { get; set; }
        public string AttritionFlag { get; set; } // "Existing Customer" / "Attrited Customer"
        public int CustomerAge { get; set; }
        public string Gender { get; set; }
        public int DependentCount { get; set; }
        public string EducationLevel { get; set; }
        public string MaritalStatus { get; set; }
        public  string IncomeCategory { get; set; }
        public string CardCategory { get; set; }
        public int MonthsOnBook { get; set; }
        public int TotalRelationshipCount { get; set; }
        public int MonthsInactive12Mon { get; set; }
        public int ContactsCount12Mon { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal TotalRevolvingBal { get; set; }
        public decimal AvgOpenToBuy { get; set; }
        public decimal TotalAmtChngQ4Q1 { get; set; }
        public decimal TotalTransAmt { get; set; }
        public int TotalTransCt { get; set; }
        public decimal TotalCtChngQ4Q1 { get; set; }
        public decimal AvgUtilizationRatio { get; set; }

        // Keeping these for full schema parity
        public decimal NaiveBayesAttrition1 { get; set; }
        public decimal NaiveBayesAttrition2 { get; set; }
    }
}
