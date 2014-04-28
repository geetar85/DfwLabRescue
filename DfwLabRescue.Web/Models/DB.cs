using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DfwLabRescue.Web.Models
{
    public static class DB
    {
        static ICollection<Dog> _dogs;
        static ICollection<Content> _allContent;

        public static void Load()
        {
            _dogs = new DogBuilder().Build();
            _allContent = new ContentBuilder().Build();
        }

        public static ICollection<Dog> Dogs
        {
            get
            {
                return _dogs;
            }
        }

        public static ICollection<Content> AllContent
        {
            get
            {
                return _allContent;
            }
        }
    }
}