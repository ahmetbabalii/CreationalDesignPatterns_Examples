using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.solution1
{
    public interface IPremiumFactory
    {
        Premium create(string model, double netPrice, bool doCarHaveAutoPilot, bool doCarsHaveMassageSeats);
    }
}
