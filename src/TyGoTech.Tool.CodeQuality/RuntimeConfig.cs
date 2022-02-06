namespace TyGoTech.Tool.CodeQuality;

using System.Text.Json.Serialization;

#pragma warning disable CA1822, CA2227
public class RuntimeConfig
{
    [JsonPropertyName("$schema")]
    public Uri Schema => Constants.RuntimeConfigSchemaUri;

    public Uri? ResourcesUri { get; set; }

    public IList<ResourceMap> FileMaps { get; set; } = new List<ResourceMap>();

    public void EnsureValid()
    {
        foreach (var map in this.FileMaps)
        {
            map.EnsureValid();
        }
    }
}