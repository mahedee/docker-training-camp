﻿using Faker.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class Range
    {
        public int Count { get; set; } = 10;
        public bool Sort { get; set; } = false;

        public IEnumerable<TItem> Of<TItem>(Func<TItem> generateItem)
            => Count.Times(i => generateItem())
                .OrderBy(n => Sort ? n : default(TItem));
    }
}
