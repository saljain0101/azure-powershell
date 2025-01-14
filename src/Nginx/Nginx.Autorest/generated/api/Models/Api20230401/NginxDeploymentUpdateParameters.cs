// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxDeploymentUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public bool? EnableDiagnosticsSupport { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).EnableDiagnosticsSupport; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).EnableDiagnosticsSupport = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityProperties _identity;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityProperties Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IdentityProperties()); set => this._identity = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).PrincipalId; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).TenantId; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType)""); }

        /// <summary>Dictionary of <UserIdentityProperties></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IdentityProperties()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Logging</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.Logging { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).Logging; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).Logging = value; }

        /// <summary>Internal Acessors for LoggingStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.LoggingStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).LoggingStorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).LoggingStorageAccount = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ScalingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.ScalingProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).ScalingProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).ScalingProperty = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSku Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.ResourceSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for UserProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersInternal.UserProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).UserProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).UserProfile = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public int? ScalingPropertyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).ScalingPropertyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).ScalingPropertyCapacity = value ?? default(int); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSku _sku;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.ResourceSku()); set => this._sku = value; }

        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSkuInternal)Sku).Name = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).StorageAccountContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).StorageAccountContainerName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).StorageAccountName = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersTags _tag;

        /// <summary>Dictionary of <string></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUpdateParametersTags()); set => this._tag = value; }

        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string UserProfilePreferredEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).UserProfilePreferredEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdatePropertiesInternal)Property).UserProfilePreferredEmail = value ?? null; }

        /// <summary>Creates an new <see cref="NginxDeploymentUpdateParameters" /> instance.</summary>
        public NginxDeploymentUpdateParameters()
        {

        }
    }
    public partial interface INginxDeploymentUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDiagnosticsSupport",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDiagnosticsSupport { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType? IdentityType { get; set; }
        /// <summary>Dictionary of <UserIdentityProperties></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <UserIdentityProperties>",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? ScalingPropertyCapacity { get; set; }
        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountContainerName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }
        /// <summary>Dictionary of <string></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dictionary of <string>",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersTags Tag { get; set; }
        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string or a valid email address.",
        SerializedName = @"preferredEmail",
        PossibleTypes = new [] { typeof(string) })]
        string UserProfilePreferredEmail { get; set; }

    }
    internal partial interface INginxDeploymentUpdateParametersInternal

    {
        bool? EnableDiagnosticsSupport { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityProperties Identity { get; set; }

        string IdentityPrincipalId { get; set; }

        string IdentityTenantId { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.IdentityType? IdentityType { get; set; }
        /// <summary>Dictionary of <UserIdentityProperties></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IIdentityPropertiesUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

        string Location { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging Logging { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount LoggingStorageAccount { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateProperties Property { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties ScalingProperty { get; set; }

        int? ScalingPropertyCapacity { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.IResourceSku Sku { get; set; }
        /// <summary>Name of the SKU.</summary>
        string SkuName { get; set; }

        string StorageAccountContainerName { get; set; }

        string StorageAccountName { get; set; }
        /// <summary>Dictionary of <string></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUpdateParametersTags Tag { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile UserProfile { get; set; }
        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        string UserProfilePreferredEmail { get; set; }

    }
}