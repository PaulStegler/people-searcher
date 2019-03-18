﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleSearch.Tests
{
    public class InMemoryDatabaseTest
    {
        protected readonly PersonRepository PersonRepository =
            new PersonRepository(new DbContextOptionsBuilder<PersonContext>()
                .UseInMemoryDatabase(databaseName: "PeopleSearchDb")
                .Options);
    }
}
