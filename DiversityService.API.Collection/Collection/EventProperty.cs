//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiversityService.Collection
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventProperty
    {
        public int CollectionEventID { get; set; }
        public int PropertyID { get; set; }
        public string DisplayText { get; set; }
        public string PropertyURI { get; set; }
        public string PropertyHierarchyCache { get; set; }
        public string PropertyValue { get; set; }
        public string ResponsibleName { get; set; }
        public string ResponsibleAgentURI { get; set; }
        public string Notes { get; set; }
        public Nullable<double> AverageValueCache { get; set; }
        public System.Guid RowGUID { get; set; }
    
        public virtual Event CollectionEvent { get; set; }
        public virtual Property Property { get; set; }
    }
}
