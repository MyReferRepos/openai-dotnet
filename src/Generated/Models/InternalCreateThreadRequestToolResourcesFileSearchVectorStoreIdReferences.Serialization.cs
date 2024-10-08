// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences : IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>
    {
        void IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("vector_store_ids") != true && Optional.IsCollectionDefined(VectorStoreIds))
            {
                writer.WritePropertyName("vector_store_ids"u8);
                writer.WriteStartArray();
                foreach (var item in VectorStoreIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences IJsonModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement, options);
        }

        internal static InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences DeserializeInternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> vectorStoreIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vector_store_ids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorStoreIds = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(vectorStoreIds ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateThreadRequestToolResourcesFileSearchVectorStoreIdReferences(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
