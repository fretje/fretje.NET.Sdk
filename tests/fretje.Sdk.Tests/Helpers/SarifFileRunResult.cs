using System.Text.Json;
using System.Text.Json.Serialization;

namespace fretje.Sdk.Tests.Helpers;

internal sealed class SarifFileRunResult
{
    [JsonPropertyName("ruleId")]
    public string RuleId { get; set; }

    [JsonPropertyName("level")]
    public string Level { get; set; }

    [JsonPropertyName("message")]
    public SarifFileRunResultMessage Message { get; set; }

    [JsonPropertyName("suppressions")]
    public JsonElement[] Suppressions { get; set; }

    public bool IsSuppressed => Suppressions is { Length: > 0 };

    public override string ToString()
    {
        return $"{Level}:{RuleId} {Message}";
    }
}
