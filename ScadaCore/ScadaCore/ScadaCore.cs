using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ScadaModel;

namespace ScadaCore
{
    public class ScadaCore : IDbManager
    {
        private static Dictionary<string, Tag> tags;
        static SimulationDriver simulationDriver;

        public void DoWork()
        {
            throw new NotImplementedException();
        }
        public void AddTag(Tag tag)
        {
            tags.Add(tag.TagName, tag);
        }

    }
}