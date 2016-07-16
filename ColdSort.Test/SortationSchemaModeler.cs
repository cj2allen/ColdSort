using ColdSort.Core.Enums;
using ColdSort.Core.Interfaces.Models;
using ColdSort.Models;
using System.Collections.Generic;

namespace ColdSort.Test
{
    public static class SortationSchemaModeller
    {
        public static SortationSchema DefaultSortationSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Default Sort";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema EraSortationSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Era Sort";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Year,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema RandomSortationSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Random Sort";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Year,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema MustPerfectlySortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Perfect Sort";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema MixOfSortingEndsSortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Mix of Ends";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Year,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema AbbreviateEVERYTHINGSortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Abbreviate";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Year,
                    AllowSortEnd = true,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = true,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = true,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = true,
                    UseAbbreviation = true
                }
            };

            return sortationSchema;
        }

        public static SortationSchema NoNodesSortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "No Nodes";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
            };

            return sortationSchema;
        }

        public static SortationSchema PathTooLongSortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Too Long";
            sortationSchema.KeepFilesAtOriginalLocation = false;
            sortationSchema.FailedSortationDefault = "Too Long!";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Title,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }

        public static SortationSchema KeepAtLocationSortSchema()
        {
            SortationSchema sortationSchema = new SortationSchema();
            sortationSchema.SortationSchemaTitle = "Perfect Sort";
            sortationSchema.KeepFilesAtOriginalLocation = true;
            sortationSchema.FailedSortationDefault = "!Unsorted";
            sortationSchema.SortationNodes = new List<ISortationNode>
            {
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = true
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Artist,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                },
                new SortationNode
                {
                    SongProperty = SongProperty.Album,
                    AllowSortEnd = false,
                    UseAbbreviation = false
                }
            };

            return sortationSchema;
        }
    }
}
