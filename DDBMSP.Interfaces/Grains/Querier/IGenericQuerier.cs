﻿using System.Threading.Tasks;
using DDBMSP.Entities.Query;
using Orleans;
using Orleans.Concurrency;

namespace DDBMSP.Interfaces.Grains.Querier
{
    public interface IGenericQuerier : IGrainWithIntegerKey
    {
        Task<Immutable<object>> Query(Immutable<string> queryName);
        Task<Immutable<QueryDefinition>> GetQueryDefinition(Immutable<string> queryName);
    }
}