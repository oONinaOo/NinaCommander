using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinaCommanderv2._0
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {
            ErrorForm error = new ErrorForm(message);
            error.Show();
        }
    }
}
