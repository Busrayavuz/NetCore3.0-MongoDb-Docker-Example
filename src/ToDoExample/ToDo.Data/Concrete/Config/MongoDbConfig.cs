﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data.Concrete.Config
{
    public class MongoDbConfig
    {
        public string Database { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
                    return $@"mongodb://{Host}:{Port}";

                return $@"mongodb://{User}:{Password}@{Host}:{Port}";
            }
        }
    }
}
