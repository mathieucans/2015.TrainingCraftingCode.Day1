using System;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercice4
{
	[TestClass]
	public class PaymentServiceShould
	{
		private IUSerService _userService;
		private IGatewayService _gatewayService;
		private PaymentService _paymentService;

		[TestInitialize]
		public void Setup()
		{
			_userService = A.Fake<IUSerService>();
			_gatewayService = A.Fake<IGatewayService>();
			_paymentService = new PaymentService(_userService, _gatewayService);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void ThrowAnExceptionIfUserIsNotValid()
		{
			var user = GivenUser(false);

			// WHEN
			_paymentService.processPayment(user, new PaymentDetails());
		}

		[TestMethod]
		public void SendPayementToTheGateway()
		{
			var user = GivenUser(true);
			var payment = new PaymentDetails();

			// WHEN
			_paymentService.processPayment(user, payment);

			// THEN
			A.CallTo(() => _gatewayService.sendPayement(payment)).MustHaveHappened(Repeated.Exactly.Once);
		}
		
		private User GivenUser(bool valid)
		{
			var user = new User();
			A.CallTo(() => _userService.IsValid(user)).Returns(valid);
			return user;
		}


	}
}
