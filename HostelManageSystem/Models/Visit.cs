using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 人员来访登记表
    /// </summary>
    public class Visit
    {
        public virtual int VisitNo { get; set; }//表主键
        public virtual string VisitName { get; set; }//表中的名字
        public virtual string VisitPeople { get; set; }//表中的名字
        public virtual DateTime VisitTime { get; set; }//表中的名字

    }
}