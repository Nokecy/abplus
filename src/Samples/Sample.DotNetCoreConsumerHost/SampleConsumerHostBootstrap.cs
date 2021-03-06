﻿using Abp;

namespace Sample.DotNetCoreConsumerHost
{
    public class SampleConsumerHostBootstrap
    {
        private static readonly AbpBootstrapper _bs = AbpBootstrapper.Create<SampleConsumerHostModule>();

        public void Start()
        {
            //LogManager.Configuration = new XmlLoggingConfiguration("nlog.config");
            _bs.Initialize();
        }

        public void Stop()
        {
            _bs.Dispose();
        }
    }
}
