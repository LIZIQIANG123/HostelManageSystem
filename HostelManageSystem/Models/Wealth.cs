using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 财产登记表
    /// </summary>
    public class Wealth
    {
        public virtual int WealthNo { get; set; }//表主键
        public virtual string WealthDesc { get; set; }//表中的名字
        public virtual DateTime WealthTime { get; set; }//表中的名字
        public virtual string WeCondition { get; set; }//表中的名字
        public virtual int RoomNo { get; set; }//表中的名字
    }
}