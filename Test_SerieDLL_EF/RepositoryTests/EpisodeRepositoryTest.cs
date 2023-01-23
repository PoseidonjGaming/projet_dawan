using SerieDLL_EF;
using SerieDLL_EF.BDD;
using SerieDLL_EF.Models;
using SerieDLL_EF.Repository;

namespace Test_SerieDLL_EF.RepositoryTests
{
    [TestClass]
    public class EpisodeRepositoryTest
    {
        [TestMethod]
        [TestCategory("Episode Repository : GetAll")]
        public void GetAll_ReturnsListOfEpisode()
        {

            // Arrange
           
            var repository = new EpisodeRepository();

            // Act
            var result = repository.GetAll().Count;

            // Assert
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        [TestCategory("Episode Repository : GetById")]
        public void GetById_ReturnsEpisodeNom()
        {
            // Arrange
            int id = 1;
            string expectedNom = "Filmé devant public";
            var repository = new EpisodeRepository();

            // Act
            var result = repository.GetById(id);

            // Assert
            Assert.AreEqual(expectedNom, result.Nom);
        }

        [TestMethod]
        [TestCategory("Episode Repository : GetByTxt")]
        public void GetByText_ShouldReturnCorrectNom()
        {
            // Arrange
            var episodeRepository = new EpisodeRepository();
            var episode = new Episode { SaisonId = 2, Nom = "Pilote", Resume = "Premier épisode de la série" };
            episodeRepository.Add(episode);


            // Act
            var result = episodeRepository.GetByTxt("Pilote");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Pilote", result.First().Nom);
        }

        [TestMethod]
        [TestCategory("Episode Repository : Add")]
        public void Add_ShouldAddEpisodeToTable()
        {
            // Arrange
            var episodeRepository = new EpisodeRepository();
            var episodeToAdd = new Episode { SaisonId = 2, Nom = "Les méchants", Resume = "Les méchants sont de la partie" };

            // Act
            episodeRepository.Add(episodeToAdd);
            var result = episodeRepository.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Les méchants", result.Last().Nom);
            Assert.AreEqual("Les méchants sont de la partie", result.Last().Resume);
        }

        [TestMethod]
        [TestCategory("Episode Repository : Update")]
        public void Update_UpdatesEpisodeInDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var episodeToUpdate = new Episode { SaisonId = 2, Nom = "Les grands méchants", Resume = "Ils sont encore plus méchants que les méchants" };
            var repo = new EpisodeRepository();
            context.Episodes.Add(episodeToUpdate);
            context.SaveChanges();
            episodeToUpdate.Nom = "Les supers grands méchants";

            // Act
            repo.Update(episodeToUpdate);

            // Assert
            var updatedEpisode = context.Episodes.Find(episodeToUpdate.Id);
            Assert.AreEqual(episodeToUpdate.Nom, updatedEpisode.Nom);
            context.Episodes.Remove(episodeToUpdate);
            context.SaveChanges();
        }

        [TestMethod]
        [TestCategory("Episode Repository : Delete")]

        public void Delete_RemovesEpisodeFromDatabase()
        {
            // Arrange
            var context = new BddprojetContext();
            var episodeToDelete = new Episode { SaisonId = 2, Nom = "Les gentils", Resume = "Les gentils bottent le cul des méchants" };
            var repo = new EpisodeRepository();
            context.Episodes.Add(episodeToDelete);
            context.SaveChanges();

            // Act
            repo.Delete(episodeToDelete);

            // Assert
            Assert.IsFalse(context.Episodes.Any(a => a.Id == episodeToDelete.Id));
        }



    }
}