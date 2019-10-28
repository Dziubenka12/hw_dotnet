using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Motorcycle
    {
        const ushort MaxSpeed = 300;
        public const ushort MaxSpeedPublic = 300;
        private const ushort MaxSpeedPrivate = 300;
        public string vinNamberPublic = "212sq23d";
        int odometr = 20_000;
        protected string vinNamberProtected = "212sq23d";
        protected internal string vinNamberProtectedInternal = "212sq23d";
        public void StartEnginePublic()
        {

        }
        private protected void StartEnginePrivateProtected ()
        {

        }
    }

    class SportBike : Motorcycle
    {
        
        private protected void StartEngine()
        {

        }
        public void StartEnginePublic2()
        {

        }
    }
}
