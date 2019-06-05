using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem.Models
{
    /// <summary>
    /// 寝室分类表
    /// </summary>
    public class RoomType
    {
        public virtual int RoomTypeId { get; set; }//表主键
        public virtual string Roomtype { get; set; }//表中的名字
    }
}