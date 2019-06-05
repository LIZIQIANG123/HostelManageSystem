using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    public class Service
    {
        public virtual int ServiceId { get; set; }//表主键
        public virtual int RoomNo { get; set; }//表中的名字
        public virtual string ServiceName { get; set; }//表中的名字
        public virtual string ServiceThing { get; set; }//表中的名字
        public virtual DateTime ServiceTime { get; set; }//表中的名字
        public virtual string ServiceType { get; set; }//表中的名字
    }
}