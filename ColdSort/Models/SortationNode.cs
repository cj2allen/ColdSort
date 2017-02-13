//-----------------------------------------------------------------------
// <copyright file="SortationNode.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------

using ColdSort.Enums;

namespace ColdSort.Models
{
    /// <summary>
    /// The sortation node
    /// </summary>
    public class SortationNode
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SortationNode"/> class
        /// </summary>
        public SortationNode()
        {
            SongProperty = 0;
            AllowSortEnd = true;
            UseAbbreviation = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// <see cref="SortationNode.SortationNodeName"/>
        /// </summary>
        public string SortationNodeName
        {
            get
            {
                string abbrivations = "";

                if (UseAbbreviation)
                {
                    abbrivations = ", Abrv";

                    if (CondenseNumbersToSymbol || CondenseAccents || CondenseSymbols || CapitalizeAbbreviation)
                    {
                        abbrivations += "(";

                        if (CondenseNumbersToSymbol)
                        {
                            abbrivations += "#, ";
                        }

                        if (CondenseAccents)
                        {
                            abbrivations += "ÉE, ";
                        }

                        if (CondenseSymbols)
                        {
                            abbrivations += "Ω, ";
                        }

                        if (CapitalizeAbbreviation)
                        {
                            abbrivations += "aA, ";
                        }

                        abbrivations = abbrivations.Remove(abbrivations.Length - 2);

                        abbrivations += ")";
                    }
                }

                return $"{SongProperty.ToString()}{abbrivations}{(AllowSortEnd ? ", Can End" : string.Empty)}";
            }
        }

        /// <summary>
        /// <see cref="SortationNode.SongProperty"/>
        /// </summary>
        public SongProperty SongProperty { get; set; }

        /// <summary>
        /// <see cref="SortationNode.AllowSortEnd"/>
        /// </summary>
        public bool AllowSortEnd { get; set; }

        /// <summary>
        /// <see cref="SortationNode.UseAbbreviation"/>
        /// </summary>
        public bool UseAbbreviation { get; set; }

        /// <summary>
        /// <see cref="SortationNode.CondenseNumbersToSymbol"/>
        /// </summary>
        public bool CondenseNumbersToSymbol { get; set; }

        /// <summary>
        /// <see cref="SortationNode.CapitalizeAbbreviation"/>
        /// </summary>
        public bool CapitalizeAbbreviation { get; set; }

        /// <summary>
        /// <see cref="SortationNode.CondenseAccent"/>
        /// </summary>
        public bool CondenseAccents { get; set; }

        /// <summary>
        /// <see cref="SortationNode.CondenseSymbols"/>
        /// </summary>
        public bool CondenseSymbols { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the sortation node's property as a string
        /// </summary>
        /// <returns> The song's sortation property as a string </returns>
        public string GetSortationNodeProperty()
        {
            return SongProperty.ToString();
        }

        #endregion
    }
}