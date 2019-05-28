﻿using JadeFramework.Core.Consul;

namespace MsSystem.OA.API
{
    public class AppSettings
    {
        public Identity Identity { get; set; }
        public MySQL MySQL { get; set; }
        public RabbitMQ RabbitMQ { get; set; }
        public MsApplication MsApplication { get; set; }
        public ServiceDiscoveryOptions ServiceDiscovery { get; set; }
    }
    public class Identity
    {
        public string Audience { get; set; }
        public string Authority { get; set; }
    }
    public class MySQL
    {
        public string Connection { get; set; }
    }
    public class MsApplication
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string grant_type { get; set; }
        public string scopes { get; set; }
        public string url { get; set; }
        public string tokenurl { get; set; }
    }
    public class RabbitMQ
    {
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
