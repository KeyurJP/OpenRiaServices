﻿using System;
using System.ServiceModel;
using System.ServiceModel.DomainServices.Hosting;

namespace Cities
{
    public class CityDomainServiceHostFactory : DomainServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new CityDomainServiceHost(serviceType, baseAddresses);
        }
    }
}
