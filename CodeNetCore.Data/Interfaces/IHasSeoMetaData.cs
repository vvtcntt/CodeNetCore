using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNetCore.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string TitleMeta { set; get; }
        string KeywordMeta { set; get; }
        string DescriptionMeta { set; get; }
        string Alias { set; get; }
    }
}
