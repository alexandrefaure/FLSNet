using FlsBLL.BLL;
using FlsBLL.Mapper;
using FlsBLL.Tests.Helpers;
using FlsCommon.DTO;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FlsBLL.Tests
{
    [TestFixture]
    public sealed class MedecinAppelantsBllTest
    {
        [SetUp]
        public void TestInitialize()
        {
            //Initialisation des mappings profiles
            var loadMappers = new MainMapperProfile();
            loadMappers.ConfigureObjectMapper();
        }

        [Test]
        public void AddMedecinAppelant_ReturnsFalse_Test()
        {
            var medecinAppelantDto = new MedecinAppelantDto();
            var medecinAppelantBll = new MedecinAppelantBLL();
            var addOrUpdateMedecinAppelantResult = medecinAppelantBll.AddOrUpdateMedecinAppelant(medecinAppelantDto);
            Assert.IsFalse(addOrUpdateMedecinAppelantResult.Success);
        }

        [Test]
        public void AddNonEmptyMedecinAppelant_ReturnsTrue_Test()
        {
            var newUserDto = MedecinAppelantTestHelper.GetFakeMedecinAppelantDto();
            var medecinAppelantBll = new MedecinAppelantBLL();
            var addOrUpdateMedecinAppelantResult = medecinAppelantBll.AddOrUpdateMedecinAppelant(newUserDto);
            Assert.IsTrue(addOrUpdateMedecinAppelantResult.Success);
        }
    }
}
