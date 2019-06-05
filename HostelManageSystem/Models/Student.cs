using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 学生信息表
    /// </summary>
    public class Student
    {
        public virtual int StuId { get; set; }//表主键
        public virtual int StuNo { get; set; }//表中的名字
        public virtual string StuName { get; set; }//表中的密码
        public virtual string StuPwd { get; set; }//表中的描述
        public virtual string StuSex { get; set; }//表中的描述
        public virtual int StuAge { get; set; }//表中的描述
        public virtual DateTime StuBorn { get; set; }//表中的描述
        public virtual string StuClass { get; set; }//表中的描述
        public virtual string StuAdress { get; set; }//表中的描述
        public virtual DateTime StuTime { get; set; }//表中的描述
        public virtual string DepName { get; set; }//表中的描述
        public virtual string StuPerfect { get; set; }//表中的描述
        public virtual int RoomNo { get; set; }//表中的描述
    }
}