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
    /// Extension methods for Eventaddressbulkdeletefailures.
    /// </summary>
    public static partial class EventaddressbulkdeletefailuresExtensions
    {
            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
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
            public static MicrosoftDynamicsCRMbulkdeletefailureCollection Get(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioEventaddressid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailureCollection> GetAsync(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioEventaddressid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMbulkdeletefailureCollection> GetWithHttpMessages(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioEventaddressid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbulkdeletefailure BulkDeleteFailuresByKey(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.BulkDeleteFailuresByKeyAsync(adoxioEventaddressid, bulkdeletefailureid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteFailuresByKeyAsync(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkDeleteFailuresByKeyWithHttpMessagesAsync(adoxioEventaddressid, bulkdeletefailureid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_eventaddress_BulkDeleteFailures from adoxio_eventaddresses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEventaddressid'>
            /// key: adoxio_eventaddressid of adoxio_eventaddress
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteFailuresByKeyWithHttpMessages(this IEventaddressbulkdeletefailures operations, string adoxioEventaddressid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.BulkDeleteFailuresByKeyWithHttpMessagesAsync(adoxioEventaddressid, bulkdeletefailureid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}