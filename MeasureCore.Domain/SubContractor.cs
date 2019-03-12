using RandREng.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
    public partial class SubContractor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Address Address { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Pager { get; set; }
        public string SSN { get; set; }
        public Nullable<bool> WorkmansCompInsuranceOK { get; set; }
        public Nullable<System.DateTime> BackgroundChkDateApproved { get; set; }
        public bool BackgroundCheckPassed { get; set; }
        public string Notes { get; set; }

		[Column(TypeName = "Money")]
		public Nullable<decimal> Retainage { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public Nullable<decimal> SavingsRate { get; set; }
		[Column(TypeName = "decimal(18,2)" )]
		public Nullable<double> RetainageRate { get; set; }
        public bool Helper { get; set; }
        public double InsuranceRate { get; set; }
		[Column(TypeName = "Money")]
		public decimal InsuranceDollarAmount { get; set; }
        public string BadgeStatus { get; set; }
        public bool BackgroundRptRequested { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<int> MarketId { get; set; }
        public int Status { get; set; }
        public int StateId { get; set; }
		[Date]
		public Nullable<System.DateTime> WorkmansCompInsuranceDate { get; set; }
		[Date]
		public Nullable<System.DateTime> LiabilityInsuranceDate { get; set; }
        public string PictureFilename { get; set; }
        public Nullable<bool> LiabilityInsuranceOK { get; set; }
        public string QBSubContractorId { get; set; }
    
        public List<Bill> Bills { get; set; }
        public List<BillDetail> BillDetails { get; set; }
        public List<OrderCustom> OrderCustomDetails { get; set; }
    }
}
