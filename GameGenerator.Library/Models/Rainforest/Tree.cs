using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Tree : IPlant
    {
        private readonly string _status = "Tree instantiated.";

        public Tree()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
