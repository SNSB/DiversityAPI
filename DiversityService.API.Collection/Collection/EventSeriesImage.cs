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
    
    public partial class EventSeriesImage
    {
        public int SeriesID { get; set; }
        public string URI { get; set; }
        public string ResourceURI { get; set; }
        public string ImageType { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string DataWithholdingReason { get; set; }
        public System.Guid RowGUID { get; set; }
        public string Title { get; set; }
        public string IPR { get; set; }
        public string CreatorAgent { get; set; }
        public string CreatorAgentURI { get; set; }
        public string CopyrightStatement { get; set; }
        public string LicenseType { get; set; }
        public string InternalNotes { get; set; }
        public string LicenseHolder { get; set; }
        public string LicenseHolderAgentURI { get; set; }
        public string LicenseYear { get; set; }
    
        public virtual EventSeries Series { get; set; }
    }
}
