using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    class Database
    {
        #region GetFamilyTree

        public static Person GetFamilyTree()
        {
            // In a real app this method would access a database.
            return new Person
            {
                Name = "David Weatherbeam",
                Children =
                {
                    new Person
                    {
                        Name="Alberto Weatherbeam",
                        Children=
                        {
                            new Person
                            {
                                Name="Zena Hairmonger",
                                Children=
                                {
                                    new Person
                                    {
                                        Name="Sarah Applifunk",
                                    }
                                }
                            },
                            new Person
                            {
                                Name="Jenny van Machoqueen",
                                Children=
                                {
                                    new Person
                                    {
                                        Name="Nick van Machoqueen",
                                    },
                                    new Person
                                    {
                                        Name="Matilda Porcupinicus",
                                    },
                                    new Person
                                    {
                                        Name="Bronco van Machoqueen",
                                    }
                                }
                            }
                        }
                    },
                    new Person
                    {
                        Name="Komrade Winkleford",
                        Children=
                        {
                            new Person
                            {
                                Name="Maurice Winkleford",
                                Children=
                                {
                                    new Person
                                    {
                                        Name="Divinity W. Llamafoot",
                                    }
                                }
                            },
                            new Person
                            {
                                Name="Komrade Winkleford, Jr.",
                                Children=
                                {
                                    new Person
                                    {
                                        Name="Saratoga Z. Crankentoe",
                                    },
                                    new Person
                                    {
                                        Name="Excaliber Winkleford",
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        #endregion // GetFamilyTree
    }
}
