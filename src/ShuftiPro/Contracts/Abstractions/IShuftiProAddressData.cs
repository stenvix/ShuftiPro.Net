using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    internal interface IShuftiProAddressData : IShuftiProAddressBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProNameData Name { get; set; }

        [JsonProperty("selected_type")]
        ShuftiProAddressType[] SelectedTypes { get; set; }
    }
}
