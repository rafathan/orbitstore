//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrbitStore.Web.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrganizationIdentityDirectory
    {
        public int OrganizationId { get; set; }
        public string OrganizationPath { get; set; }
        public string OrganizationName { get; set; }
        public bool OrganizationActive { get; set; }
        public int IdentityId { get; set; }
        public string IdentityName { get; set; }
        public bool IdentityActive { get; set; }
        public string LinkPath { get; set; }
        public string linkName { get; set; }
        public bool LinkActive { get; set; }
        public string DirectoryPath { get; set; }
    }
}
