using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 学生出入登记表
    /// </summary>
    public class StuOut
    {
        public virtual int Id { get; set; }//表主键
        public virtual string StuName { get; set; }//表中的名字
        public virtual int RoomNo { get; set; }//表中的名字
        public virtual DateTime OutTime { get; set; }//表中的名字
        public virtual DateTime InTime { get; set; }//表中的名字


    }
}