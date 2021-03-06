﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace StarWarsClientDemo
{
    public class GetHeroOperation
        : IOperation<IGetHero>
    {
        public string Name => "GetHero";

        public IDocument Document => Queries.Default;

        public Type ResultType => typeof(IGetHero);

        public Optional<Episode?> Episode { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if(Episode.HasValue)
            {
                variables.Add(new VariableValue("episode", "Episode", Episode.Value));
            }

            return variables;
        }
    }
}
