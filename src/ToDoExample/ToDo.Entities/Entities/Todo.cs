using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Entities.Entities
{
    public class Todo
    {
        [BsonId]
        public ObjectId InternalId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
