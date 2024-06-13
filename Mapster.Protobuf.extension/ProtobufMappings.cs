using Google.Protobuf.WellKnownTypes;

namespace Mapster.Protobuf.extension;

public static class ProtobufMappings
{
    public static void RegisterMappings()
    {
        TypeAdapterConfig.GlobalSettings.Default.IgnoreNullValues(true);
        TypeAdapterConfig<Timestamp?, DateTimeOffset?>.NewConfig().MapWith(src => src == null ? null : src.ToDateTimeOffset());
        TypeAdapterConfig<DateTimeOffset?, Timestamp?>.NewConfig().MapWith(src => src == null ? null : Timestamp.FromDateTimeOffset(src.Value));
        TypeAdapterConfig<Duration?, TimeSpan?>.NewConfig().MapWith(src => src == null ? null : src.ToTimeSpan());
        TypeAdapterConfig<TimeSpan?, Duration?>.NewConfig().MapWith(src => src == null ? null : Duration.FromTimeSpan(src.Value));
        TypeAdapterConfig<DoubleValue?, double?>.NewConfig().MapWith(src => src == null ? null : src.Value);
        TypeAdapterConfig<double?, DoubleValue?>.NewConfig().MapWith(src => src == null ? null : new DoubleValue { Value = src.Value });
        TypeAdapterConfig<FloatValue?, float?>.NewConfig().MapWith(src => src == null ? null : src.Value);
        TypeAdapterConfig<float?, FloatValue?>.NewConfig().MapWith(src => src == null ? null : new FloatValue { Value = src.Value });
        TypeAdapterConfig<Int64Value?, long?>.NewConfig().MapWith(src => src == null ? null : src.Value);
        TypeAdapterConfig<long?, Int64Value?>.NewConfig().MapWith(src => src == null ? null : new Int64Value { Value = src.Value });
        TypeAdapterConfig<Int32Value?, int?>.NewConfig().MapWith(src => src == null ? null : src.Value);
        TypeAdapterConfig<int?, Int32Value?>.NewConfig().MapWith(src => src == null ? null : new Int32Value { Value = src.Value });
        TypeAdapterConfig<BoolValue?, bool?>.NewConfig().MapWith(src => src == null ? null : src.Value);
        TypeAdapterConfig<bool?, BoolValue?>.NewConfig().MapWith(src => src == null ? null : new BoolValue { Value = src.Value });
        TypeAdapterConfig<StringValue, string>.NewConfig().MapWith(src => src.Value);
        TypeAdapterConfig<string, StringValue>.NewConfig().MapWith(src => new StringValue { Value = src });
    }
}
