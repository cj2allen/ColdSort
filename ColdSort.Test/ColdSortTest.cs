using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColdSort.Controllers;
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
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.DefaultSortationSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);            
            var goldResults = SongFileModeller.SimpleSortationTest1GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SuccessfulSortation)results[i];
                var goldResult = (SuccessfulSortation) goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        [TestMethod]
        public void SimpleSortationTest2()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.EraSortationSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.SimpleSortationTest2GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SuccessfulSortation)results[i];
                var goldResult = (SuccessfulSortation)goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        [TestMethod]
        public void SimpleSortationTest3()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.RandomSortationSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.SimpleSortationTest3GoldResults();
            for (int i = 0; i < 6; i++)
            {
                var result = (SuccessfulSortation)results[i];
                var goldResult = (SuccessfulSortation)goldResults[i];
                Assert.IsTrue(result.OriginalPath == goldResult.OriginalPath);
                Assert.IsTrue(result.SortedPath == goldResult.SortedPath);
            }
        }

        #endregion

        #region Metadata Test

        [TestMethod]
        public void MetadataTest1()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.DefaultSortationSchema();
            List<ISongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest1GoldResults();

            Assert.IsTrue(results[0] is SuccessfulSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is FailedSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SuccessfulSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SuccessfulSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is FailedSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SuccessfulSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void MetadataTest2()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.MustPerfectlySortSchema();
            List<ISongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest2GoldResults();

            Assert.IsTrue(results[0] is FailedSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is FailedSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SuccessfulSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SuccessfulSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is FailedSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SuccessfulSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void MetadataTest3()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.MixOfSortingEndsSortSchema();
            List<ISongFile> songFiles = SongFileModeller.MetadataTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.MetadataTest3GoldResults();

            Assert.IsTrue(results[0] is SuccessfulSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is FailedSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SuccessfulSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SuccessfulSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SuccessfulSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SuccessfulSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        #endregion

        #region Abbriviation Tests

        [TestMethod]
        public void AbbriviationTest()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.AbbreviateEVERYTHINGSortSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.AbbriviationGoldResults();

            Assert.IsTrue(results[0] is SuccessfulSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SuccessfulSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SuccessfulSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SuccessfulSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SuccessfulSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SuccessfulSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        #endregion

        #region Weird Tests

        [TestMethod]
        public void NoNodesTest()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.NoNodesSortSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.NoNodesGoldResults();

            Assert.IsTrue(results[0] is SuccessfulSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is SuccessfulSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is SuccessfulSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is SuccessfulSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is SuccessfulSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is SuccessfulSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        [TestMethod]
        public void PathTooLongTest()
        {
            ProgressView progressView = new ProgressView();
            SortationSchema sortationSchema = SortationSchemaModeller.PathTooLongSortSchema();
            List<ISongFile> songFiles = SongFileModeller.SimpleSortationTestData();
            SortationController sortationController = new SortationController(progressView, sortationSchema, OLD_PATH, NEW_PATH);
            List<ISortationSchemaResult> results = sortationController.GenerateSortationPaths(songFiles);
            Assert.IsTrue(results.Count == 6);
            var goldResults = SongFileModeller.PathTooLongGoldResults();

            Assert.IsTrue(results[0] is FailedSortation);
            Assert.IsTrue(results[0].OriginalPath == goldResults[0].OriginalPath);
            Assert.IsTrue(results[0].SortedPath == goldResults[0].SortedPath);

            Assert.IsTrue(results[1] is FailedSortation);
            Assert.IsTrue(results[1].OriginalPath == goldResults[1].OriginalPath);
            Assert.IsTrue(results[1].SortedPath == goldResults[1].SortedPath);

            Assert.IsTrue(results[2] is FailedSortation);
            Assert.IsTrue(results[2].OriginalPath == goldResults[2].OriginalPath);
            Assert.IsTrue(results[2].SortedPath == goldResults[2].SortedPath);

            Assert.IsTrue(results[3] is FailedSortation);
            Assert.IsTrue(results[3].OriginalPath == goldResults[3].OriginalPath);
            Assert.IsTrue(results[3].SortedPath == goldResults[3].SortedPath);

            Assert.IsTrue(results[4] is FailedSortation);
            Assert.IsTrue(results[4].OriginalPath == goldResults[4].OriginalPath);
            Assert.IsTrue(results[4].SortedPath == goldResults[4].SortedPath);

            Assert.IsTrue(results[5] is FailedSortation);
            Assert.IsTrue(results[5].OriginalPath == goldResults[5].OriginalPath);
            Assert.IsTrue(results[5].SortedPath == goldResults[5].SortedPath);
        }

        #endregion
    }
}
