using System.Net.Http;
using System.Text.Json;

namespace GGroupp.Infra.Dataverse.Api.Test;

internal static partial class ApiClientTestDataSource
{
    private static StringContent CreateResponseContentJson(StubResponseJson responseJson)
        =>
        new(
            JsonSerializer.Serialize(responseJson));
}