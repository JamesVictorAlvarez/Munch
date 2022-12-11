using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munch
{
    public class Connection
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\School\App Dev\Project\Munch\Munch\Form\UserDb.mdf"";Integrated Security=True");
    }
}
