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
    /// Collection of adoxio_businessaccount
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_businessaccountCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioBusinessaccountCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioBusinessaccountCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioBusinessaccountCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioBusinessaccountCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioBusinessaccountCollection(IList<MicrosoftDynamicsCRMadoxioBusinessaccount> value = default(IList<MicrosoftDynamicsCRMadoxioBusinessaccount>))
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
        public IList<MicrosoftDynamicsCRMadoxioBusinessaccount> Value { get; set; }

    }
}
