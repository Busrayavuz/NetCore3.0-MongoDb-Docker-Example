using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data.Concrete.Config
{
    public class ServerConfig
    {
        public MongoDbConfig MongoDB { get; set; } = new MongoDbConfig();
    }
}
