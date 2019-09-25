using System.IO;
using Algs.DependencyManagement;
using AlgsTest.HelperClasses;
using NUnit.Framework;
using AlgsTest.HelperInterfaces;

namespace AlgsTest
{
    [TestFixture]
    public class TestInjector
    {
        [SetUp]
        public void Setup ()
        {
            Injector.Clear();
        }

        [Test]
        public void TestSimpleInjection ()
        {
            //Arrange
            var dataStorage = new DataStorage();
            var noteList = new NoteList(dataStorage);
            var noteText = "myCustomNote";

            //Act
            noteList.Add(noteText);

            //Assert
            using (StreamReader reader = new StreamReader("db.txt"))
            {
                var all = reader.ReadToEnd();
                Assert.IsTrue(all.Contains(noteText));
            }

            File.Delete("db.txt");
        }

        [Test]
        public void TestInjectorWorks ()
        {
            //Set injector
            Injector.Map<IDataStorage, DataStorage>();

            //Arrange
            var dataStorage = Injector.Get<IDataStorage>();
            var noteList = new NoteList(dataStorage);
            var noteText = "myCustomNote";

            //Act
            noteList.Add(noteText);

            //Assert
            using (StreamReader reader = new StreamReader("db.txt"))
            {
                var all = reader.ReadToEnd();
                Assert.IsTrue(all.Contains(noteText));
            }

            File.Delete("db.txt");
        }

        [Test]
        public void TestInjectorGetsNoteList ()
        {
            //Set injector
            Injector.Map<IDataStorage, DataStorage>();

            //Arrange
            var noteList = Injector.Get<NoteList>();
            var noteText = "myCustomNote";

            //Act
            noteList.Add(noteText);

            //Assert
            using (StreamReader reader = new StreamReader("db.txt"))
            {
                var all = reader.ReadToEnd();
                Assert.IsTrue(all.Contains(noteText));
            }

            File.Delete("db.txt");
        }
    }
}