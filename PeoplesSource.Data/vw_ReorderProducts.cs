//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeoplesSource.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_ReorderProducts
    {
        public string SKU { get; set; }
        public Nullable<System.DateTime> Date_Last_Sale { get; set; }
        public Nullable<System.DateTime> Date_product_was_last_stocked { get; set; }
        public string Quantity_on_Hand { get; set; }
        public int Total_Number_of_Units_Sold_between_Last_Stock_and_Last_sale_date { get; set; }
        public Nullable<int> TotalNumberOfUnitsSoldInPast30Days { get; set; }
        public Nullable<decimal> DailyUnitsSoldRateForPast30Days { get; set; }
        public string Product_Title { get; set; }
        public int TotalNumberOfDaysFromLastStockToLastSaleDate { get; set; }
        public Nullable<decimal> DailyUnitsSoldRateFromLastRestockToLastSaleDate { get; set; }
    }
}