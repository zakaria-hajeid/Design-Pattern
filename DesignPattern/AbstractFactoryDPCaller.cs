using BulderDb.Abstraction;
using DesignPattern.Abstraction;
using DesignPattern.DesignSetupConcreateStretegyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public static class AbstractFactoryDPCaller
    {
        public static IDesignPatternSelector? FactoryCallDp(DpType type)
        {
            if(type== DpType.bulder)
            {
                return new BuilderSetupClass();
            } 
            else if(type == DpType.Bridge)
            {
                return new BridgeSetup();
            }
            return null;
        }
    }



    public enum DpType
    {
        bulder=1,
        Bridge=2,
        Decorator=3
    }
}
