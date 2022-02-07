using System;
using System.Collections.Generic;

namespace GGroupp.Infra.Dataverse.Api.Test;

partial class ApiClientTestDataSource
{
    public static IEnumerable<object[]> GetEntityGetTestDataPair()
        =>
        new[]
        {
            new object[]
            {
                new Uri("https://some.crm4.dynamics.com/", UriKind.Absolute),
                new DataverseEntityGetIn(
                    entityPluralName: "SomeEntities",
                    entityKey: new StubEntityKey("SomeKey"),
                    selectFields: new[] { "field1", "field2" }),
                "https://some.crm4.dynamics.com/api/data/v9.0/SomeEntities(SomeKey)?$select=field1,field2"
            },
            new object[]
            {
                new Uri("https://some.crm4.dynamics.com/", UriKind.Absolute),
                new DataverseEntityGetIn(
                    entityPluralName: "SomeEntities",
                    entityKey: new StubEntityKey("SomeKey"),
                    selectFields: new[] { string.Empty, "field 1" }),
                "https://some.crm4.dynamics.com/api/data/v9.0/SomeEntities(SomeKey)?$select=field 1"
            },
            new object[]
            {
                new Uri("http://ggroupp.ru", UriKind.Absolute),
                new DataverseEntityGetIn(
                    entityPluralName: "Some/Entities",
                    entityKey: new StubEntityKey("Some Key"),
                    selectFields: default),
                "http://ggroupp.ru/api/data/v9.0/Some%2fEntities(Some+Key)"
            }
        };
}