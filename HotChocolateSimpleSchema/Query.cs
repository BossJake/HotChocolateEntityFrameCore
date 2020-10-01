using GreenDonut;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using HotChocolateSimpleSchema.Entity;
using HotChocolateSimpleSchema.Repository;
using HotChocolateSimpleSchema.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotChocolateSimpleSchema
{
    public class Query
    {
        private readonly IGenericRepository<int, Rate> _rateRepository;

        public Query(IGenericRepository<int, Rate> rateRepository)
        {
            _rateRepository = rateRepository;
        }

        public IQueryable<Rate> GetRates()
        {
            return _rateRepository.GetAll();
        }
    }
}
