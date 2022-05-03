using Week2.Esercitazione.Demo.Entities;

namespace Week2.Esercitazione.Demo.Handlers
{
    public class AbsenceHandler : IHandler
    {
        public int Y { get; }
        public int Z { get; }

        public AbsenceHandler(int y, int z)
        {
            Y = y;
            Z = z;
        }

        public double Handle(Employee employee)
        {
            if (employee.Age < Y && employee.AbsenceRate < Z)
            {
                return 180;
            }
            else
            {
                return 0;
            }
        }
    }
}