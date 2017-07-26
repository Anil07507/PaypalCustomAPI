//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using PayPal.Util;

namespace PayPal.Api
{
    /// <summary>
    /// A list of events.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class WebhookEventType : PayPalResource
    {
        /// <summary>
        /// The unique event name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string name { get; set; }

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description")]
        public string description { get; set; }

        /// <summary>
        /// The status of a webhook event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string status { get; set; }

        /// <summary>
        /// Lists event subscriptions for a webhook, by ID.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="webhookId">The ID of the webhook for which to list subscriptions.</param>
        /// <returns>WebhookEventTypeList</returns>
        public static WebhookEventTypeList SubscribedEventTypes(APIContext apiContext, string webhookId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(webhookId, "webhookId");

            // Configure and send the request
            var pattern = "v1/notifications/webhooks/{0}/event-types";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { webhookId });
            return PayPalResource.ConfigureAndExecute<WebhookEventTypeList>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Lists available events to which any webhook can subscribe. For a list of supported events, see [Webhook events](/docs/integration/direct/rest/webhooks/webhook-events/).
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>WebhookEventTypeList</returns>
        public static WebhookEventTypeList AvailableEventTypes(APIContext apiContext)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);

            // Configure and send the request
            var resourcePath = "v1/notifications/webhooks-event-types";
            return PayPalResource.ConfigureAndExecute<WebhookEventTypeList>(apiContext, HttpMethod.GET, resourcePath);
        }
    }
}
