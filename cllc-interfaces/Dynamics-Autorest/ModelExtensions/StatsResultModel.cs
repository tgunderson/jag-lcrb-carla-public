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
    /// Collection of abs_scheduledprocesses
    /// </summary>
    public partial class StatsResultModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StatsResultModel class.
        /// </summary>
        public StatsResultModel()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        public string adoxio_name { get; set; }
        public string adoxio_establishmentpropsedname { get; set; }
        public string adoxio_establishmentaddressstreet { get; set; }
        public string adoxio_establishmentaddresspostalcode { get; set; }
        public string adoxio_establishmentaddresscity { get; set; }
        public string adoxio_applicationid { get; set; }
        public string commregion { get; set; }
    }


    public partial class StatsResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AbsscheduledprocessesGetResponseModel class.
        /// </summary>
        public StatsResultResponse()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public List<Dictionary<string, string>> Value { get; set; }
    }
}
