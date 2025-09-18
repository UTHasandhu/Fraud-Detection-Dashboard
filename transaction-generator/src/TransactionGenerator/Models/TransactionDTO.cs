using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionGenerator.Models
{
    internal class TransactionDTO
    {
        int ClientNum { get; set; }
        string AttritionFlag { get; set; } // "Existing Customer" / "Attrited Customer"
        int CustomerAge { get; set; }
        string Gender { get; set; }
        int DependentCount { get; set; }
        string EducationLevel { get; set; }
        string MaritalStatus { get; set; }
        string IncomeCategory { get; set; }
        string CardCategory { get; set; }
        int MonthsOnBook { get; set; }
        int TotalRelationshipCount { get; set; }
        int MonthsInactive12Mon { get; set; }
        int ContactsCount12Mon { get; set; }
        decimal CreditLimit { get; set; }
        decimal TotalRevolvingBal { get; set; }
        decimal AvgOpenToBuy { get; set; }
        decimal TotalAmtChngQ4Q1 { get; set; }
        decimal TotalTransAmt { get; set; }
        int TotalTransCt { get; set; }
        decimal TotalCtChngQ4Q1 { get; set; }
        decimal AvgUtilizationRatio { get; set; }

        // Keeping these for full schema parity
        decimal NaiveBayesAttrition1 { get; set; }
        decimal NaiveBayesAttrition2 { get; set; }
    }
}
