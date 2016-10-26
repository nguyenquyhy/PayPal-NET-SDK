//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Base object for all financial value related fields (balance, payment due, etc.)
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Currency : PayPalSerializableObject
    {
        /// <summary>
        /// 3 letter currency code as defined by ISO 4217.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string currency { get; set; }

        /// <summary>
        /// amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value")]
        public string value { get; set; }
    }
}