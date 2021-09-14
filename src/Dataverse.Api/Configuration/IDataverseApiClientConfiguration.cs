namespace GGroupp.Infra;

public interface IDataverseApiClientConfiguration
{
    string ServiceUrl { get; }

    string ApiVersion { get; }

    string AuthTenantId { get; }

    string AuthClientId { get; }

    string AuthClientSecret { get; }
}