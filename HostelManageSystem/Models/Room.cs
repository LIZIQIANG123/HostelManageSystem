using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 寝室信息表
    /// </summary>
    public class Room
    {
        public virtual int RoomId { get; set; }//表主键
        public virtual int RoomNo { get; set; }//表中的名字
        public virtual string RoHeader { get; set; }//表中的密码
        public virtual int RoomTypeNo { get; set; }//表中的描述
        public virtual int RoomNum { get; set; }//表中的描述
        public virtual int RoomState { get; set; }//表中的描述
    }
}