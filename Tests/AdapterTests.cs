
namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Spike.DataSource.Adapters;
    using Spike.DataSource.Entities;

    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void AddAuthor()
        {
            var cliveCustler = new AuthorEntity
            {
                Id = Guid.NewGuid(),
                Name = "Clive",
                Surname = "Custler",
                BirthDay = new DateTime(1986, 03, 1)
            };

            var authorAdapter = new AuthorAdapter();

            if (authorAdapter.AddAuthor(cliveCustler) != null)
            {
                authorAdapter.Context.SaveChanges();
            }
        }
    }
}
