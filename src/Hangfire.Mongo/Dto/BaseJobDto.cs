﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hangfire.Mongo.Dto
{
#pragma warning disable 1591
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(
        typeof(AggregatedCounterDto),
        typeof(CounterDto),
        typeof(ListDto),
        typeof(SetDto),
        typeof(HashDto),
        typeof(JobDto))]
    public class BaseJobDto
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
        public DateTime? ExpireAt { get; set; }
    }
#pragma warning restore 1591
}