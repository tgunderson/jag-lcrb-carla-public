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
    /// Extension methods for Sepdrinksalesforecastasyncoperations.
    /// </summary>
    public static partial class SepdrinksalesforecastasyncoperationsExtensions
    {
            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
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
            public static MicrosoftDynamicsCRMasyncoperationCollection Get(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioSepdrinksalesforecastid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
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
            public static async Task<MicrosoftDynamicsCRMasyncoperationCollection> GetAsync(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioSepdrinksalesforecastid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMasyncoperationCollection> GetWithHttpMessages(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioSepdrinksalesforecastid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMasyncoperation AsyncOperationsByKey(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.AsyncOperationsByKeyAsync(adoxioSepdrinksalesforecastid, asyncoperationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
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
            public static async Task<MicrosoftDynamicsCRMasyncoperation> AsyncOperationsByKeyAsync(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AsyncOperationsByKeyWithHttpMessagesAsync(adoxioSepdrinksalesforecastid, asyncoperationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_sepdrinksalesforecast_AsyncOperations from
            /// adoxio_sepdrinksalesforecasts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSepdrinksalesforecastid'>
            /// key: adoxio_sepdrinksalesforecastid of adoxio_sepdrinksalesforecast
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMasyncoperation> AsyncOperationsByKeyWithHttpMessages(this ISepdrinksalesforecastasyncoperations operations, string adoxioSepdrinksalesforecastid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AsyncOperationsByKeyWithHttpMessagesAsync(adoxioSepdrinksalesforecastid, asyncoperationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
