// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Create protection container input properties.</summary>
    public partial class CreateProtectionContainerInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ICreateProtectionContainerInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ICreateProtectionContainerInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProviderSpecificInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerCreationInput[] _providerSpecificInput;

        /// <summary>Provider specific inputs for container creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerCreationInput[] ProviderSpecificInput { get => this._providerSpecificInput; set => this._providerSpecificInput = value; }

        /// <summary>
        /// Creates an new <see cref="CreateProtectionContainerInputProperties" /> instance.
        /// </summary>
        public CreateProtectionContainerInputProperties()
        {

        }
    }
    /// Create protection container input properties.
    public partial interface ICreateProtectionContainerInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Provider specific inputs for container creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider specific inputs for container creation.",
        SerializedName = @"providerSpecificInput",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerCreationInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerCreationInput[] ProviderSpecificInput { get; set; }

    }
    /// Create protection container input properties.
    internal partial interface ICreateProtectionContainerInputPropertiesInternal

    {
        /// <summary>Provider specific inputs for container creation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerCreationInput[] ProviderSpecificInput { get; set; }

    }
}