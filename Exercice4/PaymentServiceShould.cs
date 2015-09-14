using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercice4
{
	[TestClass]
	public class PaymentServiceShould
	{
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void ThrowAnExceptionIfUserIsNotValid()
		{
			var paymentService = new PaymentService();
			var user = new User();
			

			// WHEN
			paymentService.processPayment(user, new PaymentDetails());
		}
	}
}
