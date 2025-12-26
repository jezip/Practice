using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Models
{
    public class Equip
    {
        public int Id { get; set; }
        public string Inv { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int DeptId { get; set; }
    }
}
