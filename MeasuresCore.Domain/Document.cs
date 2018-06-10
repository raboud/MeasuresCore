using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandREng.MeasuresCore.Domain
{
	public class Document
    {
		public Document()
		{
			this.OrdersDocuments = new List<OrderDocument>();
		}

		public int Id { get; set; }
        public string Description { get; set; }
        public string PathAndFilename { get; set; }

		public List<OrderDocument> OrdersDocuments { get; set; }
		//[NotMapped]
		//public List<OrderSOMerchandiseDetail> OrderSOMerchandiseDetails { get; set; }
		//[NotMapped]
		//public List<WorkOrder> WorkOrders { get; set; }
	}
}
