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
    /// Invoice search parameters.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Search : PayPalSerializableObject
    {
        /// <summary>
        /// The initial letters of the email address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }

        /// <summary>
        /// The initial letters of the recipient first name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_first_name")]
        public string recipient_first_name { get; set; }

        /// <summary>
        /// The initial letters of the recipient last name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_last_name")]
        public string recipient_last_name { get; set; }

        /// <summary>
        /// The initial letters of the recipient business name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_business_name")]
        public string recipient_business_name { get; set; }

        /// <summary>
        /// The invoice number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number")]
        public string number { get; set; }

        /// <summary>
        /// The invoice status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string status { get; set; }

        /// <summary>
        /// The lower limit of the total amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lower_total_amount")]
        public Currency lower_total_amount { get; set; }

        /// <summary>
        /// The upper limit of total amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upper_total_amount")]
        public Currency upper_total_amount { get; set; }

        /// <summary>
        /// The start date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_invoice_date")]
        public string start_invoice_date { get; set; }

        /// <summary>
        /// The end date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_invoice_date")]
        public string end_invoice_date { get; set; }

        /// <summary>
        /// The start due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_due_date")]
        public string start_due_date { get; set; }

        /// <summary>
        /// The end due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_due_date")]
        public string end_due_date { get; set; }

        /// <summary>
        /// The start payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_payment_date")]
        public string start_payment_date { get; set; }

        /// <summary>
        /// The end payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_payment_date")]
        public string end_payment_date { get; set; }

        /// <summary>
        /// The start creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_creation_date")]
        public string start_creation_date { get; set; }

        /// <summary>
        /// The end creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_creation_date")]
        public string end_creation_date { get; set; }

        /// <summary>
        /// The offset for the search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "page")]
        public float page { get; set; }

        /// <summary>
        /// The page size for the search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "page_size")]
        public float page_size { get; set; }

        /// <summary>
        /// Indicates whether the total count appears in the response. Default is `false`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_count_required")]
        public bool? total_count_required { get; set; }

        /// <summary>
        /// Indicates whether to list merchant-archived invoices in the response. If `true`, response lists only merchant-archived invoices. If `false`, response lists only unarchived invoices. If `null`, response lists all invoices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "archived")]
        public bool? archived { get; set; }
    }
}
