using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string updateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool status { set; get; }
    }
}
