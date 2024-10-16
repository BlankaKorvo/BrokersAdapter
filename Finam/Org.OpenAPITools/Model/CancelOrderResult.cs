/*
 * Trade API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: current
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CancelOrderRequest result.  Результат выполнения CancelOrderRequest.
    /// </summary>
    [DataContract(Name = "CancelOrderResult")]
    public partial class CancelOrderResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResult" /> class.
        /// </summary>
        /// <param name="clientId">Trade Account Id.  Идентификатор торгового счёта..</param>
        /// <param name="transactionId">Transaction Id, which can be used to cancel order or find corresponding order_no in Event service.  Идентификатор транзакции, который может быть использован для отмены заявки или определения номера заявки в сервисе событий..</param>
        public CancelOrderResult(string clientId = default(string), int transactionId = default(int))
        {
            this.ClientId = clientId;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Trade Account Id.  Идентификатор торгового счёта.
        /// </summary>
        /// <value>Trade Account Id.  Идентификатор торгового счёта.</value>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Transaction Id, which can be used to cancel order or find corresponding order_no in Event service.  Идентификатор транзакции, который может быть использован для отмены заявки или определения номера заявки в сервисе событий.
        /// </summary>
        /// <value>Transaction Id, which can be used to cancel order or find corresponding order_no in Event service.  Идентификатор транзакции, который может быть использован для отмены заявки или определения номера заявки в сервисе событий.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public int TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelOrderResult {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
