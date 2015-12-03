using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.IO;

namespace IfcExtractor
{
    public class Class1
    {
        public void readIfcFile()
        {           

            XbimModel model = XbimModel.CreateModel("newModel");
            model.CreateFrom(@"C:\Users\Frederik\Source\Repos\ifcMengder\IfcExtractor\IfcExtractor\SB_1017801_7_RIE_430_00.ifc");

        }

    }
}
