using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RandREng.MeasuresCore.Domain
{
    
    public partial class Branch
    {
        public Branch()
        {
        }
    
        public int Id { get; set; }
		[Display(Name = "Branch Name", Prompt = "Branch Name")]
		public string Name { get; set; }

		[Display(Name = "Printer Name", Prompt = "Printer Name")]
		public string PrinterName { get; set; }

		[Display(Name = "Printer Port", Prompt = "Printer Port")]
		public string PrinterPort { get; set; }

		[Display(Name = "Printer Driver", Prompt = "Printer Driver")]
		public string PrinterDriver { get; set; }

		public Address Address { get; set; }

		[Phone]
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ManagerId { get; set; }
        public bool Active { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string LabelPrinter { get; set; }
    }
}
