using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 东西借还表
    /// </summary>
    public class Borrow
    {
        public virtual int BorrowNo { get; set; }//表主键
        public virtual string BorrowName { get; set; }//表中的名字
        public virtual string BorrowThing { get; set; }//表中的名字
        public virtual DateTime BorrowInTime { get; set; }//表中的名字
        public virtual DateTime BorrowOutTime { get; set; }//表中的名字
        public virtual int RoomNo { get; set; }//表中的名字
        public virtual string BorrowAge { get; set; }//表中的名字

    }
}