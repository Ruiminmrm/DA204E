using System;
namespace Upp2
{
    class MainProgram
    {
        static void Main()
        {
            FunFeatures funFeatures = new FunFeatures();
            funFeatures.Start();
            
            MathWork mathWork = new MathWork();
            mathWork.Start();

            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            WorkingSchedule workingSchedule = new WorkingSchedule();
            workingSchedule.Start();
        }
    }
}