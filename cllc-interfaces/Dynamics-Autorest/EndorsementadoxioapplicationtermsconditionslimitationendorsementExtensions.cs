// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Endorsementadoxioapplicationtermsconditionslimitationendorsement.
    /// </summary>
    public static partial class EndorsementadoxioapplicationtermsconditionslimitationendorsementExtensions
    {
            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection Get(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection> GetAsync(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitationCollection> GetWithHttpMessages(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation EndorsementByKey(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, string adoxioApplicationtermsconditionslimitationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.EndorsementByKeyAsync(adoxioEndorsementid, adoxioApplicationtermsconditionslimitationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> EndorsementByKeyAsync(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, string adoxioApplicationtermsconditionslimitationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EndorsementByKeyWithHttpMessagesAsync(adoxioEndorsementid, adoxioApplicationtermsconditionslimitationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_endorsement_adoxio_applicationtermsconditionslimitation_Endorsement
            /// from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> EndorsementByKeyWithHttpMessages(this IEndorsementadoxioapplicationtermsconditionslimitationendorsement operations, string adoxioEndorsementid, string adoxioApplicationtermsconditionslimitationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.EndorsementByKeyWithHttpMessagesAsync(adoxioEndorsementid, adoxioApplicationtermsconditionslimitationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
