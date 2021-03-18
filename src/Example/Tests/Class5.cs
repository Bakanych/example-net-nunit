using NUnit.Framework;
using ReportPortal.Shared;

namespace Example.Tests
{
    [TestFixture]
    public class Class5 : BaseTest
    {
        [OneTimeSetUp]
        public void BeforeFixture()
        {
            Step("BeforeFixture Step 1", () => Context.Current.Log.Info(("message")));
            Step("BeforeFixture Step 2", () => Context.Current.Log.Info(("message")));
        }

        [SetUp]
        public void BeforeTest()
        {
            Step("BeforeTest Step 1", () => Context.Current.Log.Info(("message")));
            Step("BeforeTest Step 2", () => Context.Current.Log.Info(("message")));
        }

        [Test]
        public void Test5_1()
        {
            Step("Step 1", () => Context.Current.Log.Info(("message")));
        }

        [Test]
        public void Test5_2()
        {
            Step("Step 1", () => Context.Current.Log.Info(("message")));
        }

        [TestCase("1")]
        [TestCase("2")]
        public void Test5_3(string s)
        {
            Step("Step 1", () => Context.Current.Log.Info((s)));
        }

        [TearDown]
        public void AfterTest()
        {
            Step("AfterTest Step 1", () => Context.Current.Log.Info(("message")));
            Step("AfterTest Step 2", () => Context.Current.Log.Info(("message")));
        }

        [OneTimeTearDown]
        public void AfterFixture()
        {
            Step("AfterFixture Step 1", () => Context.Current.Log.Info(("message")));
            Step("AfterFixture Step 2", () => Context.Current.Log.Info(("message")));
        }
    }
}