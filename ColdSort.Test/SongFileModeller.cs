using System.Collections.Generic;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Models;

namespace ColdSort.Test
{
    public static class SongFileModeller
    {
        public static List<ISongFile> SimpleSortationTestData()
        {
            return new List<ISongFile>
            {
                new MP3File
                {
                    Title = "Traffic",
                    Artist = "Tiësto",
                    Album = "Just Be",
                    Year = "2004",
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3"
                },
                new MP3File
                {
                    Title = "Receiving End of It All",
                    Artist = "Streetlight Manifesto",
                    Album = "Somewhere in the Between",
                    Year = "2007",
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new MP3File
                {
                    Title = "Rebound",
                    Artist = "Arty & Mat Zo",
                    Album = "Rebound",
                    Year = "2011",
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3"
                },
                new MP3File
                {
                    Title = "Sick, Sick, Sick",
                    Artist = "Queens of the Stoneage",
                    Album = "Era Vulgaris",
                    Year = "2007",
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3"
                },
                new MP3File
                {
                    Title = "Viking (Original Mix)",
                    Artist = "Orjan Nilsen",
                    Album = "Universal Religion Chapter 5 (Disc 1)",
                    Year = "2011",
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3"
                },
                new MP3File
                {
                    Title = "Everything Went Numb",
                    Artist = "Streetlight Manifesto",
                    Album = "Everything Goes Numb",
                    Year = "2003",
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> SimpleSortationTest1GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\T\Tiësto\Just Be\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\S\Streetlight Manifesto\Somewhere in the Between\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\A\Arty & Mat Zo\Rebound\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Q\Queens of the Stoneage\Era Vulgaris\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\O\Orjan Nilsen\Universal Religion Chapter 5 (Disc 1)\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\S\Streetlight Manifesto\Everything Goes Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> SimpleSortationTest2GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2004\Tiësto\Just Be\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2007\Streetlight Manifesto\Somewhere in the Between\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2011\Arty & Mat Zo\Rebound\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2007\Queens of the Stoneage\Era Vulgaris\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2011\Orjan Nilsen\Universal Religion Chapter 5 (Disc 1)\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2003\Streetlight Manifesto\Everything Goes Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> SimpleSortationTest3GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\J\Tiësto\2004\Just Be\Traffic\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\S\Streetlight Manifesto\2007\Somewhere in the Between\Receiving End of It All\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\R\Arty & Mat Zo\2011\Rebound\Rebound\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\E\Queens of the Stoneage\2007\Era Vulgaris\Sick, Sick, Sick\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\U\Orjan Nilsen\2011\Universal Religion Chapter 5 (Disc 1)\Viking (Original Mix)\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\E\Streetlight Manifesto\2003\Everything Goes Numb\Everything Went Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISongFile> MetadataTestData()
        {
            return new List<ISongFile>
            {
                new MP3File
                {
                    Title = "Traffic",
                    Artist = "Tiësto",
                    Album = "",
                    Year = "2004",
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3"
                },
                new MP3File
                {
                    Title = "Receiving End of It All",
                    Artist = "",
                    Album = "Somewhere in the Between",
                    Year = "2007",
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new MP3File
                {
                    Title = "Rebound",
                    Artist = "Arty & Mat Zo",
                    Album = "Rebound",
                    Year = "",
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3"
                },
                new MP3File
                {
                    Title = "",
                    Artist = "Queens of the Stoneage",
                    Album = "Era Vulgaris",
                    Year = "2007",
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3"
                },
                new MP3File
                {
                    Title = "",
                    Artist = "",
                    Album = "",
                    Year = "",
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3"
                },
                new MP3File
                {
                    Title = "Everything Went Numb",
                    Artist = "Streetlight Manifesto",
                    Album = "Everything Goes Numb",
                    Year = "2003",
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> MetadataTest1GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\T\Tiësto\Traffic - Tiësto.mp3"
               },
               new FailedSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\A\Arty & Mat Zo\Rebound\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Q\Queens of the Stoneage\Era Vulgaris\Sick, Sick, Sick.mp3"
                },
                new FailedSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\S\Streetlight Manifesto\Everything Goes Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> MetadataTest2GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new FailedSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Traffic - Tiësto.mp3"
               },
               new FailedSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\A\Arty & Mat Zo\Rebound\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Q\Queens of the Stoneage\Era Vulgaris\Sick, Sick, Sick.mp3"
                },
                new FailedSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\S\Streetlight Manifesto\Everything Goes Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> MetadataTest3GoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2004\T\Tiësto\Traffic - Tiësto.mp3"
               },
               new FailedSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2007\Q\Queens of the Stoneage\Era Vulgaris\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2003\S\Streetlight Manifesto\Everything Goes Numb\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> AbbriviationGoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\T\J\T\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\S\S\R\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\A\R\R\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\Q\E\S\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\O\U\V\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\2\S\E\E\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> NoNodesGoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> PathTooLongGoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new SuccessfulSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Traffic - Tiësto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Traffic - Tiësto.mp3"
               },
               new SuccessfulSortation
               {
                    OriginalPath = @"C:\Users\Chris\Music\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Receiving_End_Of_It_All-Streetlight_Manifesto.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Rebound_-_Arty_And_MatZo.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Rebound_-_Arty_And_MatZo.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Sick, Sick, Sick.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Sick, Sick, Sick.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Viking - Orjan Nilsen.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Viking - Orjan Nilsen.mp3"
                },
                new SuccessfulSortation
                {
                    OriginalPath = @"C:\Users\Chris\Music\Everything Went Numb - Streelight Manifesto.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\Too Long!\Everything Went Numb - Streelight Manifesto.mp3"
                }
            };
        }

        public static List<ISongFile> InvalidCharacterTestData()
        {
            return new List<ISongFile>
            {
                new MP3File
                {
                    Title = "DOTA [Club Mix]",
                    Artist = "BassHunter",
                    Album = "LOL <(^^,)>",
                    Year = "2008",
                    OriginalPath = @"C:\Users\Chris\Music\Dota - Basshunter.mp3"
                }
            };
        }

        public static List<ISortationSchemaResult> InvalidCharacterGoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new FailedSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Dota - Basshunter.mp3",
                    SortedPath = @"C:\Users\Chris\New Music\!Unsorted\Dota - Basshunter.mp3"
               }
            };
        }

        public static List<ISortationSchemaResult> KeepAtLocationGoldResults()
        {
            return new List<ISortationSchemaResult>
            {
               new FailedSortation {
                    OriginalPath = @"C:\Users\Chris\Music\Dota - Basshunter.mp3",
                    SortedPath = @"C:\Users\Chris\Music\Dota - Basshunter.mp3"
               }
            };
        }
    }
}
