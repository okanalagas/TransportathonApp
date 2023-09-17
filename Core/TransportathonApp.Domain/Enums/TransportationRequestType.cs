using System.ComponentModel;

namespace TransportathonApp.Domain.Enums;

public enum TransportationRequestType
{
    [Description("Evden Eve Taşıma")]
    HouseToHouse,
    [Description("Ofis Taşıma")]
    Office,
    [Description("Ağır Yük Taşıma")]
    LargeVolume
}
