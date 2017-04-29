using System;

namespace DocumentDBLibraryDotNet
{
    public interface IConnectionStrings
    {

    }

    public class ConnectionSettings : IConnectionStrings
    {


        public ConnectionSettings(string databaseUri, string databaseName, string databaseKey, string collection)
        {
            DatabaseUri = new Uri(databaseUri);
            DatabaseName = databaseName;
            DatabaseKey = databaseKey;
            Collection = collection;
        }

        public Uri DatabaseUri { get; private set; }
        public string DatabaseKey { get; private set; }
        public string DatabaseName { get; private set; }
        public string Collection { get; private set; }




    }
}
