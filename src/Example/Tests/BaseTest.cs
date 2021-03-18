using System;
using NUnit.Framework;
using ReportPortal.Shared;
using ReportPortal.Shared.Execution.Logging;

namespace Example.Tests
{
    public class BaseTest
    {
        protected void Step(string name, Action action)
        {
            using (ILogScope logScope = Context.Current.Log.BeginScope(name))
            {
                try
                {
                    Assert.DoesNotThrow(action.Invoke);
                }
                catch (Exception ex)
                {
                    logScope.Error(ex.Message);
                    logScope.Status = LogScopeStatus.Failed;
                    throw;
                }
                finally
                {
                }
            }
        }
    }
}