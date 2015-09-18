using System;

namespace Exercice4
{
	public class PaymentService
	{
		private IUSerService _userService;
		private IGatewayService _gatewayService;

		public PaymentService(
			IUSerService userService, 
			IGatewayService gatewayService)
		{
			_userService = userService;
			_gatewayService = gatewayService;
		}

		public void processPayment(
			User user,
			PaymentDetails paymentDetails)
		{
			if (!_userService.IsValid(user))
			{
				throw new InvalidUserException();
			}
			_gatewayService.sendPayement(paymentDetails);
		}
	}
}