﻿using Bogus;

namespace CaveTester.Bogus.RuleSet
{
    public static class RuleSetHandler
    {
        public static IRuleSet RuleSet { get; set; } = new RuleSet();

        public static Faker<T> ApplyGlobalRuleSet<T>(this Faker<T> faker)
            where T : class
        {
            return RuleSet.Apply(faker);
        }
    }
}
