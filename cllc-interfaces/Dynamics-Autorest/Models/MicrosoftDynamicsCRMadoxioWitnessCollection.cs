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
    /// Collection of adoxio_witness
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_witnessCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioWitnessCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioWitnessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWitnessCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioWitnessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWitnessCollection(IList<MicrosoftDynamicsCRMadoxioWitness> value = default(IList<MicrosoftDynamicsCRMadoxioWitness>))
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
        public IList<MicrosoftDynamicsCRMadoxioWitness> Value { get; set; }

    }
}
