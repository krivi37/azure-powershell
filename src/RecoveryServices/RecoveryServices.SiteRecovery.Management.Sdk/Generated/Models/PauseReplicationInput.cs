// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Pause replication input.
    /// </summary>
    public partial class PauseReplicationInput
    {
        /// <summary>
        /// Initializes a new instance of the PauseReplicationInput class.
        /// </summary>
        public PauseReplicationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PauseReplicationInput class.
        /// </summary>
        /// <param name="properties">Pause replication input
        /// properties.</param>
        public PauseReplicationInput(PauseReplicationInputProperties properties)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pause replication input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PauseReplicationInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
