using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class Admin
    {
        public virtual int AdminId { get; set; }//表主键
        public virtual string AdminPwd { get; set; }//表中的名字
        public virtual string AdminName { get; set; }//表中的名字
        public virtual string ServiceThing { get; set; }//表中的名字
        public virtual string Announce { get; set; }//表中的名字
        public virtual DateTime AnnTime { get; set; }//表中的名字

    }
}