// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>List of Spacecraft Resource Properties.</summary>
    public partial class SpacecraftsProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json ? new SpacecraftsProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject into a new instance of <see cref="SpacecraftsProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SpacecraftsProperties(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_noradId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("noradId"), out var __jsonNoradId) ? (string)__jsonNoradId : (string)NoradId;}
            {_titleLine = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("titleLine"), out var __jsonTitleLine) ? (string)__jsonTitleLine : (string)TitleLine;}
            {_tleLine1 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("tleLine1"), out var __jsonTleLine1) ? (string)__jsonTleLine1 : (string)TleLine1;}
            {_tleLine2 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString>("tleLine2"), out var __jsonTleLine2) ? (string)__jsonTleLine2 : (string)TleLine2;}
            {_link = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonArray>("links"), out var __jsonLinks) ? If( __jsonLinks as Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink) (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftLink.FromJson(__u) )) ))() : null : Link;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SpacecraftsProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SpacecraftsProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._noradId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._noradId.ToString()) : null, "noradId" ,container.Add );
            AddIf( null != (((object)this._titleLine)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._titleLine.ToString()) : null, "titleLine" ,container.Add );
            AddIf( null != (((object)this._tleLine1)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._tleLine1.ToString()) : null, "tleLine1" ,container.Add );
            AddIf( null != (((object)this._tleLine2)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonString(this._tleLine2.ToString()) : null, "tleLine2" ,container.Add );
            if (null != this._link)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.XNodeArray();
                foreach( var __x in this._link )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("links",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}