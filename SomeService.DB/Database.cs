using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeService.Core;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SomeService.DataProvider
{
    public class Database : IDatabase
    {
        List<DBMember> members = new List<DBMember>();
        

        public int Get()
        {
            int Summary = 0;
            foreach(var i in members)
            {
                Summary += i.Value;
            }
            return Summary;
        }
        public void Set(string Name, int Value)
        {
            DBMember tempDbMember = new DBMember();
            tempDbMember.Name = Name;
            tempDbMember.Value = Value;
            members.Add(tempDbMember);
        }
        
    }
    public class DBMember
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
