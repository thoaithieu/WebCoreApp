using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeywords { get; set;}
        string Description { get; set; }
    }
}
