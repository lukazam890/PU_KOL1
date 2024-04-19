using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Grupa
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int? ParentID { get; set; }
        [ForeignKey(nameof(ParentID))]
        public Grupa? Parent { get; set; }
        public IEnumerable<Grupa>? Children { get; set; }
    }
}
