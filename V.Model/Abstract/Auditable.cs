using System;
using System.ComponentModel.DataAnnotations;

namespace V.Model.Models
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}