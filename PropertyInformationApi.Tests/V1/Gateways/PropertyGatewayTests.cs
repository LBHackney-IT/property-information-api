using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PropertyInformationApi.V1.Gateways;
using FluentAssertions;
using AutoFixture;
using PropertyInformationApi.V1.Boundary.Request;
using PropertyInformationApi.V1.Infrastructure;

namespace PropertyInformationApi.Tests.V1.Gateways
{
    [TestFixture]
    public class PropertyGatewayTests : PropertyDbTests
    {
        private        PropertyGateway _classUnderTest;
        private static Fixture         _fixture = new Fixture();

        [SetUp]
        public void Setup()
        {
            _classUnderTest = new PropertyGateway(UhContext);
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
        public void GatewayReturnsPropertiesMatchingAPostcode()
        {
            AddPropertiesToDatabase(5);

            var request    = new GetPropertiesRequest {Postcode = "A0 0AA"};
            var response   = _classUnderTest.GetPropertiesByPostcodeOrAddress(request).ToList();

            response.Should().NotBeEmpty()
                .And.HaveCount(5)
                .And.OnlyContain(p => p.PostCode == "A0 0AA");
        }

        [Test]
        public void GetawayReturnsNullWhenNotFound()
        {
            var response = _classUnderTest.GetPropertyByPropertyReference("foo");
            response.Should().BeNull();
        }


        private UHProperty AddPropertyToDatabase()
        {
            var expectedProperty = _fixture
                .Build<UHProperty>()
                .Create();

            UhContext.UhProperties.Add(expectedProperty);
            UhContext.SaveChanges();
            return expectedProperty;
        }

        private void AddPropertiesToDatabase(int times)
        {
            var expectedProperties = new List<UHProperty>();
            for (var i = 0; i < times; i++)
            {
                expectedProperties.Add(_fixture.Build<UHProperty>().Create());
                expectedProperties.Last().PostCode = "A0 0AA";
            }

            UhContext.UhProperties.AddRangeAsync(expectedProperties);
            UhContext.SaveChanges();
        }
    }
}
