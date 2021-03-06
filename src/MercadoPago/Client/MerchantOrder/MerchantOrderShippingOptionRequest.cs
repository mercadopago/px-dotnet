﻿namespace MercadoPago.Client.MerchantOrder
{
    /// <summary>
    /// Shipping options.
    /// </summary>
    public class MerchantOrderShippingOptionRequest
    {
        /// <summary>
        /// Shipping option ID.
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Net cost absorbed by the receiver.
        /// </summary>
        public decimal? Cost { get; set; }

        /// <summary>
        /// Currency ID.
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// Estimated delivery time information.
        /// </summary>
        public MerchantOrderShippingEstimatedDeliveryRequest EstimatedDelivery { get; set; }

        /// <summary>
        /// Net cost of the shipping.
        /// </summary>
        public decimal? ListCost { get; set; }

        /// <summary>
        /// Option name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Shipping method ID.
        /// </summary>
        public long? ShippingMethodId { get; set; }

        /// <summary>
        /// Shipping time information.
        /// </summary>
        public MerchantOrderShippingSpeedRequest Speed { get; set; }
    }
}
