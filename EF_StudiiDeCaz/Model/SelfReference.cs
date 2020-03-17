using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_StudiiDeCaz.Model
{
    public class SelfReference
    {

        public int SelfeReferenceId { get; private set; }
        public string Name { get; set; }

        public int? ParentSelfReferencedId { get; private set; }

        public SelfReference ParentSelfReference { get; set; }

        public virtual ICollection<SelfReference> References { get; set; }
        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
        
    }
}
