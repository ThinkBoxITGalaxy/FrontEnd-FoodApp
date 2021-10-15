using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justeat_replica
{
    public class Foodclass
    {
        public string foodname { get; set; }
        public string fooddesc { get; set; }
        public string food_size { get; set; }
        public int size_id { get; set; }
        public int food_price { get; set; }
        public int food_id { get; set; }
    }
    public class foodOrder : foodaccessory
    {
        public int foodid { get; set; }
        public string foodname { get; set; }
        public int foodprice { get; set; }
        public int foodquantity { get; set; }
        public string food_acc { get; set; }
    }
    public class foodaccessory
    {
        public string foodacc_name { get; set; }
        public int foodacc_quantity { get; set; }
    }
    public class OptionGroup
    {
        public int food_id { get; set; }
        public int option_id { get; set; }
        public string option_name { get; set; }
        public string optionN { get; set; }
        public int RPID { get; set; }
        public int acc_id { get; set; }
        public int acc_price { get; set; }
    }
    public class Selections
    {
        public int food_id { get; set; }
        public string food_name { get; set; }
        public int rpid { get; set; }
    }
    public class SectionData
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
