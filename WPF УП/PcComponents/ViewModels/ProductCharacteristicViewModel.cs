using PcComponents.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PcComponents.Services
{
    public class ProductCharacteristicViewModel
    {
		public int Id { get; set; }
		public string CharName { get; set; }
		public string CharValue { get; set; }
		public string Unit { get; set; }
        public ProductCharacteristicViewModel(Characteristic characteristic)
        {
            this.Id = characteristic.Id;
            this.CharName = characteristic.CharacteristicName;
            this.CharValue = "";
            this.Unit = "";
        }


    }
}
