using GameGenerator.Library.Interfaces;
using System;

namespace GameGenerator.Library.Models.Rainforest
{
    public class Sand : IUnderground
    {
        private readonly string _status = "Sand instantiated.";
        public Sand()
        {
            Console.WriteLine(this._status);
        }

        public string Status => this._status;

    }
}
