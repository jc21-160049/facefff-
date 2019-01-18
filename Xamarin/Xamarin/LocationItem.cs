using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamarin
{
    public class LocationItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Spay { get; set; }
        public int Num { get; set; }
        public DateTime Day { get; set; }

    }

    public class goalmoney1
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public int goalmoney { get; set; }
    }

    public class income
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int incomemoney { get; set; }
        public int incomeDay { get; set; }
    }

    public class salarymoney
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        //public string Name { get; set; }
        public int Spay { get; set; }
        public int Num { get; set; }
    }

    public class fixed_costmoney
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string cate { get; set; }
        public int Spay { get; set; }
    }

    public class Template
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Iname { get; set; }
        public int Tmoney { get; set; }
    }
}
