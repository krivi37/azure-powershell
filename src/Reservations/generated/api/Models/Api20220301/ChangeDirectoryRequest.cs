// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class ChangeDirectoryRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IChangeDirectoryRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IChangeDirectoryRequestInternal
    {

        /// <summary>Backing field for <see cref="DestinationTenantId" /> property.</summary>
        private string _destinationTenantId;

        /// <summary>Tenant id GUID that reservation order is to be transferred to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string DestinationTenantId { get => this._destinationTenantId; set => this._destinationTenantId = value; }

        /// <summary>Creates an new <see cref="ChangeDirectoryRequest" /> instance.</summary>
        public ChangeDirectoryRequest()
        {

        }
    }
    public partial interface IChangeDirectoryRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Tenant id GUID that reservation order is to be transferred to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant id GUID that reservation order is to be transferred to",
        SerializedName = @"destinationTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationTenantId { get; set; }

    }
    internal partial interface IChangeDirectoryRequestInternal

    {
        /// <summary>Tenant id GUID that reservation order is to be transferred to</summary>
        string DestinationTenantId { get; set; }

    }
}