using FlsBLL.BLL;
using FlsBLL.Mapper;
using FlsBLL.Tests.Helpers;
using FlsCommon.DTO;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FlsBLL.Tests
{
    [TestFixture]
    public sealed class DossiersBllTest
    {
        [SetUp]
        public void TestInitialize()
        {
            //Initialisation des mappings profiles
            var loadMappers = new MainMapperProfile();
            loadMappers.ConfigureObjectMapper();
        }

        [Test]
        public void AddDossier_ReturnsFalse_Test()
        {
            var dossierDto = new DossierDto();
            var dossierBll = new DossiersBLL();
            var addOrUpdateDossierResult = dossierBll.AddOrUpdateDossier(dossierDto);
            Assert.IsFalse(addOrUpdateDossierResult.Success);
        }

        [Test]
        public void AddDossier_WithoutSavingMedecinAppelantFirst_ReturnFalse_Test()
        {
            var medecinAppelantDto = MedecinAppelantTestHelper.GetFakeMedecinAppelantDto();
            var newDossierDto = new DossierDto
            {
                IdMedecinAppelant = 0,
                MedecinAppelantDto = medecinAppelantDto
            };
            var dossierBll = new DossiersBLL();
            var addOrUpdateDossierResult = dossierBll.AddOrUpdateDossier(newDossierDto);
            Assert.IsFalse(addOrUpdateDossierResult.Success);
        }

        [Test]
        public void AddDossier_WithSavingMedecinAppelantFirst_ReturnTrue_Test()
        {
            var medecinAppelantDto = MedecinAppelantTestHelper.GetFakeMedecinAppelantDto();
            var medecinAppelantBll = new MedecinAppelantBLL();
            var addOrUpdateMedecinAppelantResult = medecinAppelantBll.AddOrUpdateMedecinAppelant(medecinAppelantDto);
            Assert.IsTrue(addOrUpdateMedecinAppelantResult.Success);
            var medecinAppelantDtoSaved = addOrUpdateMedecinAppelantResult.Result;

            var newDossierDto = new DossierDto
            {
                IdMedecinAppelant = medecinAppelantDtoSaved.Id,
                MedecinAppelantDto = medecinAppelantDto
            };
            var dossierBll = new DossiersBLL();
            var addOrUpdateDossierResult = dossierBll.AddOrUpdateDossier(newDossierDto);
            Assert.IsTrue(addOrUpdateDossierResult.Success);
        }
    }
}
