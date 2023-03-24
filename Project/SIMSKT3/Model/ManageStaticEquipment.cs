using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Model
{
   public class ManageTransfer
    {
        public ManageTransfer(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, double quantity, string transferDate, string startTime, string endTime)
        {
            this.fromRoomName = fromRoomName;
            this.toRoomName = toRoomName;
            this.typeOdStaticEquipment = typeOdStaticEquipment;
            this.equipId = equipId;
            this.quantity = quantity;
            this.transferdate = transferDate;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public string fromRoomName { get; set; }
        public string toRoomName { get; set; }
        public string typeOdStaticEquipment { get; set; }
        public int equipId { get; set; }
        public double quantity { get; set; }
        public string transferdate { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
}
