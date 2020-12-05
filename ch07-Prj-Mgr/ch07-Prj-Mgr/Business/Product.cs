using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_Prj_Mgr.Business
{
	class Product
	{
		public String code { get; set; }
		public string description { get; set; }
		public double price { get; set; }
		public Product()
		{

		}
		public Product(string code, string description, double price)
		{
			this.code = code;
			this.description = description;
			this.price = price;

		}
		/*public override string ToString()
		{
			return "Product:  code = " +code+", description = "+ description+ "+price = " + price+; ;
		}
		*/
		//Using string interpolation
		public override string ToString()
		{
			return $"Product:  code = {code} , description {description} price = {price }";
		}
	}
}
