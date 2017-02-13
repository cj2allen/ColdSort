using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColdSort.Services;
using ColdSort.Views;
using ColdSort.Models;
using System.Collections.Generic;
using ColdSort.Core.Interfaces.Models;

namespace ColdSort.Test
{
    [TestClass]
    public class ColdSortTest
    {
        public const string OLD_PATH = @"C:\Users\Chris\Music\";
        public const string NEW_PATH = @"C:\Users\Chris\New Music\";

        #region Simple Tests

        [TestMethod]
        public void SimpleSortationTest1()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.DefaultSortationSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);            
            var goldResults = SongFileModeller.SimpleSortationTest1GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SortationPathResult)results[i];
                var goldResult = (SortationPathResult) goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        [TestMethod]
        public void SimpleSortationTest2()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.EraSortationSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.SimpleSortationTest2GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SortationPathResult)results[i];
                var goldResult = (SortationPathResult)goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        [TestMethod]
        public void SimpleSortationTest3()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.RandomSortationSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.SimpleSortationTest3GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SortationPathResult)results[i];
                var goldResult = (SortationPathResult)goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        #endregion

        #region Metadata Test

        [TestMethod]
        public void MetadataTest1()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.DefaultSortationSchema();
            List<SongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest1GoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void MetadataTest2()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.MustPerfectlySortSchema();
            List<SongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest2GoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void MetadataTest3()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.MixOfSortingEndsSortSchema();
            List<SongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest3GoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        #endregion

        #region Abbriviation Tests

        [TestMethod]
        public void AbbriviationTest()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.AbbreviateEVERYTHINGSortSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.AbbriviationGoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        #endregion

        #region Weird Tests

        [TestMethod]
        public void NoNodesTest()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.NoNodesSortSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.NoNodesGoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void PathTooLongTest()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.PathTooLongSortSchema();
            List<SongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.PathTooLongGoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SortationPathResult);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SortationPathResult);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SortationPathResult);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SortationPathResult);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SortationPathResult);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void InvalidCharacterTest()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.MustPerfectlySortSchema();
            List<SongFile> songFiles = SongFileModeller.InvalidCharacterTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 1);
            var goldResults = SongFileModeller.InvalidCharacterGoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);
        }

        [TestMethod]
        public void KeepAtLocationTest()
        {
            MainView mainView = new MainView();
            SortationSchema sortationSchema = SortationSchemaModeller.KeepAtLocationSortSchema();
            List<SongFile> songFiles = SongFileModeller.InvalidCharacterTestData();
            SortationService SortationService = new SortationService(mainView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = SortationService.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 1);
            var goldResults = SongFileModeller.KeepAtLocationGoldResults();

            Assert.IsTrue(results[0] is SortationPathResult);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);
        }

        #endregion
    }
}
