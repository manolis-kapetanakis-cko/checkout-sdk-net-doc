﻿namespace Checkout.Payments
{
    /// <summary>
    /// Represents a customer in a payment response.
    /// </summary>
    public class CustomerResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the customer. This can be specified in a <see cref="CustomerSource"/> 
        /// in subsequent payment requests to use the customer's default payment method.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the customer email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the customer full name.
        /// </summary>
        public string Name { get; set; }
    }
}
