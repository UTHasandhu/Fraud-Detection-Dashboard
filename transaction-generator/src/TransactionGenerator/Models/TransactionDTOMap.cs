using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace TransactionGenerator.Models
{
    class TransactionDTOMap : ClassMap<TransactionDTO>
    {
        TransactionDTOMap()
        {
            Map(m => m.ClientNum).Name("CLIENTNUM");
            Map(m => m.AttritionFlag).Name("Attrition_Flag");
            Map(m => m.CustomerAge).Name("Customer_Age");
            Map(m => m.Gender).Name("Gender");
            Map(m => m.DependentCount).Name("Dependent_count");
            Map(m => m.EducationLevel).Name("Education_Level");
            Map(m => m.MaritalStatus).Name("Marital_Status");
            Map(m => m.IncomeCategory).Name("Income_Category");
            Map(m => m.CardCategory).Name("Card_Category");
            Map(m => m.MonthsOnBook).Name("Months_on_book");
            Map(m => m.TotalRelationshipCount).Name("Total_Relationship_Count");
            Map(m => m.MonthsInactive12Mon).Name("Months_Inactive_12_mon");
            Map(m => m.ContactsCount12Mon).Name("Contacts_Count_12_mon");
            Map(m => m.CreditLimit).Name("Credit_Limit");
            Map(m => m.TotalRevolvingBal).Name("Total_Revolving_Bal");
            Map(m => m.AvgOpenToBuy).Name("Avg_Open_To_Buy");
            Map(m => m.TotalAmtChngQ4Q1).Name("Total_Amt_Chng_Q4_Q1");
            Map(m => m.TotalTransAmt).Name("Total_Trans_Amt");
            Map(m => m.TotalTransCt).Name("Total_Trans_Ct");
            Map(m => m.TotalCtChngQ4Q1).Name("Total_Ct_Chng_Q4_Q1");
            Map(m => m.AvgUtilizationRatio).Name("Avg_Utilization_Ratio");
            Map(m => m.NaiveBayesAttrition1).Name("Naive_Bayes_Classifier_Attrition_Flag_1");
            Map(m => m.NaiveBayesAttrition2).Name("Naive_Bayes_Classifier_Attrition_Flag_0");
        }
    }
}