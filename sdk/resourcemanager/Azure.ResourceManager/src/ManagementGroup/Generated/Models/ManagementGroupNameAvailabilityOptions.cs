// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Management group name availability check parameters. </summary>
    public partial class ManagementGroupNameAvailabilityOptions
    {
        /// <summary> Initializes a new instance of ManagementGroupNameAvailabilityOptions. </summary>
        public ManagementGroupNameAvailabilityOptions()
        {
            ResourceType = "Microsoft.Management/managementGroups";
        }

        /// <summary> the name to check for availability. </summary>
        public string Name { get; set; }
        /// <summary> fully qualified resource type which includes provider namespace. </summary>
        public string ResourceType { get; set; }
    }
}
