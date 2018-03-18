using System.Data.Entity;
using KellermanSoftware.CompareNetObjects;
using Spike.Instrumentation.Logging;

namespace Spike.DataSource.Base
{
    public class AdapterBase
    {
        public DataContext Context { get; private set; }
        public static Logging Logger = LogFactory.Create("Spike.Adapters");

        public AdapterBase(DataContext context = null)
        {
            Context = context ?? new DataContext();
        }

        public static TEntity AddEntity<TEntity>(DbSet<TEntity> repo, TEntity entity)
            where TEntity : class
        {
            var response = repo.Add(entity);

            var compareLogic = new CompareLogic();
            var compareResult = compareLogic.Compare(entity, response);
            if (compareResult.AreEqual) return response;

            Logger.Error($"Failed to add entity [{typeof(TEntity)}] Response did not match request [{compareResult.DifferencesString}]");
            return null;
        }

    }
}
