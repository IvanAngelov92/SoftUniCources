using System;
using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
	public class Customer
	{
		private List<Order> _orderHistory = new();
		public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();
		public string Name { get; set; }
		public string Email { get; set; }

		public Customer (string name, string email)
		{
            Name = name;
			Email = email;

		}

		public void AddOrder (Order order)
		{
			_orderHistory.Add(order);

        }

	}
}

