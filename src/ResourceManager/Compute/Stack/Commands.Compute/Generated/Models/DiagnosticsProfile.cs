// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a diagnostics profile.
    /// </summary>
    public partial class DiagnosticsProfile
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsProfile class.
        /// </summary>
        public DiagnosticsProfile() { }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsProfile class.
        /// </summary>
        public DiagnosticsProfile(BootDiagnostics bootDiagnostics = default(BootDiagnostics))
        {
            BootDiagnostics = bootDiagnostics;
        }

        /// <summary>
        /// Gets or sets the boot diagnostics.
        /// </summary>
        [JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnostics BootDiagnostics { get; set; }

    }
}