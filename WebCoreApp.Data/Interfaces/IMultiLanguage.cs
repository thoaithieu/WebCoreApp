using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApp.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LangugeId { get; set; }
    }
}
