//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;
using PayPal.Util;
using System;

namespace PayPal.Api
{
    /// <summary>
    /// A sale transaction. This is the resource that is returned as a part related resources in Payment
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Sale : PayPalRelationalObject
    {
        /// <summary>
        /// Identifier of the sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Identifier to the purchase or transaction unit corresponding to this sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_unit_reference_id")]
        public string purchase_unit_reference_id { get; set; }

        /// <summary>
        /// Amount being collected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Amount amount { get; set; }

        /// <summary>
        /// Specifies payment mode of the transaction. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_mode")]
        public string payment_mode { get; set; }

        /// <summary>
        /// your own invoice number or tracking IDs, Maximum length: 127.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoice_number")]
        public string invoice_number { get; set; }

        /// <summary>
        /// free-form field for the use of clients, Maximum length: 127.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "custom")]
        public string custom { get; set; }

        /// <summary>
        /// State of the sale transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string state { get; set; }

        /// <summary>
        /// Reason code for the transaction state being Pending or Reversed. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string reason_code { get; set; }

        /// <summary>
        /// The level of seller protection in force for the transaction. Only supported when the `payment_method` is set to `paypal`. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility")]
        public string protection_eligibility { get; set; }

        /// <summary>
        /// The kind of seller protection in force for the transaction. It is returned only when protection_eligibility is ELIGIBLE or PARTIALLY_ELIGIBLE. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility_type")]
        public string protection_eligibility_type { get; set; }

        /// <summary>
        /// Expected clearing time for eCheck Transactions. Returned when payment is made with eCheck. Only supported when the `payment_method` is set to `paypal`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clearing_time")]
        public string clearing_time { get; set; }

        /// <summary>
        /// Status of the Recipient Fund. For now, it will be returned only when fund status is held
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_hold_status")]
        public string payment_hold_status { get; set; }

        /// <summary>
        /// Reasons for PayPal holding recipient fund. It is set only if payment hold status is held
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_hold_reasons")]
        public List<string> payment_hold_reasons { get; set; }

        /// <summary>
        /// Indicates the credit status of fund to the recipient. It will be returned only when payment status is 'completed'
        /// </summary>
        [Obsolete("Unused")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_fund_status")]
        public string recipient_fund_status { get; set; }

        /// <summary>
        /// Reason for holding the funds.
        /// </summary>
        [Obsolete("Unused")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hold_reason")]
        public string hold_reason { get; set; }

        /// <summary>
        /// Transaction fee applicable for this payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transaction_fee")]
        public Currency transaction_fee { get; set; }

        /// <summary>
        /// Net amount the merchant receives for this transaction in their receivable currency. Returned only in cross-currency use cases where a merchant bills a buyer in a non-primary currency for that buyer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivable_amount")]
        public Currency receivable_amount { get; set; }

        /// <summary>
        /// Exchange rate applied for this transaction. Returned only in cross-currency use cases where a merchant bills a buyer in a non-primary currency for that buyer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchange_rate")]
        public string exchange_rate { get; set; }

        /// <summary>
        /// Fraud Management Filter (FMF) details applied for the payment that could result in accept, deny, or pending action. Returned in a payment response only if the merchant has enabled FMF in the profile settings and one of the fraud filters was triggered based on those settings. See [Fraud Management Filters Summary](/docs/classic/fmf/integration-guide/FMFSummary/) for more information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fmf_details")]
        public FmfDetails fmf_details { get; set; }

        /// <summary>
        /// Receipt id is a payment identification number returned for guest users to identify the payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receipt_id")]
        public string receipt_id { get; set; }

        /// <summary>
        /// ID of the payment resource on which this transaction is based.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent_payment")]
        public string parent_payment { get; set; }

        /// <summary>
        /// Response codes returned by the processor concerning the submitted payment. Only supported when the `payment_method` is set to `credit_card`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processor_response")]
        public ProcessorResponse processor_response { get; set; }

        /// <summary>
        /// ID of the billing agreement used as reference to execute this transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billing_agreement_id")]
        public string billing_agreement_id { get; set; }

        /// <summary>
        /// Time of sale as defined in [RFC 3339 Section 5.6](http://tools.ietf.org/html/rfc3339#section-5.6)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "create_time")]
        public string create_time { get; set; }

        /// <summary>
        /// Time the resource was last updated in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_time")]
        public string update_time { get; set; }

        /// <summary>
        /// Shows details for a sale, by ID. Returns only sales that were created through the REST API.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="saleId">The ID of the sale for which to show details.</param>
        /// <returns>Sale</returns>
        public static Sale Get(APIContext apiContext, string saleId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(saleId, "saleId");

            // Configure and send the request
            var pattern = "v1/payments/sale/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { saleId });
            return PayPalResource.ConfigureAndExecute<Sale>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Creates (and processes) a new Refund Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        [Obsolete("Please use Refund(APIContext, string, RefundRequest) instead")]
        public Refund Refund(APIContext apiContext, Refund refund)
        {
            return Sale.Refund(apiContext, this.id, refund);
        }

        /// <summary>
        /// Creates (and processes) a new Refund Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="saleId">ID of the sale to refund.</param>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        [Obsolete("Please use Refund(APIContext, string, RefundRequest) instead")]
        public static Refund Refund(APIContext apiContext, string saleId, Refund refund)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(saleId, "saleId");
            ArgumentValidator.Validate(refund, "refund");

            // Configure and send the request
            var pattern = "v1/payments/sale/{0}/refund";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { saleId });
            return PayPalResource.ConfigureAndExecute<Refund>(apiContext, HttpMethod.POST, resourcePath, refund.ConvertToJson());
        }

        /// <summary>
        /// Refunds a sale, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an `amount` object in the JSON request body.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="refundRequest">RefundRequest</param>
        /// <returns>DetailedRefund</returns>
        public static DetailedRefund Refund(APIContext apiContext, string saleId, RefundRequest refundRequest)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(saleId, "saleId");
            ArgumentValidator.Validate(refundRequest, "refundRequest");

            // Configure and send the request
            var pattern = "v1/payments/sale/{0}/refund";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { saleId });
            return PayPalResource.ConfigureAndExecute<DetailedRefund>(apiContext, HttpMethod.POST, resourcePath, refundRequest.ConvertToJson());
        }
    }
}
