using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.DAL.Petapoco
{
    public class TableModels
    {
        [TableName("Currencies")]
        [PrimaryKey("CurrencyID")]
        [ExplicitColumns]
        public partial class Currency
        {
            [Column]
            public int CurrencyID { get; set; }

            [Column]
            public string CurrencyCode { get; set; } = null!;

            [Column]
            public string Symbol { get; set; } = null!;

            [Column]
            public bool IsActive { get; set; } = false!;

            [Column]
            public DateTime CreatedOn { get; set; }

            [Column]
            public int CreatedBy { get; set; }

            [Column]
            public DateTime ModifiedOn { get; set; }

            [Column]
            public int modifiedBy { get; set; }

        }
    }
}
