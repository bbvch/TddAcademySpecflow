using System;

namespace TddAcademy
{
    public interface IInstrument
    {
        void Execute(string task);
        
        event EventHandler Finished;
        event EventHandler Error;
    }
}