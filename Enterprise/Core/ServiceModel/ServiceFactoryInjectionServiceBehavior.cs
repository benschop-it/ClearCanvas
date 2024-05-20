#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using ClearCanvas.Enterprise.Core;
using CoreWCF.Description;
using CoreWCF;
using CoreWCF.Channels;
using CoreWCF.Dispatcher;

namespace ClearCanvas.Enterprise.Core.ServiceModel
{
    /// <summary>
    /// Implementation of <see cref="IServiceBehaviour"/> that is used to customize a WCF
    /// service host such that it obtains instances of service implementations from
    /// a <see cref="IServiceFactory"/>.
    /// </summary>
    /// <remarks>
    /// Based on code found here: http://orand.blogspot.com/2006/10/wcf-service-dependency-injection.html
    /// </remarks>
    class ServiceFactoryInjectionServiceBehavior : IServiceBehavior
    {
        #region IInstanceProvider implementation

        class InstanceProvider : IInstanceProvider
        {
            private Type _serviceContract;
            private IServiceFactory _serviceFactory;

            internal InstanceProvider(Type serviceContract, IServiceFactory serviceFactory)
            {
                _serviceContract = serviceContract;
                _serviceFactory = serviceFactory;
            }

            #region IInstanceProvider Members

            public object GetInstance(InstanceContext instanceContext, Message message)
            {
                return _serviceFactory.GetService(_serviceContract);
            }

            public object GetInstance(InstanceContext instanceContext)
            {
                return GetInstance(instanceContext, null);
            }

            public void ReleaseInstance(InstanceContext instanceContext, object instance)
            {
            }

            #endregion
        }

        #endregion

        private Type _serviceContract;
        private IServiceFactory _serviceManager;

        /// <summary>
        /// Constructs an instance of the service behaviour that obtains instances of the
        /// specified service contract from the specified service factory.
        /// </summary>
        /// <param name="serviceContract"></param>
        /// <param name="serviceManager"></param>
        public ServiceFactoryInjectionServiceBehavior(Type serviceContract, IServiceFactory serviceManager)
        {
            _serviceContract = serviceContract;
            _serviceManager = serviceManager;
        }


		#region IServiceBehavior Members

		public void AddBindingParameters(ServiceDescription serviceDescription, // TODO WCF server APIs are unsupported on .NET Core. Consider rewriting to use gRPC (https://docs.microsoft.com/dotnet/architecture/grpc-for-wcf-developers), ASP.NET Core, or CoreWCF (https://github.com/CoreWCF/CoreWCF) instead.
ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
		{
		}

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, // TODO WCF server APIs are unsupported on .NET Core. Consider rewriting to use gRPC (https://docs.microsoft.com/dotnet/architecture/grpc-for-wcf-developers), ASP.NET Core, or CoreWCF (https://github.com/CoreWCF/CoreWCF) instead.
ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcherBase cdb in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher cd = cdb as ChannelDispatcher;
                if (cd != null)
                {
                    foreach (EndpointDispatcher ed in cd.Endpoints)
                    {
                        ed.DispatchRuntime.InstanceProvider =
                            new InstanceProvider(_serviceContract, _serviceManager);
                    }
                }
            }
        }

		public void Validate(ServiceDescription serviceDescription, // TODO WCF server APIs are unsupported on .NET Core. Consider rewriting to use gRPC (https://docs.microsoft.com/dotnet/architecture/grpc-for-wcf-developers), ASP.NET Core, or CoreWCF (https://github.com/CoreWCF/CoreWCF) instead.
ServiceHostBase serviceHostBase)
		{
		}

		#endregion
	}
}