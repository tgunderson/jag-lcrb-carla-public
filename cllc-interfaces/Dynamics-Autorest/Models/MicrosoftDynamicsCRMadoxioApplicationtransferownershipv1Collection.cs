// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of adoxio_applicationtransferownershipv1
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_applicationtransferownershipv1Collection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1Collection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1Collection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1Collection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1Collection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1Collection(IList<MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1> value = default(IList<MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtransferownershipv1> Value { get; set; }

    }
}
