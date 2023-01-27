using SerieDLL_EF;
using SerieDLL_EF.BDD;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace Test_SerieDLL_EF.RepositoryTests
{
    [TestClass]
    public class PersonnageRepositoryTest
    {
        [TestMethod]
        [TestCategory("Personnage Repository : GetAll")]
        public void GetAll_ReturnsListOfPersonnages()
        {

            // Arrange
            
            var repository = new PersonnageRepository();

            // Act
            var result = repository.GetAll().Count;

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        [TestCategory("Personnage Repository : GetById")]
        public void GetById_ReturnsPersonnageNom()
        {
            // Arrange
            int id = 2;
            string expectedNom = "Sylvie";
            var repository = new PersonnageRepository();

            // Act
            var result = repository.GetById(id);

            // Assert
            Assert.AreEqual(expectedNom, result.Nom);
        }

        [TestMethod]
        [TestCategory("Personnage Repository : GetByTxt")]
        public void GetByText_ShouldReturnCorrectNom()
        {
            // Arrange
            var personnageRepository = new PersonnageRepository();
            var personnage = new Personnage { ActeurId = 2, SerieId = 1, Nom = "Batman" };
            personnageRepository.Add(personnage);


            // Act
            var result = personnageRepository.GetByTxt("Batman");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Batman", result.First().Nom);
        }

        [TestMethod]
        [TestCategory("Personnage Repository : Add")]
        public void Add_ShouldAddPersonnageToTable()
        {
            // Arrange
            var personnageRepository = new PersonnageRepository();
            var personnageToAdd = new Personnage { ActeurId = 2, SerieId = 1, Nom = "BadBoy" };

            // Act
            personnageRepository.Add(personnageToAdd);
            var result = personnageRepository.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("BadBoy", result.Last().Nom);
        }

        [TestMethod]
        [TestCategory("Personnage Repository : Update")]
        public void Update_UpdatesPersonnageInDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var personnageToUpdate = new Personnage { ActeurId = 2, SerieId = 1, Nom = "ChaussetteMan" };
            var repo = new PersonnageRepository();
            context.Personnages.Add(personnageToUpdate);
            context.SaveChanges();
            personnageToUpdate.Nom = "SockMan";

            // Act
            repo.Update(personnageToUpdate);

            // Assert
            var updatedPersonnage = context.Personnages.Find(personnageToUpdate.Id);
            Assert.AreEqual(personnageToUpdate.Nom, updatedPersonnage.Nom);
            context.Personnages.Remove(personnageToUpdate);
            context.SaveChanges();
        }

        [TestMethod]
        [TestCategory("Personnage Repository : Delete")]

        public void Delete_RemovesPersonnageFromDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var personnageToDelete = new Personnage { ActeurId = 2, SerieId = 1, Nom = "DemonBoy" };
            var repo = new PersonnageRepository();
            context.Personnages.Add(personnageToDelete);
            context.SaveChanges();

            // Act
            repo.Delete(personnageToDelete);

            // Assert
            Assert.IsFalse(context.Personnages.Any(a => a.Id == personnageToDelete.Id));
        }

        [TestMethod]
        [TestCategory("Personnage Repository : Export")]

        public void Export_ReturnsCorrectPersonnage()
        {
            List<Personnage> expectedList = new();

            // set up expected list
            Personnage person1 = new()
            {
                SerieId = 2,
                ActeurId = 2,
                Nom = "SatanGirl"
            };
            expectedList.Add(person1);

            Personnage person2 = new()
            {
                SerieId = 2,
                ActeurId = 2,
                Nom = "EnferDog"
            };
            expectedList.Add(person2);

            // arrange
            BddprojetContext context = new();
            context.Personnages.AddRange(expectedList);
            context.SaveChanges();

            // act
            List<Personnage> resultList = new PersonnageRepository().GetBySerie(2);

            // assert
            Assert.AreEqual(8,resultList.Count);
        }

    }
}