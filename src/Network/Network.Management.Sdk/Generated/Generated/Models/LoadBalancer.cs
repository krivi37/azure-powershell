// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// LoadBalancer resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoadBalancer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        public LoadBalancer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="extendedLocation">The extended location of the load
        /// balancer.</param>
        /// <param name="sku">The load balancer SKU.</param>
        /// <param name="frontendIPConfigurations">Object representing the
        /// frontend IPs to be used for the load balancer.</param>
        /// <param name="backendAddressPools">Collection of backend address
        /// pools used by a load balancer.</param>
        /// <param name="loadBalancingRules">Object collection representing the
        /// load balancing rules Gets the provisioning.</param>
        /// <param name="probes">Collection of probe objects used in the load
        /// balancer.</param>
        /// <param name="inboundNatRules">Collection of inbound NAT Rules used
        /// by a load balancer. Defining inbound NAT rules on your load
        /// balancer is mutually exclusive with defining an inbound NAT pool.
        /// Inbound NAT pools are referenced from virtual machine scale sets.
        /// NICs that are associated with individual virtual machines cannot
        /// reference an Inbound NAT pool. They have to reference individual
        /// inbound NAT rules.</param>
        /// <param name="inboundNatPools">Defines an external port range for
        /// inbound NAT to a single backend port on NICs associated with a load
        /// balancer. Inbound NAT rules are created automatically for each NIC
        /// associated with the Load Balancer using an external port from this
        /// range. Defining an Inbound NAT pool on your Load Balancer is
        /// mutually exclusive with defining inbound NAT rules. Inbound NAT
        /// pools are referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// inbound NAT pool. They have to reference individual inbound NAT
        /// rules.</param>
        /// <param name="outboundRules">The outbound rules.</param>
        /// <param name="resourceGuid">The resource GUID property of the load
        /// balancer resource.</param>
        /// <param name="provisioningState">The provisioning state of the load
        /// balancer resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public LoadBalancer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation), LoadBalancerSku sku = default(LoadBalancerSku), IList<FrontendIPConfiguration> frontendIPConfigurations = default(IList<FrontendIPConfiguration>), IList<BackendAddressPool> backendAddressPools = default(IList<BackendAddressPool>), IList<LoadBalancingRule> loadBalancingRules = default(IList<LoadBalancingRule>), IList<Probe> probes = default(IList<Probe>), IList<InboundNatRule> inboundNatRules = default(IList<InboundNatRule>), IList<InboundNatPool> inboundNatPools = default(IList<InboundNatPool>), IList<OutboundRule> outboundRules = default(IList<OutboundRule>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Sku = sku;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            LoadBalancingRules = loadBalancingRules;
            Probes = probes;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the extended location of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets the load balancer SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public LoadBalancerSku Sku { get; set; }

        /// <summary>
        /// Gets or sets object representing the frontend IPs to be used for
        /// the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<FrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets collection of backend address pools used by a load
        /// balancer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<BackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets object collection representing the load balancing
        /// rules Gets the provisioning.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<LoadBalancingRule> LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets collection of probe objects used in the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probes")]
        public IList<Probe> Probes { get; set; }

        /// <summary>
        /// Gets or sets collection of inbound NAT Rules used by a load
        /// balancer. Defining inbound NAT rules on your load balancer is
        /// mutually exclusive with defining an inbound NAT pool. Inbound NAT
        /// pools are referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// Inbound NAT pool. They have to reference individual inbound NAT
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<InboundNatRule> InboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets defines an external port range for inbound NAT to a
        /// single backend port on NICs associated with a load balancer.
        /// Inbound NAT rules are created automatically for each NIC associated
        /// with the Load Balancer using an external port from this range.
        /// Defining an Inbound NAT pool on your Load Balancer is mutually
        /// exclusive with defining inbound NAT rules. Inbound NAT pools are
        /// referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// inbound NAT pool. They have to reference individual inbound NAT
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatPools")]
        public IList<InboundNatPool> InboundNatPools { get; set; }

        /// <summary>
        /// Gets or sets the outbound rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundRules")]
        public IList<OutboundRule> OutboundRules { get; set; }

        /// <summary>
        /// Gets the resource GUID property of the load balancer resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the load balancer resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
