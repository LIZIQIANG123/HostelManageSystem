using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 学生违纪登记表
    /// </summary>
    public class Discipline
    {
        public virtual int Id { get; set; }//表主键
        public virtual string StuName { get; set; }//表中的名字
        public virtual DateTime DisciplineTime { get; set; }//表中的名字
        public virtual string DisciplineThing { get; set; }//表中的名字
        public virtual string RoomNo { get; set; }//表中的名字
        public virtual string DepName { get; set; }//表中的名字
        public virtual string Stuperfect { get; set; }//表中的名字


    }
}