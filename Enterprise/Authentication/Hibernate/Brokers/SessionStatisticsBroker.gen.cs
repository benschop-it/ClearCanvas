// This file is machine generated - changes will be lost.
using System;
using System.Collections.Generic;
using System.Text;

using ClearCanvas.Enterprise.Hibernate;
using ClearCanvas.Enterprise.Authentication.Brokers;

namespace ClearCanvas.Enterprise.Authentication.Hibernate.Brokers
{
    /// <summary>
    /// NHibernate implementation of <see cref="ISessionStatisticsBroker"/>.
    /// </summary>
    [ClearCanvas.Common.ExtensionOf(typeof(BrokerExtensionPoint))]
	public partial class SessionStatisticsBroker : EntityBroker<SessionStatistics, SessionStatisticsSearchCriteria>, ISessionStatisticsBroker
	{
	}
}