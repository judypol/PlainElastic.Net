﻿using Machine.Specifications;
using PlainElastic.Net.Queries;


namespace PlainElastic.Net.Tests.Buildres.Queries
{
    [Subject(typeof(MissingFilter<>))]
    class When_MissingFilter_with_SouldExists_false_built
    {
        Because of = () => result = new MissingFilter<FieldsTestClass>()                                                
                                                .Field(f => f.StringProperty)
                                                .ShouldMiss(false)
                                                .ToString();

        It should_return_empty_string = () => result.ShouldBeEmpty();

        private static string result;
    }
}
