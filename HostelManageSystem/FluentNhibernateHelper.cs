﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HostelManageSystem
{
    public class FluentNhibernateHelper
    {
        private static ISessionFactory _sessionFactory = null;//单例模式

        //_sessionFactory初始化
        private static void InitSeeionFactory()
        {
            /*Fluently使用它来识别Modle下与数据库中元素的映射关系*/
            var conn = "server = localhost; database = myblog; UserID = root; Password = ; Charset = utf8";
            _sessionFactory =

             Fluently.Configure().Database(

                 //连接数据库需要的配置和属性

                 (MySQLConfiguration.Standard.ConnectionString(conn))

                 //使用Mappings将Modle下的类于表进行一一对应

                 ).Mappings

                 //AddFromAssemblyOf从当前类NHibernateHelper的dll文件里面进行自动映射

                 (x => x.FluentMappings.AddFromAssemblyOf<FluentNhibernateHelper>())

                 //生成工厂

                 .BuildSessionFactory();//最后生成工厂赋值给_sessionFactory
        }

        //得到sessionFactory
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitSeeionFactory();
                }
                return _sessionFactory;
            }
        }

        //从sessionFactory里面得到session
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();//OpenSession() 这个就是用来得到session的

            //我们之后就是使用session来进行操作数据库
        }

    }
}