using System;
using System.Collections.Generic;
using ObligationDueDates.Objects;
using Microsoft.Extensions.Configuration;
using DocumentDBLibrary;
using Microsoft.Azure.Documents.Client;
using System.Linq;

namespace ObligationDueDates.Data
{
    public interface IObligationRepository
    {
        IEnumerable<Obligation> GetAll();
        Obligation Get(string id);
        Obligation Add(Obligation obligation);
        void Delete(string id);
        void Update(Obligation obligation);
        void Load();
    }

    public class ObligationRepository : IObligationRepository
    {
        private DocumentDbProvider _provider;
        private List<Obligation> _obligations = new List<Obligation>();

        public ObligationRepository(IConfiguration configuration)
        {
            _provider = new DocumentDbProvider(new ConnectionSettings(configuration));
        }

        public Obligation Add(Obligation obligation)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            _obligations.RemoveAll(o => o.Id == id);
        }

        public Obligation Get(string id)
        {
            return _obligations.Find(o => o.Id == id);
        }

        public IEnumerable<Obligation> GetAll()
        {
            var feedOptions = new FeedOptions() { MaxItemCount = 1 };

            return _provider.CreateQuery<Obligation>(feedOptions).Where(x => x.Type == "obligation");
                
        }

        public async void Update(Obligation obligation)
        {
            await _provider.InsertItem<Obligation>(obligation);
        }

        public void Load()
        {
            InitialiseData id = new InitialiseData();
            List<Obligation> obligations = id.Load();
            foreach(Obligation obligation in obligations)
            {
                Update(obligation);

            }
        }
    }
}
