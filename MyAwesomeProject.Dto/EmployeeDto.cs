using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject.Dto
{
	public class EmployeeDto
	{	
		
		[Required]
		public string EmployeeName { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string TitleOfCourtesy { get; set; }
		[Required]
		public DateTime BirthDate { get; set; }
		[Required]
		public DateTime HireDate { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Region { get; set; }
		[Required]
		public string PostalCode { get; set; }
		[Required]
		public string Country { get; set; }
		[Required]
		public string HomePhone { get; set; }
		[Required]
		public string Extension { get; set; }
		[Required]
		public string PhotoUrl { get; set; }
		[Required]
		public string Notes { get; set; }
		[Required]
		public IEnumerable<EmployeeTerritoryDto> EmployeeTerritories { get; set; }
		
	}
}
