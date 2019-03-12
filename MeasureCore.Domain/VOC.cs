using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class VOC
    {
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<short> Pvendor_Nbr { get; set; }
        public string Pvendor_Name { get; set; }
        public Nullable<short> Project_Code { get; set; }
        public string Project_Name { get; set; }
        public Nullable<System.DateTime> Survey_Date { get; set; }
        public Nullable<System.DateTime> Key_Rec_Date { get; set; }
        public Nullable<int> Mvendor_Nbr { get; set; }
        public string Mvendor_Name { get; set; }
        public Nullable<short> Store_Nbr { get; set; }
        public Nullable<int> PO_Nbr { get; set; }
        public Nullable<short> Overall_Sat { get; set; }
        public Nullable<short> Referral { get; set; }
        public Nullable<short> Loyalty { get; set; }
        public Nullable<short> Shopping_Overall { get; set; }
        public Nullable<short> Measure_Consult_Overall { get; set; }
        public Nullable<short> Product_Overall { get; set; }
        public Nullable<short> Value_Overall { get; set; }
        public Nullable<short> Installer_Overall { get; set; }
        public Nullable<short> Installer_On_Time { get; set; }
        public Nullable<short> Installer_Courtesy { get; set; }
        public Nullable<short> Installer_Care { get; set; }
        public Nullable<short> Installer_Appearance { get; set; }
        public Nullable<short> Installer_Cleanup { get; set; }
        public Nullable<short> Installer_Review_Project { get; set; }
        public Nullable<short> Installer_Complete_On_Time { get; set; }
        public Nullable<short> Installer_Informing { get; set; }
        public string Installer_Other_Comments { get; set; }
        public Nullable<float> Installer_Attributes_Aggregated { get; set; }
        public Nullable<short> Workmanship_Overall { get; set; }
        public Nullable<short> Communication_Overall { get; set; }
        public Nullable<short> Complete_Within_Timeframe { get; set; }
        public Nullable<short> After_Sales_Svc_Overall { get; set; }
        public Nullable<short> Issue_Occurred { get; set; }
        public Nullable<short> Issue_Workmanship { get; set; }
        public Nullable<short> Issue_Material_Quality { get; set; }
        public Nullable<short> Issue_Property_Damage { get; set; }
        public Nullable<short> Issue_Installer_Professionalism { get; set; }
        public Nullable<short> Issue_Store_Support { get; set; }
        public Nullable<short> Issue_Damaged_Product { get; set; }
        public Nullable<short> Issue_Incorrect_Measurement { get; set; }
        public Nullable<short> Issue_Customer_Service { get; set; }
        public Nullable<short> Issue_Communication { get; set; }
        public Nullable<short> Issue_Completion_Time { get; set; }
        public string Issue_Other { get; set; }
        public Nullable<short> Issue_Resolved { get; set; }
        public Nullable<short> Issue_Handling_Overall { get; set; }
        public string Final_Comments { get; set; }
        public string General_Comment { get; set; }
        public Nullable<short> Intrvw_Fiscal_Week { get; set; }
        public Nullable<short> Intrvw_Fiscal_Month { get; set; }
        public Nullable<short> Intrvw_Fiscal_Quarter { get; set; }
        public Nullable<short> Intrvw_Fiscal_Year { get; set; }
        public string Division_Name { get; set; }
        public string Region_Name { get; set; }
        public Nullable<short> Department_Nbr { get; set; }
        public Nullable<short> Class_Nbr { get; set; }
        public Nullable<short> Subclass_Nbr { get; set; }
        public Nullable<long> Reference_Nbr { get; set; }
        public Nullable<short> Correct_Project { get; set; }
        public Nullable<short> Market_Nbr { get; set; }
        public string Market_Name { get; set; }
        public Nullable<int> SKU { get; set; }
    
        public Order Order { get; set; }
    }
}
