using ScadaModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ScadaCore
{
    public class Service : IDbManager
    {
        public static AlarmManager alarmManager = new AlarmManager();
        public TagManager tagManager = new TagManager(alarmManager);
        public UserManager userManager = new UserManager();
        static SimulationDriver simulationDriver;

        public void DoWork()
        {
            throw new NotImplementedException();
        }
        public void AddTag(Tag tag)
        {
            tagManager.tags.Add(tag.TagName,tag);
        }
        
    }
}