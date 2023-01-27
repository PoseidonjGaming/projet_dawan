using SerieDLL_EF;
using SerieDLL_EF.BDD;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace Test_SerieDLL_EF.RepositoryTests
{
    [TestClass]
    public class ActeurRepositoryTest
    {
        [TestMethod]
        [TestCategory("Acteur Repository : GetAll")]
        public void GetAll_ReturnsListOfActeurs()
        {

            // Arrange
            
            var repository = new ActeurRepository();

            // Act
            var result = repository.GetAll().Count;

            // Assert
            Assert.AreEqual(18,result);
        }

        [TestMethod]
        [TestCategory("Acteur Repository : GetById")]
        public void GetById_ReturnsActeurrNomEtPrenom()
        {
            // Arrange
            int id = 1;
            string expectedNom = "Hiddleston";
            string expectedPrenom = "Tom";
            var repository = new ActeurRepository();

            // Act
            var result = repository.GetById(id);

            // Assert
            Assert.AreEqual(expectedNom, result.Nom);
            Assert.AreEqual(expectedPrenom, result.Prenom);
        }

        [TestMethod]
        [TestCategory("Acteur Repository : GetByTxt")]
        public void GetByText_ShouldReturnCorrectNomEtPrenom()
        {
            // Arrange
            var acteurRepository = new ActeurRepository();
            var acteur = new Acteur { Nom = "Doe", Prenom = "John" };
            acteurRepository.Add(acteur);


            // Act
            var result = acteurRepository.GetByTxt("Doe");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Doe", result.First().Nom);
            Assert.AreEqual("John", result.First().Prenom);
        }

        [TestMethod]
        [TestCategory("Acteur Repository : Add")]
        public void Add_ShouldAddActeurToTable()
        {
            // Arrange
            var acteurRepository = new ActeurRepository();
            var acteurToAdd = new Acteur { Nom = "Marcel", Prenom = "Pierre" };

            // Act
            acteurRepository.Add(acteurToAdd);
            var result = acteurRepository.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Marcel", result.Last().Nom);
            Assert.AreEqual("Pierre", result.Last().Prenom);
        }

        [TestMethod]
        [TestCategory("Acteur Repository : Update")]
        public void Update_UpdatesActeurInDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var acteurToUpdate = new Acteur { Nom = "Marcel", Prenom = "Pierre" };
            var repo = new ActeurRepository();
            context.Acteurs.Add(acteurToUpdate);
            context.SaveChanges();
            acteurToUpdate.Nom = "Dupont";

            // Act
            repo.Update(acteurToUpdate);

            // Assert
            var updatedActeur = context.Acteurs.Find(acteurToUpdate.Id);
            Assert.AreEqual(acteurToUpdate.Nom, updatedActeur.Nom);
            context.Acteurs.Remove(acteurToUpdate);
            context.SaveChanges();
        }

        [TestMethod]
        [TestCategory("Acteur Repository : Delete")]

        public void Delete_RemovesActeurFromDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var acteurToDelete = new Acteur { Nom = "Dupont", Prenom = "Laurent" };
            var repo = new ActeurRepository();
            context.Acteurs.Add(acteurToDelete);
            context.SaveChanges();

            // Act
            repo.Delete(acteurToDelete);

            // Assert
            Assert.IsFalse(context.Acteurs.Any(a => a.Id == acteurToDelete.Id));
        }

        [TestMethod]
        [TestCategory("Acteur Repository : Export")]

        public void Export_ReturnsCorrectActeur()
        {
            // Arrange
            var context = new BddprojetContext();
            var acteur1 = new Acteur { Nom = "Doe", Prenom = "John" };
            var acteur2 = new Acteur { Nom = "Doe", Prenom = "Jane" };
            context.Acteurs.Add(acteur1);
            context.Acteurs.Add(acteur2);
            context.SaveChanges();
            var repo = new ActeurRepository();

            // Act
            var result = repo.Export(acteur1.Id);

            // Assert
            Assert.AreEqual(acteur1.Nom, result.Nom);
        }

    }
}