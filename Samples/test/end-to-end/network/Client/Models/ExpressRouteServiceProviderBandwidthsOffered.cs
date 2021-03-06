// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains bandwidths offered in ExpressRouteServiceProvider resources.
    /// </summary>
    public partial class ExpressRouteServiceProviderBandwidthsOffered
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteServiceProviderBandwidthsOffered class.
        /// </summary>
        public ExpressRouteServiceProviderBandwidthsOffered()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteServiceProviderBandwidthsOffered class.
        /// </summary>
        /// <param name="offerName">The OfferName.</param>
        /// <param name="valueInMbps">The ValueInMbps.</param>
        public ExpressRouteServiceProviderBandwidthsOffered(string offerName = default(string), int? valueInMbps = default(int?))
        {
            OfferName = offerName;
            ValueInMbps = valueInMbps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OfferName.
        /// </summary>
        [JsonProperty(PropertyName = "offerName")]
        public string OfferName { get; set; }

        /// <summary>
        /// Gets or sets the ValueInMbps.
        /// </summary>
        [JsonProperty(PropertyName = "valueInMbps")]
        public int? ValueInMbps { get; set; }

    }
}
