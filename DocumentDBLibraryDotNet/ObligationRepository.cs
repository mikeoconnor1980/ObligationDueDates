using System;
using System.Collections.Generic;
using ObligationDueDates.ObjectsDotNet;
using System.Linq;
using Microsoft.Azure.Documents;
using System.Net;
using Microsoft.Azure.Documents.Client;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DocumentDBLibraryDotNet;

namespace DocumentDBLibraryDotNet
{
    public interface IObligationRepository
    {
        List<Client> GetAll();
        Task<Obligation> Get(string id);
        Obligation Add(Obligation obligation);
        void Delete(string id);
        bool Update(Obligation obligation);

        void InitialiseData();
    }

    public class ObligationRepository : IObligationRepository
    {
        private DocumentDbProvider _provider;
        private List<Obligation> _obligations = new List<Obligation>();

        public ObligationRepository()
        {
            //ConnectionSettings configuration = new ConnectionSettings();
            //_provider = new DocumentDbProvider(configuration);
        }

        public Obligation Add(Obligation obligation)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            _obligations.RemoveAll(o => o.Id == id);
        }

        public async Task<Obligation> Get(string id)
        {
            //return _provider.CreateQuery<Obligation>().Where(o => o.Id == id).FirstOrDefault();
            var response = await _provider._dbClient.ReadDocumentAsync(_provider.GetDocumentLink("us_oh_hubbard_bt_file_q100_est_tax_pmt_02_2014"));
            return JsonConvert.DeserializeObject<Obligation>(response.Resource.ToString());
        }

        public List<Client> GetAll()
        {
            try
            {

                string EndpointUri = "https://odd-dev.documents.azure.com:443/";
                string PrimaryKey = "Kczj339CTusj9d4260FSZ9nUTrNsqFIJp7RBp5XECZ4SaFQfSvPYrW98J0Gxw8ISi86yAg1kVHPNq49sqTtvJg==";
                string collectionLink = UriFactory.CreateDocumentCollectionUri("odd-dev", "clients").ToString();
                /*DocumentClient docclient = new DocumentClient(new Uri(EndpointUri), PrimaryKey);
                docclient.OpenAsync();
                
                string collectionLink2 = _provider.GetCollectionLink().ToString();*/
                ConnectionSettings connection = new ConnectionSettings(EndpointUri, "odd-dev", PrimaryKey, "clients");
                DocumentDbProvider provider = new DocumentDbProvider(connection);
                //provider._dbClient.CreateDocumentQuery<Client>(collectionLink).ToList();
                //provider.CreateQuery<Client>();//.Where(o => o.Type == "obligation");
                return provider.CreateQuery<Client>().ToList();

                //return docclient.CreateDocumentQuery<Client>(collectionLink).ToList();
                //return docclient.CreateDocumentQuery<Obligation>(link).ToList();

                //return _provider.CreateQuery<Obligation>();//.Where(o => o.Type == "obligation");
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception("Document not found");
                }
                else
                {
                    throw;
                }
            }



        }

        public bool Update(Obligation obligation)
        {
            throw new NotImplementedException();
        }

        public async void InitialiseData()
        {
            InitialiseData initialiseData = new InitialiseData();
            List<Obligation> obligations = initialiseData.Load();

            foreach (Obligation obligation in obligations)
            {
                await _provider.AddItem<Obligation>(obligation);
            }
        }
    }
}
