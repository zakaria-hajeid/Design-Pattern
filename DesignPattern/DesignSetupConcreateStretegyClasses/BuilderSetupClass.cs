using BulderDb;
using BulderDb.Abstraction;
using DesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignSetupConcreateStretegyClasses
{
    public class BuilderSetupClass : IDesignPatternSelector
    {
        public void DesigntypeSetup()
        {
            LoginDirector ld = new LoginDirector();
            ld.MakeLogin(new LoginTokenDirictor());


        }

    }
}
