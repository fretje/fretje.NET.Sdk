using System.Text.Json.Serialization;

namespace fretje.Sdk.Tests.Helpers;

internal sealed class SarifFileRun
{
    [JsonPropertyName("results")]
    public SarifFileRunResult[] Results { get; set; }
}
