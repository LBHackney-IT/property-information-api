using NUnit.Framework;
using PropertyInformationApi.V1.Gateways;
using FluentAssertions;
using AutoFixture;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.Tests.V1.Gateways
{
    [TestFixture]
    public class PropertyGatewayTests : UhTests
    {
        private PropertyGateway _classUnderTest;
        private static Fixture _fixture = new Fixture();
        //private PropertyFactory _factory;

        //private readonly PropertyTestHelper _uhPropertyHelper = new PropertyTestHelper();

        [SetUp]
        public void Setup()
        {
            //var config = PropertyHelper.ConfigureMapper();
            //_factory = new PropertyFactory(config.CreateMapper());
            _classUnderTest = new PropertyGateway(UhContext);//, _factory);
        }

        [Test]
        public void GatewayImplementsGatewayInterface()
        {
            Assert.NotNull(_classUnderTest is IPropertyGateway);
        }

        [Test]
        public void GatewayReturnsAPropertyWhenGivenARef()
        {
            var property = AddPropertyToDatabase();
            var response = _classUnderTest.GetPropertyByPropertyReference(property.PropRef);

            response.Should().NotBeNull();
            response.PropRef.Should().Be(property.PropRef);
        }

        [Test]
        public void GetawayReturnsNullWhenNotFound()
        {
            var response = _classUnderTest.GetPropertyByPropertyReference("foo");
            response.Should().BeNull();
        }



        private UHProperty AddPropertyToDatabase()
        {
            var expectedProperty = _fixture.Build<UHProperty>()
               .Create();

            UhContext.UhProperties.Add(expectedProperty);
            UhContext.SaveChanges();
            return expectedProperty;
        }
    }
}
